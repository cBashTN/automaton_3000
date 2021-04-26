using System;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Automaton_3000ML.Model;

namespace Automaton_3000ML.ConsoleApp
{
    public static class FeatureImportance
    {
        public static void ShowFeatureImportanceAndWeights()
        {
            const int permutationCount = 1;

            IDataView trainingDataView = ModelBuilder.mlContext.Data.LoadFromTextFile<ModelInput>(
                path: ModelBuilder.TRAIN_DATA_FILEPATH,
                hasHeader: true,
                separatorChar: ';',
                allowQuoting: true,
                allowSparse: false);

            string[] featureColumnNames =
                trainingDataView.Schema
                    .Select(column => column.Name)
                    .Where(columnName => columnName != "Label" && columnName != "BigBookTier" && columnName != "Traits" && columnName != "TraitsHidden").ToArray();

            var trainer = ModelBuilder.mlContext.Regression.Trainers.FastTree(new FastTreeRegressionTrainer.Options() { NumberOfLeaves = 7, MinimumExampleCountPerLeaf = 1, NumberOfTrees = 500, LearningRate = 0.07587501f, Shrinkage = 2.60485f, LabelColumnName = "Label", FeatureColumnName = "Features" });

            IEstimator<ITransformer> dataPrepEstimator = ModelBuilder.mlContext.Transforms
                .Conversion.ConvertType(new[] { new InputOutputColumnPair("IsInPortal", "IsInPortal"), new InputOutputColumnPair("IsInSeries_ds9", "IsInSeries_ds9"), new InputOutputColumnPair("IsInSeries_dsc", "IsInSeries_dsc"), new InputOutputColumnPair("IsInSeries_ent", "IsInSeries_ent"), new InputOutputColumnPair("IsInSeries_original", "IsInSeries_original"), new InputOutputColumnPair("IsInSeries_pic", "IsInSeries_pic"), new InputOutputColumnPair("IsInSeries_tas", "IsInSeries_tas"), new InputOutputColumnPair("IsInSeries_tng", "IsInSeries_tng"), new InputOutputColumnPair("IsInSeries_tos", "IsInSeries_tos"), new InputOutputColumnPair("IsInSeries_voy", "IsInSeries_voy") })
                .Append(ModelBuilder.mlContext.Transforms.Concatenate("Features", featureColumnNames))
                .Append(ModelBuilder.mlContext.Transforms.NormalizeMinMax("Features"));

            ITransformer dataPrepTransformer = dataPrepEstimator.Fit(trainingDataView);
            IDataView preprocessedTrainData = dataPrepTransformer.Transform(trainingDataView);
            var regressionModel = trainer.Fit(preprocessedTrainData);

            VBuffer<float> weights = new VBuffer<float>();
            //var regressionModel2 = (regressionModel as IEnumerable<dynamic>).OfType<RegressionPredictionTransformer<FastTreeRegressionModelParameters>>().FirstOrDefault();
            regressionModel.Model.GetFeatureWeights(ref weights);
            var weightsValues = weights.GetValues();

            ImmutableArray<RegressionMetricsStatistics> permutationFeatureImportance = ModelBuilder.mlContext
                .Regression
                .PermutationFeatureImportance(regressionModel, preprocessedTrainData, permutationCount:permutationCount);

            var featureImportanceMetrics =
                permutationFeatureImportance
                    .Select((metric, index) => new { index, metric.RSquared })
                    .OrderByDescending(myFeatures => Math.Abs(myFeatures.RSquared.Mean));

            Console.WriteLine("PFI\tFeature\tModelWeights");

            foreach (var feature in featureImportanceMetrics)
            {
                Console.WriteLine($"{featureColumnNames[feature.index]}\t{feature.RSquared.Mean:F6}\t{weightsValues[feature.index]:F6}\t");
            }
        }
    }
}