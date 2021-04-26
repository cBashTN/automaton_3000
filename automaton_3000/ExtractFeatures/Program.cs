using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using ExtractFeatures.Input;
using ExtractFeatures.Output;
using Newtonsoft.Json;

namespace ExtractFeatures
{
    class Program
    {
        public static readonly string FileDelimeter = ";";
        public static readonly string ListDelimeter = ",";


        static void Main(string[] args)
        {
            Console.WriteLine("Start Program... ");

            var crewFileContentText = File.ReadAllText("./Input/crew.json");

            var crew = JsonConvert.DeserializeObject<List<DatacoreCrew>>(crewFileContentText, Converter.Settings);

            Console.WriteLine($"Crew Count : {crew.Count}");

            List<CrewFeatures> crewsFeatures = new List<CrewFeatures>(crew.Count);
            List<SkillComboRarityPerCrewRarity> skillRarityPerCrewRarity = CreateSkillRarityPerCrewRarity(crew);

            foreach (var crewMember in crew)
            {
                var skillsComboInfo =
                    skillRarityPerCrewRarity.First(_ => _.SkillCombo == ExtractSkills(crewMember.BaseSkills));

                var crewFeatures = new CrewFeatures
                {
                    BigBookTier = crewMember.BigbookTier,
                    SkillsCount = ExtractSkillsCount(crewMember.BaseSkills),
                    SkillsCombinationRarity = skillsComboInfo.Rarity,
                    SkillsCombinationRarityPerCrewRarity = skillsComboInfo.RarityPerCrewRarity,
                    VoyRank = crewMember.Ranks.VoyRank,
                    MaxRarity = crewMember.MaxRarity,
                    GauntletRank = crewMember.Ranks.GauntletRank,
                    ScienceSkillCore = crewMember.BaseSkills.ScienceSkill?.Core ?? 0,
                    ScienceSkillRangeMin = crewMember.BaseSkills.ScienceSkill?.RangeMin ?? 0,
                    ScienceSkillRangeMax = crewMember.BaseSkills.ScienceSkill?.RangeMax ?? 0,
                    SecuritySkillCore = crewMember.BaseSkills.SecuritySkill?.Core ?? 0,
                    SecuritySkillRangeMin = crewMember.BaseSkills.SecuritySkill?.RangeMin ?? 0,
                    SecuritySkillRangeMax = crewMember.BaseSkills.SecuritySkill?.RangeMax ?? 0,
                    CommandSkillCore = crewMember.BaseSkills.CommandSkill?.Core ?? 0,
                    CommandSkillRangeMin = crewMember.BaseSkills.CommandSkill?.RangeMin ?? 0,
                    CommandSkillRangeMax = crewMember.BaseSkills.CommandSkill?.RangeMax ?? 0,
                    DiplomacySkillCore = crewMember.BaseSkills.DiplomacySkill?.Core ?? 0,
                    DiplomacySkillRangeMin = crewMember.BaseSkills.DiplomacySkill?.RangeMin ?? 0,
                    DiplomacySkillRangeMax = crewMember.BaseSkills.DiplomacySkill?.RangeMax ?? 0,
                    EngineeringSkillCore = crewMember.BaseSkills.EngineeringSkill?.Core ?? 0,
                    EngineeringSkillRangeMin = crewMember.BaseSkills.EngineeringSkill?.RangeMin ?? 0,
                    EngineeringSkillRangeMax = crewMember.BaseSkills.EngineeringSkill?.RangeMax ?? 0,
                    MedicineSkillCore = crewMember.BaseSkills.MedicineSkill?.Core ?? 0,
                    MedicineSkillRangeMin = crewMember.BaseSkills.MedicineSkill?.RangeMin ?? 0,
                    MedicineSkillRangeMax = crewMember.BaseSkills.MedicineSkill?.RangeMax ?? 0,
                    B_CMD = crewMember.Ranks.BCmd ?? 0,
                    A_CMD = crewMember.Ranks.ACmd ?? 0,
                    B_SCI = crewMember.Ranks.BSci ?? 0,
                    A_SCI = crewMember.Ranks.ASci ?? 0,
                    B_SEC = crewMember.Ranks.BSec ?? 0,
                    A_SEC = crewMember.Ranks.ASec ?? 0,
                    V_CMD_SCI = crewMember.Ranks.VCmdSci ?? 0,
                    G_CMD_SCI = crewMember.Ranks.GCmdSci ?? 0,
                    V_CMD_SEC = crewMember.Ranks.VCmdSec ?? 0,
                    G_CMD_SEC = crewMember.Ranks.GCmdSec ?? 0,
                    V_CMD_ENG = crewMember.Ranks.VCmdEng ?? 0,
                    G_CMD_ENG = crewMember.Ranks.GCmdEng ?? 0,
                    V_CMD_DIP = crewMember.Ranks.VCmdDip ?? 0,
                    G_CMD_DIP = crewMember.Ranks.GCmdDip ?? 0,
                    V_CMD_MED = crewMember.Ranks.VCmdMed ?? 0,
                    G_CMD_MED = crewMember.Ranks.GCmdMed ?? 0,
                    V_SCI_SEC = crewMember.Ranks.VSciSec ?? 0,
                    G_SCI_SEC = crewMember.Ranks.GSciSec ?? 0,
                    V_SCI_ENG = crewMember.Ranks.VSciEng ?? 0,
                    G_SCI_ENG = crewMember.Ranks.GSciEng ?? 0,
                    V_SCI_DIP = crewMember.Ranks.VSciDip ?? 0,
                    G_SCI_DIP = crewMember.Ranks.GSciDip ?? 0,
                    V_SCI_MED = crewMember.Ranks.VSciMed ?? 0,
                    G_SCI_MED = crewMember.Ranks.GSciMed ?? 0,
                    V_SEC_ENG = crewMember.Ranks.VSecEng ?? 0,
                    G_SEC_ENG = crewMember.Ranks.GSecEng ?? 0,
                    V_SEC_DIP = crewMember.Ranks.VSecDip ?? 0,
                    G_SEC_DIP = crewMember.Ranks.GSecDip ?? 0,
                    V_SEC_MED = crewMember.Ranks.VSecMed ?? 0,
                    G_SEC_MED = crewMember.Ranks.GSecMed ?? 0,
                    V_ENG_DIP = crewMember.Ranks.VEngDip ?? 0,
                    V_ENG_MED = crewMember.Ranks.VEngMed ?? 0,
                    V_DIP_MED = crewMember.Ranks.VDipMed ?? 0,
                    EventsCount = (float) crewMember.Events,
                    IsInPortal = (bool) crewMember.InPortal,
                    DaysFromDateAdded = (int) (DateTime.UtcNow - crewMember.DateAdded.Value).TotalDays,
                    InCollectionsCount = crewMember.Collections.Count,
                    IsInSeries_ds9 = crewMember.Series == Series.Ds9,
                    IsInSeries_dsc = crewMember.Series == Series.Dsc,
                    IsInSeries_ent = crewMember.Series == Series.Ent,
                    IsInSeries_original = crewMember.Series == Series.Original,
                    IsInSeries_pic = crewMember.Series == Series.Pic,
                    IsInSeries_tas = crewMember.Series == Series.Tas,
                    IsInSeries_tng = crewMember.Series == Series.Tng,
                    IsInSeries_tos = crewMember.Series == Series.Tos,
                    IsInSeries_voy = crewMember.Series == Series.Voy,
                    ShipBattleAccuracyMax = crewMember.ShipBattle.Accuracy ?? 0,
                    ShipBattleEvasionMax = crewMember.ShipBattle.Evasion ?? 0,
                    ShipBattleCritChanceMax = crewMember.ShipBattle.CritChance ?? 0,
                    ShipBattleCritBonusMax = crewMember.ShipBattle.CritBonus ?? 0,
                    ActionBonusAmount = crewMember.Action.BonusAmount ?? 0,
                    ActionCooldown = crewMember.Action.Cooldown ?? 0,
                    ActionInitialCooldown = crewMember.Action.InitialCooldown ?? 0,
                    ActionDuration = crewMember.Action.Duration ?? 0,
                    ActionLimit = crewMember.Action.Limit ?? 0,
                    ActionBonusType = crewMember.Action.BonusType ?? 0,
                    ActionAbilityCondition = crewMember.Action.Ability?.Condition ?? 0,
                    ActionAbilityType = crewMember.Action.Ability?.Type ?? 0,
                    ActionAbilityAmount = crewMember.Action.Ability?.Amount ?? 0,
                    ActionPenaltyType = crewMember.Action.Penalty?.Type ?? 0,
                    ActionPenaltyAmount = crewMember.Action.Penalty?.Amount ?? 0,
                    TraitsCount = crewMember.Traits.Count,
                    Traits = string.Join(ListDelimeter, crewMember.Traits.ToArray()),
                    TraitsHidden = string.Join(ListDelimeter, crewMember.TraitsHidden.ToArray())
                };

                crewsFeatures.Add(crewFeatures);
            }

            Console.WriteLine($"Crew Count : {crewsFeatures.Count}");

            if (!Directory.Exists("./Output/"))
            {
                Directory.CreateDirectory("./Output/");
            }

            CsvConfiguration csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture) {Delimiter = FileDelimeter};
            using (var writer = new StreamWriter("./Output/crew.csv"))
            using (var csv = new CsvWriter(writer, csvConfig))
            {
                csv.WriteRecords(crewsFeatures);
            }

