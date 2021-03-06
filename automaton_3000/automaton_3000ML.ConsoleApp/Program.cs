// This file was auto-generated by ML.NET Model Builder. 

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Automaton_3000ML.Model;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace Automaton_3000ML.ConsoleApp
{
    class Program
    {
        public static Dictionary<string, ModelInput> GetAllInputCrew()
        {
            var allCrewDataWithName = new Dictionary<string, ModelInput>();

            List<ModelInput> allCrewData;
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" };
            using (var reader = new StreamReader(ModelBuilder.TRAIN_DATA_FILEPATH))
            using (var csv = new CsvReader(reader, csvConfig))
            {
                allCrewData = csv.GetRecords<ModelInput>().ToList();
            }

            foreach (var crewData in allCrewData)
            {
                string name = crewData.Name;
                ModelInput data = crewData;
                allCrewDataWithName.Add(name, data);
            }
            return allCrewDataWithName;
        }



        static void Main(string[] args)
        {

            FeatureImportance.ShowFeatureImportanceAndWeights();

            foreach (var allCrewDataWithName in GetAllInputCrew())
            {
                var res = ConsumeModel.Predict(allCrewDataWithName.Value);

                Console.WriteLine($"{allCrewDataWithName.Value.Name,-30}\t{allCrewDataWithName.Value.MaxRarity:0.###}\t{res.Score:0.###}");
            }


            // Create single instance of sample data from first line of dataset for model input
            /* ModelInput sampleData = new ModelInput()
             {
                 SkillsCount = 1F,
                 SkillsCombinationRarity = 0.02158273F,
                 SkillsCombinationRarityPerCrewRarity = 0.03703704F,
                 MaxRarity = 1F,
                 VoyRank = 1021F,
                 GauntletRank = 1014F,
                 ScienceSkillCore = 0F,
                 ScienceSkillRangeMin = 0F,
                 ScienceSkillRangeMax = 0F,
                 SecuritySkillCore = 217F,
                 SecuritySkillRangeMin = 37F,
                 SecuritySkillRangeMax = 171F,
                 CommandSkillCore = 0F,
                 CommandSkillRangeMin = 0F,
                 CommandSkillRangeMax = 0F,
                 DiplomacySkillCore = 0F,
                 DiplomacySkillRangeMin = 0F,
                 DiplomacySkillRangeMax = 0F,
                 EngineeringSkillCore = 0F,
                 EngineeringSkillRangeMin = 0F,
                 EngineeringSkillRangeMax = 0F,
                 MedicineSkillCore = 0F,
                 MedicineSkillRangeMin = 0F,
                 MedicineSkillRangeMax = 0F,
                 B_CMD = 0F,
                 A_CMD = 0F,
                 B_SCI = 0F,
                 A_SCI = 0F,
                 B_SEC = 540F,
                 A_SEC = 537F,
                 V_CMD_SCI = 1022F,
                 G_CMD_SCI = 0F,
                 V_CMD_SEC = 977F,
                 G_CMD_SEC = 717F,
                 V_CMD_ENG = 1023F,
                 G_CMD_ENG = 0F,
                 V_CMD_DIP = 1023F,
                 G_CMD_DIP = 0F,
                 V_CMD_MED = 1024F,
                 G_CMD_MED = 0F,
                 V_SCI_SEC = 975F,
                 G_SCI_SEC = 715F,
                 V_SCI_ENG = 1022F,
                 G_SCI_ENG = 0F,
                 V_SCI_DIP = 1022F,
                 G_SCI_DIP = 0F,
                 V_SCI_MED = 1023F,
                 G_SCI_MED = 0F,
                 V_SEC_ENG = 965F,
                 G_SEC_ENG = 623F,
                 V_SEC_DIP = 977F,
                 G_SEC_DIP = 797F,
                 V_SEC_MED = 956F,
                 G_SEC_MED = 604F,
                 V_ENG_DIP = 1023F,
                 V_ENG_MED = 1024F,
                 V_DIP_MED = 1024F,
                 EventsCount = 16F,
                 IsInPortal = true,
                 DaysFromDateAdded = 1943F,
                 InCollectionsCount = 2F,
                 IsInSeries_ds9 = true,
                 IsInSeries_dsc = false,
                 IsInSeries_ent = false,
                 IsInSeries_original = false,
                 IsInSeries_pic = false,
                 IsInSeries_tas = false,
                 IsInSeries_tng = false,
                 IsInSeries_tos = false,
                 IsInSeries_voy = false,
                 ShipBattleAccuracyMax = 400F,
                 ShipBattleEvasionMax = 265F,
                 ShipBattleCritChanceMax = 67F,
                 ShipBattleCritBonusMax = 115F,
                 ActionBonusAmount = 1F,
                 ActionCooldown = 10F,
                 ActionInitialCooldown = 20F,
                 ActionDuration = 14F,
                 ActionLimit = 0F,
                 ActionBonusType = 2F,
                 ActionAbilityCondition = 0F,
                 ActionAbilityType = 0F,
                 ActionAbilityAmount = 0F,
                 ActionPenaltyType = 0F,
                 ActionPenaltyAmount = 0F,
                 TraitsCount = 4F,
             };

             // Make a single prediction on the sample data and print results
             var predictionResult = ConsumeModel.Predict(sampleData);

             Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");
             Console.WriteLine($"SkillsCount: {sampleData.SkillsCount}");
             Console.WriteLine($"SkillsCombinationRarity: {sampleData.SkillsCombinationRarity}");
             Console.WriteLine($"SkillsCombinationRarityPerCrewRarity: {sampleData.SkillsCombinationRarityPerCrewRarity}");
             Console.WriteLine($"MaxRarity: {sampleData.MaxRarity}");
             Console.WriteLine($"VoyRank: {sampleData.VoyRank}");
             Console.WriteLine($"GauntletRank: {sampleData.GauntletRank}");
             Console.WriteLine($"ScienceSkillCore: {sampleData.ScienceSkillCore}");
             Console.WriteLine($"ScienceSkillRangeMin: {sampleData.ScienceSkillRangeMin}");
             Console.WriteLine($"ScienceSkillRangeMax: {sampleData.ScienceSkillRangeMax}");
             Console.WriteLine($"SecuritySkillCore: {sampleData.SecuritySkillCore}");
             Console.WriteLine($"SecuritySkillRangeMin: {sampleData.SecuritySkillRangeMin}");
             Console.WriteLine($"SecuritySkillRangeMax: {sampleData.SecuritySkillRangeMax}");
             Console.WriteLine($"CommandSkillCore: {sampleData.CommandSkillCore}");
             Console.WriteLine($"CommandSkillRangeMin: {sampleData.CommandSkillRangeMin}");
             Console.WriteLine($"CommandSkillRangeMax: {sampleData.CommandSkillRangeMax}");
             Console.WriteLine($"DiplomacySkillCore: {sampleData.DiplomacySkillCore}");
             Console.WriteLine($"DiplomacySkillRangeMin: {sampleData.DiplomacySkillRangeMin}");
             Console.WriteLine($"DiplomacySkillRangeMax: {sampleData.DiplomacySkillRangeMax}");
             Console.WriteLine($"EngineeringSkillCore: {sampleData.EngineeringSkillCore}");
             Console.WriteLine($"EngineeringSkillRangeMin: {sampleData.EngineeringSkillRangeMin}");
             Console.WriteLine($"EngineeringSkillRangeMax: {sampleData.EngineeringSkillRangeMax}");
             Console.WriteLine($"MedicineSkillCore: {sampleData.MedicineSkillCore}");
             Console.WriteLine($"MedicineSkillRangeMin: {sampleData.MedicineSkillRangeMin}");
             Console.WriteLine($"MedicineSkillRangeMax: {sampleData.MedicineSkillRangeMax}");
             Console.WriteLine($"B_CMD: {sampleData.B_CMD}");
             Console.WriteLine($"A_CMD: {sampleData.A_CMD}");
             Console.WriteLine($"B_SCI: {sampleData.B_SCI}");
             Console.WriteLine($"A_SCI: {sampleData.A_SCI}");
             Console.WriteLine($"B_SEC: {sampleData.B_SEC}");
             Console.WriteLine($"A_SEC: {sampleData.A_SEC}");
             Console.WriteLine($"V_CMD_SCI: {sampleData.V_CMD_SCI}");
             Console.WriteLine($"G_CMD_SCI: {sampleData.G_CMD_SCI}");
             Console.WriteLine($"V_CMD_SEC: {sampleData.V_CMD_SEC}");
             Console.WriteLine($"G_CMD_SEC: {sampleData.G_CMD_SEC}");
             Console.WriteLine($"V_CMD_ENG: {sampleData.V_CMD_ENG}");
             Console.WriteLine($"G_CMD_ENG: {sampleData.G_CMD_ENG}");
             Console.WriteLine($"V_CMD_DIP: {sampleData.V_CMD_DIP}");
             Console.WriteLine($"G_CMD_DIP: {sampleData.G_CMD_DIP}");
             Console.WriteLine($"V_CMD_MED: {sampleData.V_CMD_MED}");
             Console.WriteLine($"G_CMD_MED: {sampleData.G_CMD_MED}");
             Console.WriteLine($"V_SCI_SEC: {sampleData.V_SCI_SEC}");
             Console.WriteLine($"G_SCI_SEC: {sampleData.G_SCI_SEC}");
             Console.WriteLine($"V_SCI_ENG: {sampleData.V_SCI_ENG}");
             Console.WriteLine($"G_SCI_ENG: {sampleData.G_SCI_ENG}");
             Console.WriteLine($"V_SCI_DIP: {sampleData.V_SCI_DIP}");
             Console.WriteLine($"G_SCI_DIP: {sampleData.G_SCI_DIP}");
             Console.WriteLine($"V_SCI_MED: {sampleData.V_SCI_MED}");
             Console.WriteLine($"G_SCI_MED: {sampleData.G_SCI_MED}");
             Console.WriteLine($"V_SEC_ENG: {sampleData.V_SEC_ENG}");
             Console.WriteLine($"G_SEC_ENG: {sampleData.G_SEC_ENG}");
             Console.WriteLine($"V_SEC_DIP: {sampleData.V_SEC_DIP}");
             Console.WriteLine($"G_SEC_DIP: {sampleData.G_SEC_DIP}");
             Console.WriteLine($"V_SEC_MED: {sampleData.V_SEC_MED}");
             Console.WriteLine($"G_SEC_MED: {sampleData.G_SEC_MED}");
             Console.WriteLine($"V_ENG_DIP: {sampleData.V_ENG_DIP}");
             Console.WriteLine($"V_ENG_MED: {sampleData.V_ENG_MED}");
             Console.WriteLine($"V_DIP_MED: {sampleData.V_DIP_MED}");
             Console.WriteLine($"EventsCount: {sampleData.EventsCount}");
             Console.WriteLine($"IsInPortal: {sampleData.IsInPortal}");
             Console.WriteLine($"DaysFromDateAdded: {sampleData.DaysFromDateAdded}");
             Console.WriteLine($"InCollectionsCount: {sampleData.InCollectionsCount}");
             Console.WriteLine($"IsInSeries_ds9: {sampleData.IsInSeries_ds9}");
             Console.WriteLine($"IsInSeries_dsc: {sampleData.IsInSeries_dsc}");
             Console.WriteLine($"IsInSeries_ent: {sampleData.IsInSeries_ent}");
             Console.WriteLine($"IsInSeries_original: {sampleData.IsInSeries_original}");
             Console.WriteLine($"IsInSeries_pic: {sampleData.IsInSeries_pic}");
             Console.WriteLine($"IsInSeries_tas: {sampleData.IsInSeries_tas}");
             Console.WriteLine($"IsInSeries_tng: {sampleData.IsInSeries_tng}");
             Console.WriteLine($"IsInSeries_tos: {sampleData.IsInSeries_tos}");
             Console.WriteLine($"IsInSeries_voy: {sampleData.IsInSeries_voy}");
             Console.WriteLine($"ShipBattleAccuracyMax: {sampleData.ShipBattleAccuracyMax}");
             Console.WriteLine($"ShipBattleEvasionMax: {sampleData.ShipBattleEvasionMax}");
             Console.WriteLine($"ShipBattleCritChanceMax: {sampleData.ShipBattleCritChanceMax}");
             Console.WriteLine($"ShipBattleCritBonusMax: {sampleData.ShipBattleCritBonusMax}");
             Console.WriteLine($"ActionBonusAmount: {sampleData.ActionBonusAmount}");
             Console.WriteLine($"ActionCooldown: {sampleData.ActionCooldown}");
             Console.WriteLine($"ActionInitialCooldown: {sampleData.ActionInitialCooldown}");
             Console.WriteLine($"ActionDuration: {sampleData.ActionDuration}");
             Console.WriteLine($"ActionLimit: {sampleData.ActionLimit}");
             Console.WriteLine($"ActionBonusType: {sampleData.ActionBonusType}");
             Console.WriteLine($"ActionAbilityCondition: {sampleData.ActionAbilityCondition}");
             Console.WriteLine($"ActionAbilityType: {sampleData.ActionAbilityType}");
             Console.WriteLine($"ActionAbilityAmount: {sampleData.ActionAbilityAmount}");
             Console.WriteLine($"ActionPenaltyType: {sampleData.ActionPenaltyType}");
             Console.WriteLine($"ActionPenaltyAmount: {sampleData.ActionPenaltyAmount}");
             Console.WriteLine($"TraitsCount: {sampleData.TraitsCount}");
             Console.WriteLine($"\n\nPredicted Label: {predictionResult.Score}\n\n");
             Console.WriteLine("=============== End of process, hit any key to finish ===============");
             Console.ReadKey();*/

        }


    }
}
