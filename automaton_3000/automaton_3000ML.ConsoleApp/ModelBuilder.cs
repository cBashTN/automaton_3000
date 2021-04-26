// This file was auto-generated by ML.NET Model Builder. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;
using Automaton_3000ML.Model;
using Microsoft.ML.Trainers.FastTree;

namespace Automaton_3000ML.ConsoleApp
{
    public static class ModelBuilder
    {
        private static string TRAIN_DATA_FILEPATH = @"C:\_source\Repos\github\automaton_3000\automaton_3000\ExtractFeatures\bin\Debug\net5.0\Output\crew.csv";
        private static string MODEL_FILEPATH = @"C:\Users\sebas\AppData\Local\Temp\MLVSTools\automaton_3000ML\automaton_3000ML.Model\MLModel.zip";
        // Create MLContext to be shared across the model creation workflow objects 
        // Set a random seed for repeatable/deterministic results across multiple trainings.
        private static MLContext mlContext = new MLContext(seed: 1);

        public static void CreateModel()
        {
            // Load Data
            IDataView trainingDataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                                            path: TRAIN_DATA_FILEPATH,
                                            hasHeader: true,
                                            separatorChar: ';',
                                            allowQuoting: true,
                                            allowSparse: false);

            // Build training pipeline
            IEstimator<ITransformer> trainingPipeline = BuildTrainingPipeline(mlContext);

            // Train Model
            ITransformer mlModel = TrainModel(mlContext, trainingDataView, trainingPipeline);

            // Evaluate quality of Model
            Evaluate(mlContext, trainingDataView, trainingPipeline);

            // Save model
            SaveModel(mlContext, mlModel, MODEL_FILEPATH, trainingDataView.Schema);
        }

        public static IEstimator<ITransformer> BuildTrainingPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations 
            var dataProcessPipeline = mlContext.Transforms.Conversion.ConvertType(new[] { new InputOutputColumnPair("IsInPortal", "IsInPortal"), new InputOutputColumnPair("IsInSeries_ds9", "IsInSeries_ds9"), new InputOutputColumnPair("IsInSeries_dsc", "IsInSeries_dsc"), new InputOutputColumnPair("IsInSeries_ent", "IsInSeries_ent"), new InputOutputColumnPair("IsInSeries_original", "IsInSeries_original"), new InputOutputColumnPair("IsInSeries_pic", "IsInSeries_pic"), new InputOutputColumnPair("IsInSeries_tas", "IsInSeries_tas"), new InputOutputColumnPair("IsInSeries_tng", "IsInSeries_tng"), new InputOutputColumnPair("IsInSeries_tos", "IsInSeries_tos"), new InputOutputColumnPair("IsInSeries_voy", "IsInSeries_voy") })
                                      .Append(mlContext.Transforms.Concatenate("Features", new[] { "IsInPortal", "IsInSeries_ds9", "IsInSeries_dsc", "IsInSeries_ent", "IsInSeries_original", "IsInSeries_pic", "IsInSeries_tas", "IsInSeries_tng", "IsInSeries_tos", "IsInSeries_voy", "SkillsCount", "SkillsCombinationRarity", "SkillsCombinationRarityPerCrewRarity", "MaxRarity", "VoyRank", "GauntletRank", "ScienceSkillCore", "ScienceSkillRangeMin", "ScienceSkillRangeMax", "SecuritySkillCore", "SecuritySkillRangeMin", "SecuritySkillRangeMax", "CommandSkillCore", "CommandSkillRangeMin", "CommandSkillRangeMax", "DiplomacySkillCore", "DiplomacySkillRangeMin", "DiplomacySkillRangeMax", "EngineeringSkillCore", "EngineeringSkillRangeMin", "EngineeringSkillRangeMax", "MedicineSkillCore", "MedicineSkillRangeMin", "MedicineSkillRangeMax", "B_CMD", "A_CMD", "B_SCI", "A_SCI", "B_SEC", "A_SEC", "V_CMD_SCI", "G_CMD_SCI", "V_CMD_SEC", "G_CMD_SEC", "V_CMD_ENG", "G_CMD_ENG", "V_CMD_DIP", "G_CMD_DIP", "V_CMD_MED", "G_CMD_MED", "V_SCI_SEC", "G_SCI_SEC", "V_SCI_ENG", "G_SCI_ENG", "V_SCI_DIP", "G_SCI_DIP", "V_SCI_MED", "G_SCI_MED", "V_SEC_ENG", "G_SEC_ENG", "V_SEC_DIP", "G_SEC_DIP", "V_SEC_MED", "G_SEC_MED", "V_ENG_DIP", "V_ENG_MED", "V_DIP_MED", "EventsCount", "DaysFromDateAdded", "InCollectionsCount", "ShipBattleAccuracyMax", "ShipBattleEvasionMax", "ShipBattleCritChanceMax", "ShipBattleCritBonusMax", "ActionBonusAmount", "ActionCooldown", "ActionInitialCooldown", "ActionDuration", "ActionLimit", "ActionBonusType", "ActionAbilityCondition", "ActionAbilityType", "ActionAbilityAmount", "ActionPenaltyType", "ActionPenaltyAmount", "TraitsCount" }));
            // Set the training algorithm 
            var trainer = mlContext.Regression.Trainers.FastTree(new FastTreeRegressionTrainer.Options() { NumberOfLeaves = 7, MinimumExampleCountPerLeaf = 1, NumberOfTrees = 500, LearningRate = 0.07587501f, Shrinkage = 2.60485f, LabelColumnName = "BigBookTier", FeatureColumnName = "Features" });