            Console.WriteLine($"CSV exported.");


            ////remove captain tribble
            //crewsFeatures.Remove(crewsFeatures.Single(_ => _.BigBookTier < 1.0));

            //crewsFeatures.ForEach(_ => _.SkillsCount /= crewsFeatures.Max(f => f.SkillsCount));
            ////todo all or do this with ML.NET later


            //using (var writer = new StreamWriter("./Output/crewNormalized.csv"))
            //using (var csv = new CsvWriter(writer, csvConfig))
            //{
            //    csv.WriteRecords(crewsFeatures);
            //}

            //Console.WriteLine($"CSV exported.");

        }

        private static List<SkillComboRarityPerCrewRarity> CreateSkillRarityPerCrewRarity(List<DatacoreCrew> crew)
        {
            var skillComboRaritiesPerCrewRarity = new List<SkillComboRarityPerCrewRarity>(crew.Count);
            foreach (var crewMember in crew)
            {
                var skills = ExtractSkills(crewMember.BaseSkills);

                var s = skillComboRaritiesPerCrewRarity.SingleOrDefault(_ =>
                    _.SkillCombo == skills && _.CrewRarity == crewMember.MaxRarity);

                if (s == null)
                {
                    skillComboRaritiesPerCrewRarity.Add(new SkillComboRarityPerCrewRarity
                    {
                        SkillCombo = skills,
                        Count = 1,
                        CrewRarity = crewMember.MaxRarity,
                        Rarity = 0f,
                        RarityPerCrewRarity = 0f
                    });
                }
                else
                {
                    s.Count++;
                }
            }

            // The SkillComboRarity is the ration of:  All with certain SkillCombo / All
            foreach (var comboRarityPerCrewRarity in skillComboRaritiesPerCrewRarity)
            {
                var countOfCrewWithThisSkillCombo =
                    skillComboRaritiesPerCrewRarity.Count(_ => _.SkillCombo == comboRarityPerCrewRarity.SkillCombo);
                comboRarityPerCrewRarity.Rarity =
                    countOfCrewWithThisSkillCombo / (float) skillComboRaritiesPerCrewRarity.Count;
            }


            // The SkillComboRarityPerCrewRarity is the ration of:  All with a certain SkillCombo of a certain CrewRarity / All with this CrewRarity
            foreach (var comboRarityPerCrewRarity in skillComboRaritiesPerCrewRarity)
            {
                var countOfCrewWithThisCrewRarity = skillComboRaritiesPerCrewRarity
                    .Where(_ => _.CrewRarity == comboRarityPerCrewRarity.CrewRarity)
                    .Sum(_ => _.Count); // This could be in a lookup table
                comboRarityPerCrewRarity.RarityPerCrewRarity =
                    comboRarityPerCrewRarity.Count / (float) countOfCrewWithThisCrewRarity;
            }


            //for (int i = 1; i <= 5; i++)
            //{
            //    var skillComboRarityPerCrewRarity = skillComboRaritiesPerCrewRarity.Where(_ => _.CrewRarity == i).ToList();
            //    var totalCountOfCrewMembersWithThisRarity = skillComboRarityPerCrewRarity.Sum(z => z.Count);
            //    foreach (var comboRarityPerCrewRarity in skillComboRarityPerCrewRarity)
            //    {
            //        comboRarityPerCrewRarity.RarityPerCrewRarity = comboRarityPerCrewRarity.Count / (float)totalCountOfCrewMembersWithThisRarity;
            //    }
            //}

            return skillComboRaritiesPerCrewRarity;
        }

        private static Dictionary<SkillCombo, float> CreateSkillRarityLookUp(List<DatacoreCrew> crew)
        {
            Dictionary<SkillCombo, float> skillRarityLookUp = new Dictionary<SkillCombo, float>();
            Dictionary<SkillCombo, int> skillComboUsageLookup = new Dictionary<SkillCombo, int>();

            foreach (var crewMember in crew)
            {
                var skills = ExtractSkills(crewMember.BaseSkills);
                if (skillComboUsageLookup.ContainsKey(skills))
                {
                    skillComboUsageLookup[skills]++;
                }
                else
                {
                    skillComboUsageLookup.Add(skills, 1);
                }
            }

            foreach (KeyValuePair<SkillCombo, int> skillComboCountPair in skillComboUsageLookup)
            {
                float rarity = (skillComboCountPair.Value / (float) crew.Count);
                skillRarityLookUp.Add(skillComboCountPair.Key, rarity);
            }

            return skillRarityLookUp;
        }

        private static SkillCombo ExtractSkillsCombinationRarity(BaseSkills crewMembersBaseSkills)
        {
            SkillCombo comboSkillCombo = ExtractSkills(crewMembersBaseSkills);
            return comboSkillCombo;
        }

        private static SkillCombo ExtractSkills(BaseSkills crewMembersBaseSkills)
        {
            SkillCombo comboSkillCombo = 0;
            if (crewMembersBaseSkills.CommandSkill != null)
            {
                comboSkillCombo = comboSkillCombo | SkillCombo.Command;
            } // Could've used the "Compount Assignment" to look cool but this makes it more clear

            if (crewMembersBaseSkills.DiplomacySkill != null)
            {
                comboSkillCombo = comboSkillCombo | SkillCombo.Diplomacy;
            }

            if (crewMembersBaseSkills.EngineeringSkill != null)
            {
                comboSkillCombo = comboSkillCombo | SkillCombo.Engineering;
            }

            if (crewMembersBaseSkills.MedicineSkill != null)
            {
                comboSkillCombo = comboSkillCombo | SkillCombo.Medicine;
            }

            if (crewMembersBaseSkills.ScienceSkill != null)
            {
                comboSkillCombo = comboSkillCombo | SkillCombo.Science;
            }

            if (crewMembersBaseSkills.SecuritySkill != null)
            {
                comboSkillCombo = comboSkillCombo | SkillCombo.Security;
            }

            return comboSkillCombo;
        }