            var trainingPipeline = dataProcessPipeline.Append(trainer);

            return trainingPipeline;
        }

        public static ITransformer TrainModel(MLContext mlContext, IDataView trainingDataView, IEstimator<ITransformer> trainingPipeline)
        {
            Console.WriteLine("=============== Training  model ===============");

            ITransformer model = trainingPipeline.Fit(trainingDataView);

            Console.WriteLine("=============== End of training process ===============");
            return model;
        }

        private static void Evaluate(MLContext mlContext, IDataView trainingDataView, IEstimator<ITransformer> trainingPipeline)
        {
            // Cross-Validate with single dataset (since we don't have two datasets, one for training and for evaluate)
            // in order to evaluate and get the model's accuracy metrics
            Console.WriteLine("=============== Cross-validating to get model's accuracy metrics ===============");
            var crossValidationResults = mlContext.Regression.CrossValidate(trainingDataView, trainingPipeline, numberOfFolds: 5, labelColumnName: "BigBookTier");
            PrintRegressionFoldsAverageMetrics(crossValidationResults);
        }

        private static void SaveModel(MLContext mlContext, ITransformer mlModel, string modelRelativePath, DataViewSchema modelInputSchema)
        {
            // Save/persist the trained model to a .ZIP file
            Console.WriteLine($"=============== Saving the model  ===============");
            mlContext.Model.Save(mlModel, modelInputSchema, GetAbsolutePath(modelRelativePath));
            Console.WriteLine("The model is saved to {0}", GetAbsolutePath(modelRelativePath));
        }

        public static string GetAbsolutePath(string relativePath)
        {
            FileInfo _dataRoot = new FileInfo(typeof(Program).Assembly.Location);
            string assemblyFolderPath = _dataRoot.Directory.FullName;

            string fullPath = Path.Combine(assemblyFolderPath, relativePath);

            return fullPath;
        }

        public static void PrintRegressionMetrics(RegressionMetrics metrics)
        {
            Console.WriteLine($"*************************************************");
            Console.WriteLine($"*       Metrics for Regression model      ");
            Console.WriteLine($"*------------------------------------------------");
            Console.WriteLine($"*       LossFn:        {metrics.LossFunction:0.##}");
            Console.WriteLine($"*       R2 Score:      {metrics.RSquared:0.##}");
            Console.WriteLine($"*       Absolute loss: {metrics.MeanAbsoluteError:#.##}");
            Console.WriteLine($"*       Squared loss:  {metrics.MeanSquaredError:#.##}");
            Console.WriteLine($"*       RMS loss:      {metrics.RootMeanSquaredError:#.##}");
            Console.WriteLine($"*************************************************");
        }

        public static void PrintRegressionFoldsAverageMetrics(IEnumerable<TrainCatalogBase.CrossValidationResult<RegressionMetrics>> crossValidationResults)
        {
            var L1 = crossValidationResults.Select(r => r.Metrics.MeanAbsoluteError);
            var L2 = crossValidationResults.Select(r => r.Metrics.MeanSquaredError);
            var RMS = crossValidationResults.Select(r => r.Metrics.RootMeanSquaredError);
            var lossFunction = crossValidationResults.Select(r => r.Metrics.LossFunction);
            var R2 = crossValidationResults.Select(r => r.Metrics.RSquared);

            Console.WriteLine($"*************************************************************************************************************");
            Console.WriteLine($"*       Metrics for Regression model      ");
            Console.WriteLine($"*------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"*       Average L1 Loss:       {L1.Average():0.###} ");
            Console.WriteLine($"*       Average L2 Loss:       {L2.Average():0.###}  ");
            Console.WriteLine($"*       Average RMS:           {RMS.Average():0.###}  ");
            Console.WriteLine($"*       Average Loss Function: {lossFunction.Average():0.###}  ");
            Console.WriteLine($"*       Average R-squared:     {R2.Average():0.###}  ");
            Console.WriteLine($"*************************************************************************************************************");
        }
    }
}