        private static int ExtractSkillsCount(BaseSkills crewMembersBaseSkills)
        {
            var allSkills = ExtractSkills(crewMembersBaseSkills);
            var skillCount =
                System.Runtime.Intrinsics.X86.Popcnt.PopCount((byte) allSkills); // HAHA! This new in .NET Core 3
            return (int) skillCount;
        }

        private static int ExtractSkillsCount(SkillCombo allSkills)
        {
            var skillCount = System.Runtime.Intrinsics.X86.Popcnt.PopCount((byte) allSkills);
            return (int) skillCount;
        }
    }

    /// <summary>
    /// Bit 0 : CMD
    /// Bit 1 : DIP
    /// Bit 2 : ENG
    /// Bit 3 : MED
    /// Bit 4 : SCI
    /// Bit 5 : SEC
    /// </summary>
    [Flags]
    public enum SkillCombo
    {
        Command = 1,
        Diplomacy = 2,
        Engineering = 4,
        Medicine = 8,
        Science = 16,
        Security = 32
    }


    public class SkillComboRarityPerCrewRarity
    {
        public SkillCombo SkillCombo { get; set; }

        public int Count { get; set; }

        /// <summary>
        /// Count of max stars
        /// </summary>
        public int CrewRarity { get; set; }

        public float Rarity { get; set; }

        public float RarityPerCrewRarity { get; set; }
    }
}