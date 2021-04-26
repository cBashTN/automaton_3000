using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ExtractFeatures.Input
{
    using J = Newtonsoft.Json.JsonPropertyAttribute;
    using N = Newtonsoft.Json.NullValueHandling;

    /// <summary>
    /// Generated with https://app.quicktype.io/
    /// </summary>
    public partial class DatacoreCrew
    {
        [J("symbol", NullValueHandling = N.Ignore)] public string Symbol { get; set; }
        [J("name", NullValueHandling = N.Ignore)] public string Name { get; set; }
        [J("short_name", NullValueHandling = N.Ignore)] public string ShortName { get; set; }
        [J("flavor", NullValueHandling = N.Ignore)] public string Flavor { get; set; }
        [J("archetype_id", NullValueHandling = N.Ignore)] public long? ArchetypeId { get; set; }
        [J("max_rarity", NullValueHandling = N.Ignore)] public int MaxRarity { get; set; }
        [J("equipment_slots", NullValueHandling = N.Ignore)] public List<EquipmentSlot> EquipmentSlots { get; set; }
        [J("voice_over")] public string VoiceOver { get; set; }
        [J("traits", NullValueHandling = N.Ignore)] public List<Trait> Traits { get; set; }
        [J("traits_hidden", NullValueHandling = N.Ignore)] public List<string> TraitsHidden { get; set; }
        [J("base_skills", NullValueHandling = N.Ignore)] public BaseSkills BaseSkills { get; set; }
        [J("ship_battle", NullValueHandling = N.Ignore)] public ShipBattle ShipBattle { get; set; }
        [J("action", NullValueHandling = N.Ignore)] public Action Action { get; set; }
        [J("cross_fuse_targets", NullValueHandling = N.Ignore)] public CrossFuseTargetsUnion? CrossFuseTargets { get; set; }
        [J("skill_data", NullValueHandling = N.Ignore)] public List<SkillDatum> SkillData { get; set; }
        [J("intermediate_skill_data", NullValueHandling = N.Ignore)] public List<IntermediateSkillDatum> IntermediateSkillData { get; set; }
        [J("is_craftable", NullValueHandling = N.Ignore)] public bool? IsCraftable { get; set; }
        [J("imageUrlPortrait", NullValueHandling = N.Ignore)] public string ImageUrlPortrait { get; set; }
        [J("imageUrlFullBody", NullValueHandling = N.Ignore)] public string ImageUrlFullBody { get; set; }
        [J("series", NullValueHandling = N.Ignore)] public Series? Series { get; set; }
        [J("traits_named", NullValueHandling = N.Ignore)] public List<string> TraitsNamed { get; set; }
        [J("collections", NullValueHandling = N.Ignore)] public List<Collection> Collections { get; set; }
        [J("nicknames", NullValueHandling = N.Ignore)] public List<Nickname> Nicknames { get; set; }
        [J("totalChronCost", NullValueHandling = N.Ignore)] public long? TotalChronCost { get; set; }
        [J("factionOnlyTotal", NullValueHandling = N.Ignore)] public long? FactionOnlyTotal { get; set; }
        [J("craftCost", NullValueHandling = N.Ignore)] public long? CraftCost { get; set; }
        [J("ranks", NullValueHandling = N.Ignore)] public Ranks Ranks { get; set; }
        [J("bigbook_tier", NullValueHandling = N.Ignore)] public int BigbookTier { get; set; }
        [J("events", NullValueHandling = N.Ignore)] public long? Events { get; set; }
        [J("in_portal", NullValueHandling = N.Ignore)] public bool? InPortal { get; set; }
        [J("date_added", NullValueHandling = N.Ignore)] public DateTimeOffset? DateAdded { get; set; }
        [J("obtained", NullValueHandling = N.Ignore)] public Obtained? Obtained { get; set; }
        [J("markdownContent", NullValueHandling = N.Ignore)] public string MarkdownContent { get; set; }
        [J("unique_polestar_combos", NullValueHandling = N.Ignore)] public List<List<Trait>> UniquePolestarCombos { get; set; }
        [J("constellation", NullValueHandling = N.Ignore)] public Constellation Constellation { get; set; }
    }

    public partial class Action
    {
        [J("bonus_amount", NullValueHandling = N.Ignore)] public long? BonusAmount { get; set; }
        [J("name", NullValueHandling = N.Ignore)] public string Name { get; set; }
        [J("symbol", NullValueHandling = N.Ignore)] public string Symbol { get; set; }
        [J("cooldown", NullValueHandling = N.Ignore)] public long? Cooldown { get; set; }
        [J("initial_cooldown", NullValueHandling = N.Ignore)] public long? InitialCooldown { get; set; }
        [J("duration", NullValueHandling = N.Ignore)] public long? Duration { get; set; }
        [J("bonus_type", NullValueHandling = N.Ignore)] public long? BonusType { get; set; }
        [J("crew", NullValueHandling = N.Ignore)] public long? Crew { get; set; }
        [J("icon", NullValueHandling = N.Ignore)] public Icon Icon { get; set; }
        [J("special", NullValueHandling = N.Ignore)] public bool? Special { get; set; }
        [J("penalty", NullValueHandling = N.Ignore)] public Penalty Penalty { get; set; }
        [J("limit", NullValueHandling = N.Ignore)] public long? Limit { get; set; }
        [J("ability", NullValueHandling = N.Ignore)] public Ability Ability { get; set; }
        [J("charge_phases", NullValueHandling = N.Ignore)] public List<ChargePhase> ChargePhases { get; set; }
        [J("crew_archetype_id", NullValueHandling = N.Ignore)] public long? CrewArchetypeId { get; set; }
    }

    public partial class Ability
    {
        [J("condition", NullValueHandling = N.Ignore)] public long? Condition { get; set; }
        [J("type", NullValueHandling = N.Ignore)] public long? Type { get; set; }
        [J("amount", NullValueHandling = N.Ignore)] public long? Amount { get; set; }
    }

    public partial class ChargePhase
    {
        [J("charge_time", NullValueHandling = N.Ignore)] public long? ChargeTime { get; set; }
        [J("ability_amount", NullValueHandling = N.Ignore)] public long? AbilityAmount { get; set; }
        [J("bonus_amount", NullValueHandling = N.Ignore)] public long? BonusAmount { get; set; }
        [J("cooldown", NullValueHandling = N.Ignore)] public long? Cooldown { get; set; }
        [J("duration", NullValueHandling = N.Ignore)] public long? Duration { get; set; }
    }

    public partial class Icon
    {
        [J("file", NullValueHandling = N.Ignore)] public string File { get; set; }
    }

    public partial class Penalty
    {
        [J("type", NullValueHandling = N.Ignore)] public long? Type { get; set; }
        [J("amount", NullValueHandling = N.Ignore)] public long? Amount { get; set; }
    }

    public partial class BaseSkills
    {
        [J("security_skill", NullValueHandling = N.Ignore)] public Skill SecuritySkill { get; set; }
        [J("command_skill", NullValueHandling = N.Ignore)] public Skill CommandSkill { get; set; }
        [J("diplomacy_skill", NullValueHandling = N.Ignore)] public Skill DiplomacySkill { get; set; }
        [J("medicine_skill", NullValueHandling = N.Ignore)] public Skill MedicineSkill { get; set; }
        [J("science_skill", NullValueHandling = N.Ignore)] public Skill ScienceSkill { get; set; }
        [J("engineering_skill", NullValueHandling = N.Ignore)] public Skill EngineeringSkill { get; set; }
    }

    public partial class Skill
    {
        [J("core", NullValueHandling = N.Ignore)] public long? Core { get; set; }
        [J("range_min", NullValueHandling = N.Ignore)] public long? RangeMin { get; set; }
        [J("range_max", NullValueHandling = N.Ignore)] public long? RangeMax { get; set; }
    }

    public partial class Constellation
    {
        [J("id", NullValueHandling = N.Ignore)] public long? Id { get; set; }
        [J("symbol", NullValueHandling = N.Ignore)] public string Symbol { get; set; }
        [J("name", NullValueHandling = N.Ignore)] public string Name { get; set; }
        [J("short_name", NullValueHandling = N.Ignore)] public string ShortName { get; set; }
        [J("flavor", NullValueHandling = N.Ignore)] public string Flavor { get; set; }
        [J("icon", NullValueHandling = N.Ignore)] public Icon Icon { get; set; }
        [J("keystones", NullValueHandling = N.Ignore)] public List<long> Keystones { get; set; }
        [J("type", NullValueHandling = N.Ignore)] public TypeEnum? Type { get; set; }
        [J("crew_archetype_id", NullValueHandling = N.Ignore)] public long? CrewArchetypeId { get; set; }
    }

    public partial class CrossFuseTargetsClass
    {
        [J("symbol", NullValueHandling = N.Ignore)] public string Symbol { get; set; }
        [J("name", NullValueHandling = N.Ignore)] public string Name { get; set; }
    }

    public partial class EquipmentSlot
    {
        [J("level", NullValueHandling = N.Ignore)] public long? Level { get; set; }
        [J("symbol", NullValueHandling = N.Ignore)] public string Symbol { get; set; }
    }

    public partial class IntermediateSkillDatum
    {
        [J("rarity", NullValueHandling = N.Ignore)] public long? Rarity { get; set; }
        [J("level", NullValueHandling = N.Ignore)] public long? Level { get; set; }
        [J("base_skills", NullValueHandling = N.Ignore)] public BaseSkills BaseSkills { get; set; }
        [J("action", NullValueHandling = N.Ignore)] public Action Action { get; set; }
        [J("ship_battle", NullValueHandling = N.Ignore)] public ShipBattle ShipBattle { get; set; }
    }

    public partial class ShipBattle
    {
        [J("accuracy", NullValueHandling = N.Ignore)] public long? Accuracy { get; set; }
        [J("evasion", NullValueHandling = N.Ignore)] public long? Evasion { get; set; }
        [J("crit_chance", NullValueHandling = N.Ignore)] public long? CritChance { get; set; }
        [J("crit_bonus", NullValueHandling = N.Ignore)] public long? CritBonus { get; set; }
    }

    public partial class Nickname
    {
        [J("actualName", NullValueHandling = N.Ignore)] public string ActualName { get; set; }
        [J("cleverThing", NullValueHandling = N.Ignore)] public string CleverThing { get; set; }
        [J("creator", NullValueHandling = N.Ignore)] public string Creator { get; set; }
    }

    public partial class Ranks
    {
        [J("voyRank", NullValueHandling = N.Ignore)] public long? VoyRank { get; set; }
        [J("gauntletRank", NullValueHandling = N.Ignore)] public long? GauntletRank { get; set; }
        [J("chronCostRank", NullValueHandling = N.Ignore)] public long? ChronCostRank { get; set; }
        [J("B_SEC", NullValueHandling = N.Ignore)] public long? BSec { get; set; }
        [J("A_SEC", NullValueHandling = N.Ignore)] public long? ASec { get; set; }
        [J("V_CMD_SCI", NullValueHandling = N.Ignore)] public long? VCmdSci { get; set; }
        [J("V_CMD_SEC", NullValueHandling = N.Ignore)] public long? VCmdSec { get; set; }
        [J("G_CMD_SEC", NullValueHandling = N.Ignore)] public long? GCmdSec { get; set; }
        [J("V_CMD_ENG", NullValueHandling = N.Ignore)] public long? VCmdEng { get; set; }
        [J("V_CMD_DIP", NullValueHandling = N.Ignore)] public long? VCmdDip { get; set; }
        [J("V_CMD_MED", NullValueHandling = N.Ignore)] public long? VCmdMed { get; set; }
        [J("V_SCI_SEC", NullValueHandling = N.Ignore)] public long? VSciSec { get; set; }
        [J("G_SCI_SEC", NullValueHandling = N.Ignore)] public long? GSciSec { get; set; }
        [J("V_SCI_ENG", NullValueHandling = N.Ignore)] public long? VSciEng { get; set; }
        [J("V_SCI_DIP", NullValueHandling = N.Ignore)] public long? VSciDip { get; set; }
        [J("V_SCI_MED", NullValueHandling = N.Ignore)] public long? VSciMed { get; set; }
        [J("V_SEC_ENG", NullValueHandling = N.Ignore)] public long? VSecEng { get; set; }
        [J("G_SEC_ENG", NullValueHandling = N.Ignore)] public long? GSecEng { get; set; }
        [J("V_SEC_DIP", NullValueHandling = N.Ignore)] public long? VSecDip { get; set; }
        [J("G_SEC_DIP", NullValueHandling = N.Ignore)] public long? GSecDip { get; set; }
        [J("V_SEC_MED", NullValueHandling = N.Ignore)] public long? VSecMed { get; set; }
        [J("G_SEC_MED", NullValueHandling = N.Ignore)] public long? GSecMed { get; set; }
        [J("V_ENG_DIP", NullValueHandling = N.Ignore)] public long? VEngDip { get; set; }
        [J("V_ENG_MED", NullValueHandling = N.Ignore)] public long? VEngMed { get; set; }
        [J("V_DIP_MED", NullValueHandling = N.Ignore)] public long? VDipMed { get; set; }
        [J("B_CMD", NullValueHandling = N.Ignore)] public long? BCmd { get; set; }
        [J("A_CMD", NullValueHandling = N.Ignore)] public long? ACmd { get; set; }
        [J("G_CMD_SCI", NullValueHandling = N.Ignore)] public long? GCmdSci { get; set; }
        [J("G_CMD_ENG", NullValueHandling = N.Ignore)] public long? GCmdEng { get; set; }
        [J("G_CMD_DIP", NullValueHandling = N.Ignore)] public long? GCmdDip { get; set; }
        [J("G_CMD_MED", NullValueHandling = N.Ignore)] public long? GCmdMed { get; set; }
        [J("B_DIP", NullValueHandling = N.Ignore)] public long? BDip { get; set; }
        [J("A_DIP", NullValueHandling = N.Ignore)] public long? ADip { get; set; }
        [J("G_SCI_DIP", NullValueHandling = N.Ignore)] public long? GSciDip { get; set; }
        [J("G_ENG_DIP", NullValueHandling = N.Ignore)] public long? GEngDip { get; set; }
        [J("G_DIP_MED", NullValueHandling = N.Ignore)] public long? GDipMed { get; set; }
        [J("B_MED", NullValueHandling = N.Ignore)] public long? BMed { get; set; }
        [J("A_MED", NullValueHandling = N.Ignore)] public long? AMed { get; set; }
        [J("G_SCI_MED", NullValueHandling = N.Ignore)] public long? GSciMed { get; set; }
        [J("G_ENG_MED", NullValueHandling = N.Ignore)] public long? GEngMed { get; set; }
        [J("B_SCI", NullValueHandling = N.Ignore)] public long? BSci { get; set; }
        [J("A_SCI", NullValueHandling = N.Ignore)] public long? ASci { get; set; }
        [J("G_SCI_ENG", NullValueHandling = N.Ignore)] public long? GSciEng { get; set; }
        [J("B_ENG", NullValueHandling = N.Ignore)] public long? BEng { get; set; }
        [J("A_ENG", NullValueHandling = N.Ignore)] public long? AEng { get; set; }
    }

    public partial class SkillDatum
    {
        [J("rarity", NullValueHandling = N.Ignore)] public long? Rarity { get; set; }
        [J("base_skills", NullValueHandling = N.Ignore)] public BaseSkills BaseSkills { get; set; }
    }

    public enum Collection { ALittleStroll, ANewChallengerApproaches, BrideOfChaotica, ChainOfCommand, CommonCrew, CostumeParty, DelphicExpanse, DoNoHarm, HehChoMruakTah, HolodeckEnthusiasts, LifeAmongTheStars, LiveLongAndProsper, NewLifeAndNewCivilizations, OurManBashir, PlayBall, RareCrew, ResistanceIsFutile, RulesOfAcquisition, SetSail, SherwoodForest, SmokeAndMirrors, SpitAndBailingWire, TheBigGoodbye, TheContinuum, TheDaystromAward, TheEugenicsWars, TheNeutralZone, TheWildWest, TimelinesOriginals, ToBoldlyGo, UncommonCrew, ValorInCombat };

    public enum TypeEnum { CrewKeystoneCrate };

    public enum Obtained { Campaign, Event, Fuse, Fusion, Gauntlet, Giveaway, HonorHall, Launch, Mega, Missions, Pack, PostLaunch, Voyage };

    public enum Series { Ds9, Dsc, Ent, Original, Pic, Tas, Tng, Tos, Voy };

    public enum Trait { Aenar, Allasomorph, Ambassador, Andorian, Android, Angosian, Archon, Argelian, Artist, Astrophysicist, Athlete, Augment, Aurelian, AutomatedUnit, Bajoran, Baku, Bartender, Barzan, Baul, Benzite, BetaAnnari, Betazoid, Betelgeusian, Borg, Botanist, Breen, Brunali, Brutal, Bynar, Caitian, Cardassian, Caregiver, Casual, Chameloid, Changeling, Chef, Civilian, Clone, CommandSkill, Communicator, Constable, Control, Costumed, Counselor, Courier, Crafty, CrewMaxRarity1, CrewMaxRarity2, CrewMaxRarity3, CrewMaxRarity4, CrewMaxRarity5, Criminal, CulturalFigure, Cyberneticist, DaharMaster, Deltan, Denobulan, Desperate, DiplomacySkill, Diplomat, Doctor, Dominion, Dosi, Douwd, Duelist, Edosian, Efrosian, Elaurian, Elaysian, Empath, Engineered, EngineeringSkill, Excalbian, Exoarchaeology, Exobiology, Exomycologist, Explorer, Federation, Ferengi, Gambler, Gardener, Geneticist, Geologist, Gorn, Hero, HighCommand, Hirogen, Hologram, Human, Hunter, Ikaaran, ImperialGuard, Innovator, Inspiring, Interrogator, Investigator, Jahsepp, Jemhadar, Jnaii, JuryRigger, Kaelon, Kai, Kalandan, Kataan, Kazon, Kca, Kelpien, Klingon, Kraylor, Krenim, Kriosian, Ktarian, Kwejian, Linguist, Loqueeque, Lurian, M113Creature, Maco, Malon, Maquis, Marksman, Maverick, MedicineSkill, Merchant, Mintakan, MirrorUniverse, Mugato, Musician, Mylean, Nacene, Nakuhl, Nasat, Neural, Neurologist, Nurse, ObsidianOrder, Ocampa, Orion, Pakled, Pandronian, Pilot, Politician, Presage, Primal, Prisoner, Probe, Prodigy, Prophet, Q, QowatMilat, QuantumMechanics, Ramatis3_Native, Reman, Resourceful, Risian, Romantic, Romulan, Royalty, Saboteur, Sarpeidon, Saurian, ScienceSkill, Scoundrel, Section31, SecuritySkill, Shapeshifter, SiliconLifeform, Smuggler, Sona, Species8472, Spiritual, Starfleet, Suliban, Survivalist, Syrrannite, Tactician, TalShiar, Talaxian, Talosian, Tamarian, Taresian, Telekinetic, Telepath, TemporalAgent, TerranEmpire, TerranRebellion, Terrellian, TheoreticalEngineer, Thief, Tholian, Tkon, Tosk, Tribble, Trill, UndercoverOperative, Vedek, Veteran, Vidiian, Villain, Vorta, Voth, Vulcan, WarpTheorist, Writer, Xahean, Xenoanthropology, Xindi, Zahl, ZhatVash, Zibelian };

    public partial struct CrossFuseTargetsUnion
    {
        public List<object> AnythingArray;
        public CrossFuseTargetsClass CrossFuseTargetsClass;

        public static implicit operator CrossFuseTargetsUnion(List<object> AnythingArray) => new CrossFuseTargetsUnion { AnythingArray = AnythingArray };
        public static implicit operator CrossFuseTargetsUnion(CrossFuseTargetsClass CrossFuseTargetsClass) => new CrossFuseTargetsUnion { CrossFuseTargetsClass = CrossFuseTargetsClass };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CollectionConverter.Singleton,
                TypeEnumConverter.Singleton,
                CrossFuseTargetsUnionConverter.Singleton,
                ObtainedConverter.Singleton,
                SeriesConverter.Singleton,
                TraitConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class CollectionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Collection) || t == typeof(Collection?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "A Little Stroll":
                    return Collection.ALittleStroll;
                case "A New Challenger Approaches":
                    return Collection.ANewChallengerApproaches;
                case "Bride Of Chaotica":
                    return Collection.BrideOfChaotica;
                case "Chain of Command":
                    return Collection.ChainOfCommand;
                case "Common Crew":
                    return Collection.CommonCrew;
                case "Costume Party":
                    return Collection.CostumeParty;
                case "Delphic Expanse":
                    return Collection.DelphicExpanse;
                case "Do No Harm":
                    return Collection.DoNoHarm;
                case "Heh Cho'mruak tah":
                    return Collection.HehChoMruakTah;
                case "Holodeck Enthusiasts":
                    return Collection.HolodeckEnthusiasts;
                case "Life Among the Stars":
                    return Collection.LifeAmongTheStars;
                case "Live Long and Prosper":
                    return Collection.LiveLongAndProsper;
                case "New Life and New Civilizations":
                    return Collection.NewLifeAndNewCivilizations;
                case "Our Man Bashir":
                    return Collection.OurManBashir;
                case "Play Ball!":
                    return Collection.PlayBall;
                case "Rare Crew":
                    return Collection.RareCrew;
                case "Resistance Is Futile":
                    return Collection.ResistanceIsFutile;
                case "Rules Of Acquisition":
                    return Collection.RulesOfAcquisition;
                case "Set Sail!":
                    return Collection.SetSail;
                case "Sherwood Forest":
                    return Collection.SherwoodForest;
                case "Smoke and Mirrors":
                    return Collection.SmokeAndMirrors;
                case "Spit and Bailing Wire":
                    return Collection.SpitAndBailingWire;
                case "The Big Goodbye":
                    return Collection.TheBigGoodbye;
                case "The Continuum":
                    return Collection.TheContinuum;
                case "The Daystrom Award":
                    return Collection.TheDaystromAward;
                case "The Eugenics Wars":
                    return Collection.TheEugenicsWars;
                case "The Neutral Zone":
                    return Collection.TheNeutralZone;
                case "The Wild West":
                    return Collection.TheWildWest;
                case "Timelines' Originals":
                    return Collection.TimelinesOriginals;
                case "To Boldly Go":
                    return Collection.ToBoldlyGo;
                case "Uncommon Crew":
                    return Collection.UncommonCrew;
                case "Valor in Combat":
                    return Collection.ValorInCombat;
            }
            throw new Exception("Cannot unmarshal type Collection");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Collection)untypedValue;
            switch (value)
            {
                case Collection.ALittleStroll:
                    serializer.Serialize(writer, "A Little Stroll");
                    return;
                case Collection.ANewChallengerApproaches:
                    serializer.Serialize(writer, "A New Challenger Approaches");
                    return;
                case Collection.BrideOfChaotica:
                    serializer.Serialize(writer, "Bride Of Chaotica");
                    return;
                case Collection.ChainOfCommand:
                    serializer.Serialize(writer, "Chain of Command");
                    return;
                case Collection.CommonCrew:
                    serializer.Serialize(writer, "Common Crew");
                    return;
                case Collection.CostumeParty:
                    serializer.Serialize(writer, "Costume Party");
                    return;
                case Collection.DelphicExpanse:
                    serializer.Serialize(writer, "Delphic Expanse");
                    return;
                case Collection.DoNoHarm:
                    serializer.Serialize(writer, "Do No Harm");
                    return;
                case Collection.HehChoMruakTah:
                    serializer.Serialize(writer, "Heh Cho'mruak tah");
                    return;
                case Collection.HolodeckEnthusiasts:
                    serializer.Serialize(writer, "Holodeck Enthusiasts");
                    return;
                case Collection.LifeAmongTheStars:
                    serializer.Serialize(writer, "Life Among the Stars");
                    return;
                case Collection.LiveLongAndProsper:
                    serializer.Serialize(writer, "Live Long and Prosper");
                    return;
                case Collection.NewLifeAndNewCivilizations:
                    serializer.Serialize(writer, "New Life and New Civilizations");
                    return;
                case Collection.OurManBashir:
                    serializer.Serialize(writer, "Our Man Bashir");
                    return;
                case Collection.PlayBall:
                    serializer.Serialize(writer, "Play Ball!");
                    return;
                case Collection.RareCrew:
                    serializer.Serialize(writer, "Rare Crew");
                    return;
                case Collection.ResistanceIsFutile:
                    serializer.Serialize(writer, "Resistance Is Futile");
                    return;
                case Collection.RulesOfAcquisition:
                    serializer.Serialize(writer, "Rules Of Acquisition");
                    return;
                case Collection.SetSail:
                    serializer.Serialize(writer, "Set Sail!");
                    return;
                case Collection.SherwoodForest:
                    serializer.Serialize(writer, "Sherwood Forest");
                    return;
                case Collection.SmokeAndMirrors:
                    serializer.Serialize(writer, "Smoke and Mirrors");
                    return;
                case Collection.SpitAndBailingWire:
                    serializer.Serialize(writer, "Spit and Bailing Wire");
                    return;
                case Collection.TheBigGoodbye:
                    serializer.Serialize(writer, "The Big Goodbye");
                    return;
                case Collection.TheContinuum:
                    serializer.Serialize(writer, "The Continuum");
                    return;
                case Collection.TheDaystromAward:
                    serializer.Serialize(writer, "The Daystrom Award");
                    return;
                case Collection.TheEugenicsWars:
                    serializer.Serialize(writer, "The Eugenics Wars");
                    return;
                case Collection.TheNeutralZone:
                    serializer.Serialize(writer, "The Neutral Zone");
                    return;
                case Collection.TheWildWest:
                    serializer.Serialize(writer, "The Wild West");
                    return;
                case Collection.TimelinesOriginals:
                    serializer.Serialize(writer, "Timelines' Originals");
                    return;
                case Collection.ToBoldlyGo:
                    serializer.Serialize(writer, "To Boldly Go");
                    return;
                case Collection.UncommonCrew:
                    serializer.Serialize(writer, "Uncommon Crew");
                    return;
                case Collection.ValorInCombat:
                    serializer.Serialize(writer, "Valor in Combat");
                    return;
            }
            throw new Exception("Cannot marshal type Collection");
        }

        public static readonly CollectionConverter Singleton = new CollectionConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "crew_keystone_crate")
            {
                return TypeEnum.CrewKeystoneCrate;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            if (value == TypeEnum.CrewKeystoneCrate)
            {
                serializer.Serialize(writer, "crew_keystone_crate");
                return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class CrossFuseTargetsUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CrossFuseTargetsUnion) || t == typeof(CrossFuseTargetsUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<CrossFuseTargetsClass>(reader);
                    return new CrossFuseTargetsUnion { CrossFuseTargetsClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new CrossFuseTargetsUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type CrossFuseTargetsUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CrossFuseTargetsUnion)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.CrossFuseTargetsClass != null)
            {
                serializer.Serialize(writer, value.CrossFuseTargetsClass);
                return;
            }
            throw new Exception("Cannot marshal type CrossFuseTargetsUnion");
        }

        public static readonly CrossFuseTargetsUnionConverter Singleton = new CrossFuseTargetsUnionConverter();
    }

    internal class ObtainedConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Obtained) || t == typeof(Obtained?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Campaign":
                    return Obtained.Campaign;
                case "Event":
                    return Obtained.Event;
                case "Fuse":
                    return Obtained.Fuse;
                case "Fusion":
                    return Obtained.Fusion;
                case "Gauntlet":
                    return Obtained.Gauntlet;
                case "Giveaway":
                    return Obtained.Giveaway;
                case "Honor Hall":
                    return Obtained.HonorHall;
                case "Launch":
                    return Obtained.Launch;
                case "Mega":
                    return Obtained.Mega;
                case "Missions":
                    return Obtained.Missions;
                case "Pack":
                    return Obtained.Pack;
                case "Post-Launch":
                    return Obtained.PostLaunch;
                case "Voyage":
                    return Obtained.Voyage;
            }
            throw new Exception("Cannot unmarshal type Obtained");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Obtained)untypedValue;
            switch (value)
            {
                case Obtained.Campaign:
                    serializer.Serialize(writer, "Campaign");
                    return;
                case Obtained.Event:
                    serializer.Serialize(writer, "Event");
                    return;
                case Obtained.Fuse:
                    serializer.Serialize(writer, "Fuse");
                    return;
                case Obtained.Fusion:
                    serializer.Serialize(writer, "Fusion");
                    return;
                case Obtained.Gauntlet:
                    serializer.Serialize(writer, "Gauntlet");
                    return;
                case Obtained.Giveaway:
                    serializer.Serialize(writer, "Giveaway");
                    return;
                case Obtained.HonorHall:
                    serializer.Serialize(writer, "Honor Hall");
                    return;
                case Obtained.Launch:
                    serializer.Serialize(writer, "Launch");
                    return;
                case Obtained.Mega:
                    serializer.Serialize(writer, "Mega");
                    return;
                case Obtained.Missions:
                    serializer.Serialize(writer, "Missions");
                    return;
                case Obtained.Pack:
                    serializer.Serialize(writer, "Pack");
                    return;
                case Obtained.PostLaunch:
                    serializer.Serialize(writer, "Post-Launch");
                    return;
                case Obtained.Voyage:
                    serializer.Serialize(writer, "Voyage");
                    return;
            }
            throw new Exception("Cannot marshal type Obtained");
        }

        public static readonly ObtainedConverter Singleton = new ObtainedConverter();
    }

    internal class SeriesConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Series) || t == typeof(Series?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ds9":
                    return Series.Ds9;
                case "dsc":
                    return Series.Dsc;
                case "ent":
                    return Series.Ent;
                case "original":
                    return Series.Original;
                case "pic":
                    return Series.Pic;
                case "tas":
                    return Series.Tas;
                case "tng":
                    return Series.Tng;
                case "tos":
                    return Series.Tos;
                case "voy":
                    return Series.Voy;
            }
            throw new Exception("Cannot unmarshal type Series");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Series)untypedValue;
            switch (value)
            {
                case Series.Ds9:
                    serializer.Serialize(writer, "ds9");
                    return;
                case Series.Dsc:
                    serializer.Serialize(writer, "dsc");
                    return;
                case Series.Ent:
                    serializer.Serialize(writer, "ent");
                    return;
                case Series.Original:
                    serializer.Serialize(writer, "original");
                    return;
                case Series.Pic:
                    serializer.Serialize(writer, "pic");
                    return;
                case Series.Tas:
                    serializer.Serialize(writer, "tas");
                    return;
                case Series.Tng:
                    serializer.Serialize(writer, "tng");
                    return;
                case Series.Tos:
                    serializer.Serialize(writer, "tos");
                    return;
                case Series.Voy:
                    serializer.Serialize(writer, "voy");
                    return;
            }
            throw new Exception("Cannot marshal type Series");
        }

        public static readonly SeriesConverter Singleton = new SeriesConverter();
    }

    internal class TraitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Trait) || t == typeof(Trait?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "aenar":
                    return Trait.Aenar;
                case "allasomorph":
                    return Trait.Allasomorph;
                case "ambassador":
                    return Trait.Ambassador;
                case "andorian":
                    return Trait.Andorian;
                case "android":
                    return Trait.Android;
                case "angosian":
                    return Trait.Angosian;
                case "archon":
                    return Trait.Archon;
                case "argelian":
                    return Trait.Argelian;
                case "artist":
                    return Trait.Artist;
                case "astrophysicist":
                    return Trait.Astrophysicist;
                case "athlete":
                    return Trait.Athlete;
                case "augment":
                    return Trait.Augment;
                case "aurelian":
                    return Trait.Aurelian;
                case "automated_unit":
                    return Trait.AutomatedUnit;
                case "bajoran":
                    return Trait.Bajoran;
                case "baku":
                    return Trait.Baku;
                case "bartender":
                    return Trait.Bartender;
                case "barzan":
                    return Trait.Barzan;
                case "baul":
                    return Trait.Baul;
                case "benzite":
                    return Trait.Benzite;
                case "beta_annari":
                    return Trait.BetaAnnari;
                case "betazoid":
                    return Trait.Betazoid;
                case "betelgeusian":
                    return Trait.Betelgeusian;
                case "borg":
                    return Trait.Borg;
                case "botanist":
                    return Trait.Botanist;
                case "breen":
                    return Trait.Breen;
                case "brunali":
                    return Trait.Brunali;
                case "brutal":
                    return Trait.Brutal;
                case "bynar":
                    return Trait.Bynar;
                case "caitian":
                    return Trait.Caitian;
                case "cardassian":
                    return Trait.Cardassian;
                case "caregiver":
                    return Trait.Caregiver;
                case "casual":
                    return Trait.Casual;
                case "chameloid":
                    return Trait.Chameloid;
                case "changeling":
                    return Trait.Changeling;
                case "chef":
                    return Trait.Chef;
                case "civilian":
                    return Trait.Civilian;
                case "clone":
                    return Trait.Clone;
                case "command_skill":
                    return Trait.CommandSkill;
                case "communicator":
                    return Trait.Communicator;
                case "constable":
                    return Trait.Constable;
                case "control":
                    return Trait.Control;
                case "costumed":
                    return Trait.Costumed;
                case "counselor":
                    return Trait.Counselor;
                case "courier":
                    return Trait.Courier;
                case "crafty":
                    return Trait.Crafty;
                case "crew_max_rarity_1":
                    return Trait.CrewMaxRarity1;
                case "crew_max_rarity_2":
                    return Trait.CrewMaxRarity2;
                case "crew_max_rarity_3":
                    return Trait.CrewMaxRarity3;
                case "crew_max_rarity_4":
                    return Trait.CrewMaxRarity4;
                case "crew_max_rarity_5":
                    return Trait.CrewMaxRarity5;
                case "criminal":
                    return Trait.Criminal;
                case "cultural_figure":
                    return Trait.CulturalFigure;
                case "cyberneticist":
                    return Trait.Cyberneticist;
                case "dahar_master":
                    return Trait.DaharMaster;
                case "deltan":
                    return Trait.Deltan;
                case "denobulan":
                    return Trait.Denobulan;
                case "desperate":
                    return Trait.Desperate;
                case "diplomacy_skill":
                    return Trait.DiplomacySkill;
                case "diplomat":
                    return Trait.Diplomat;
                case "doctor":
                    return Trait.Doctor;
                case "dominion":
                    return Trait.Dominion;
                case "dosi":
                    return Trait.Dosi;
                case "douwd":
                    return Trait.Douwd;
                case "duelist":
                    return Trait.Duelist;
                case "edosian":
                    return Trait.Edosian;
                case "efrosian":
                    return Trait.Efrosian;
                case "elaurian":
                    return Trait.Elaurian;
                case "elaysian":
                    return Trait.Elaysian;
                case "empath":
                    return Trait.Empath;
                case "engineered":
                    return Trait.Engineered;
                case "engineering_skill":
                    return Trait.EngineeringSkill;
                case "excalbian":
                    return Trait.Excalbian;
                case "exoarchaeology":
                    return Trait.Exoarchaeology;
                case "exobiology":
                    return Trait.Exobiology;
                case "exomycologist":
                    return Trait.Exomycologist;
                case "explorer":
                    return Trait.Explorer;
                case "federation":
                    return Trait.Federation;
                case "ferengi":
                    return Trait.Ferengi;
                case "gambler":
                    return Trait.Gambler;
                case "gardener":
                    return Trait.Gardener;
                case "geneticist":
                    return Trait.Geneticist;
                case "geologist":
                    return Trait.Geologist;
                case "gorn":
                    return Trait.Gorn;
                case "hero":
                    return Trait.Hero;
                case "high_command":
                    return Trait.HighCommand;
                case "hirogen":
                    return Trait.Hirogen;
                case "hologram":
                    return Trait.Hologram;
                case "human":
                    return Trait.Human;
                case "hunter":
                    return Trait.Hunter;
                case "ikaaran":
                    return Trait.Ikaaran;
                case "imperial_guard":
                    return Trait.ImperialGuard;
                case "innovator":
                    return Trait.Innovator;
                case "inspiring":
                    return Trait.Inspiring;
                case "interrogator":
                    return Trait.Interrogator;
                case "investigator":
                    return Trait.Investigator;
                case "jahsepp":
                    return Trait.Jahsepp;
                case "jemhadar":
                    return Trait.Jemhadar;
                case "jnaii":
                    return Trait.Jnaii;
                case "jury_rigger":
                    return Trait.JuryRigger;
                case "kaelon":
                    return Trait.Kaelon;
                case "kai":
                    return Trait.Kai;
                case "kalandan":
                    return Trait.Kalandan;
                case "kataan":
                    return Trait.Kataan;
                case "kazon":
                    return Trait.Kazon;
                case "kca":
                    return Trait.Kca;
                case "kelpien":
                    return Trait.Kelpien;
                case "klingon":
                    return Trait.Klingon;
                case "kraylor":
                    return Trait.Kraylor;
                case "krenim":
                    return Trait.Krenim;
                case "kriosian":
                    return Trait.Kriosian;
                case "ktarian":
                    return Trait.Ktarian;
                case "kwejian":
                    return Trait.Kwejian;
                case "linguist":
                    return Trait.Linguist;
                case "loqueeque":
                    return Trait.Loqueeque;
                case "lurian":
                    return Trait.Lurian;
                case "m113_creature":
                    return Trait.M113Creature;
                case "maco":
                    return Trait.Maco;
                case "malon":
                    return Trait.Malon;
                case "maquis":
                    return Trait.Maquis;
                case "marksman":
                    return Trait.Marksman;
                case "maverick":
                    return Trait.Maverick;
                case "medicine_skill":
                    return Trait.MedicineSkill;
                case "merchant":
                    return Trait.Merchant;
                case "mintakan":
                    return Trait.Mintakan;
                case "mirror_universe":
                    return Trait.MirrorUniverse;
                case "mugato":
                    return Trait.Mugato;
                case "musician":
                    return Trait.Musician;
                case "mylean":
                    return Trait.Mylean;
                case "nacene":
                    return Trait.Nacene;
                case "nakuhl":
                    return Trait.Nakuhl;
                case "nasat":
                    return Trait.Nasat;
                case "neural":
                    return Trait.Neural;
                case "neurologist":
                    return Trait.Neurologist;
                case "nurse":
                    return Trait.Nurse;
                case "obsidian_order":
                    return Trait.ObsidianOrder;
                case "ocampa":
                    return Trait.Ocampa;
                case "orion":
                    return Trait.Orion;
                case "pakled":
                    return Trait.Pakled;
                case "pandronian":
                    return Trait.Pandronian;
                case "pilot":
                    return Trait.Pilot;
                case "politician":
                    return Trait.Politician;
                case "presage":
                    return Trait.Presage;
                case "primal":
                    return Trait.Primal;
                case "prisoner":
                    return Trait.Prisoner;
                case "probe":
                    return Trait.Probe;
                case "prodigy":
                    return Trait.Prodigy;
                case "prophet":
                    return Trait.Prophet;
                case "q":
                    return Trait.Q;
                case "qowat_milat":
                    return Trait.QowatMilat;
                case "quantum_mechanics":
                    return Trait.QuantumMechanics;
                case "ramatis_3_native":
                    return Trait.Ramatis3_Native;
                case "reman":
                    return Trait.Reman;
                case "resourceful":
                    return Trait.Resourceful;
                case "risian":
                    return Trait.Risian;
                case "romantic":
                    return Trait.Romantic;
                case "romulan":
                    return Trait.Romulan;
                case "royalty":
                    return Trait.Royalty;
                case "saboteur":
                    return Trait.Saboteur;
                case "sarpeidon":
                    return Trait.Sarpeidon;
                case "saurian":
                    return Trait.Saurian;
                case "science_skill":
                    return Trait.ScienceSkill;
                case "scoundrel":
                    return Trait.Scoundrel;
                case "section31":
                    return Trait.Section31;
                case "security_skill":
                    return Trait.SecuritySkill;
                case "shapeshifter":
                    return Trait.Shapeshifter;
                case "silicon_lifeform":
                    return Trait.SiliconLifeform;
                case "smuggler":
                    return Trait.Smuggler;
                case "sona":
                    return Trait.Sona;
                case "species_8472":
                    return Trait.Species8472;
                case "spiritual":
                    return Trait.Spiritual;
                case "starfleet":
                    return Trait.Starfleet;
                case "suliban":
                    return Trait.Suliban;
                case "survivalist":
                    return Trait.Survivalist;
                case "syrrannite":
                    return Trait.Syrrannite;
                case "tactician":
                    return Trait.Tactician;
                case "tal_shiar":
                    return Trait.TalShiar;
                case "talaxian":
                    return Trait.Talaxian;
                case "talosian":
                    return Trait.Talosian;
                case "tamarian":
                    return Trait.Tamarian;
                case "taresian":
                    return Trait.Taresian;
                case "telekinetic":
                    return Trait.Telekinetic;
                case "telepath":
                    return Trait.Telepath;
                case "temporal_agent":
                    return Trait.TemporalAgent;
                case "terran_empire":
                    return Trait.TerranEmpire;
                case "terran_rebellion":
                    return Trait.TerranRebellion;
                case "terrellian":
                    return Trait.Terrellian;
                case "theoretical_engineer":
                    return Trait.TheoreticalEngineer;
                case "thief":
                    return Trait.Thief;
                case "tholian":
                    return Trait.Tholian;
                case "tkon":
                    return Trait.Tkon;
                case "tosk":
                    return Trait.Tosk;
                case "tribble":
                    return Trait.Tribble;
                case "trill":
                    return Trait.Trill;
                case "undercover_operative":
                    return Trait.UndercoverOperative;
                case "vedek":
                    return Trait.Vedek;
                case "veteran":
                    return Trait.Veteran;
                case "vidiian":
                    return Trait.Vidiian;
                case "villain":
                    return Trait.Villain;
                case "vorta":
                    return Trait.Vorta;
                case "voth":
                    return Trait.Voth;
                case "vulcan":
                    return Trait.Vulcan;
                case "warp_theorist":
                    return Trait.WarpTheorist;
                case "writer":
                    return Trait.Writer;
                case "xahean":
                    return Trait.Xahean;
                case "xenoanthropology":
                    return Trait.Xenoanthropology;
                case "xindi":
                    return Trait.Xindi;
                case "zahl":
                    return Trait.Zahl;
                case "zhat_vash":
                    return Trait.ZhatVash;
                case "zibelian":
                    return Trait.Zibelian;
            }
            throw new Exception("Cannot unmarshal type Trait");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Trait)untypedValue;
            switch (value)
            {
                case Trait.Aenar:
                    serializer.Serialize(writer, "aenar");
                    return;
                case Trait.Allasomorph:
                    serializer.Serialize(writer, "allasomorph");
                    return;
                case Trait.Ambassador:
                    serializer.Serialize(writer, "ambassador");
                    return;
                case Trait.Andorian:
                    serializer.Serialize(writer, "andorian");
                    return;
                case Trait.Android:
                    serializer.Serialize(writer, "android");
                    return;
                case Trait.Angosian:
                    serializer.Serialize(writer, "angosian");
                    return;
                case Trait.Archon:
                    serializer.Serialize(writer, "archon");
                    return;
                case Trait.Argelian:
                    serializer.Serialize(writer, "argelian");
                    return;
                case Trait.Artist:
                    serializer.Serialize(writer, "artist");
                    return;
                case Trait.Astrophysicist:
                    serializer.Serialize(writer, "astrophysicist");
                    return;
                case Trait.Athlete:
                    serializer.Serialize(writer, "athlete");
                    return;
                case Trait.Augment:
                    serializer.Serialize(writer, "augment");
                    return;
                case Trait.Aurelian:
                    serializer.Serialize(writer, "aurelian");
                    return;
                case Trait.AutomatedUnit:
                    serializer.Serialize(writer, "automated_unit");
                    return;
                case Trait.Bajoran:
                    serializer.Serialize(writer, "bajoran");
                    return;
                case Trait.Baku:
                    serializer.Serialize(writer, "baku");
                    return;
                case Trait.Bartender:
                    serializer.Serialize(writer, "bartender");
                    return;
                case Trait.Barzan:
                    serializer.Serialize(writer, "barzan");
                    return;
                case Trait.Baul:
                    serializer.Serialize(writer, "baul");
                    return;
                case Trait.Benzite:
                    serializer.Serialize(writer, "benzite");
                    return;
                case Trait.BetaAnnari:
                    serializer.Serialize(writer, "beta_annari");
                    return;
                case Trait.Betazoid:
                    serializer.Serialize(writer, "betazoid");
                    return;
                case Trait.Betelgeusian:
                    serializer.Serialize(writer, "betelgeusian");
                    return;
                case Trait.Borg:
                    serializer.Serialize(writer, "borg");
                    return;
                case Trait.Botanist:
                    serializer.Serialize(writer, "botanist");
                    return;
                case Trait.Breen:
                    serializer.Serialize(writer, "breen");
                    return;
                case Trait.Brunali:
                    serializer.Serialize(writer, "brunali");
                    return;
                case Trait.Brutal:
                    serializer.Serialize(writer, "brutal");
                    return;
                case Trait.Bynar:
                    serializer.Serialize(writer, "bynar");
                    return;
                case Trait.Caitian:
                    serializer.Serialize(writer, "caitian");
                    return;
                case Trait.Cardassian:
                    serializer.Serialize(writer, "cardassian");
                    return;
                case Trait.Caregiver:
                    serializer.Serialize(writer, "caregiver");
                    return;
                case Trait.Casual:
                    serializer.Serialize(writer, "casual");
                    return;
                case Trait.Chameloid:
                    serializer.Serialize(writer, "chameloid");
                    return;
                case Trait.Changeling:
                    serializer.Serialize(writer, "changeling");
                    return;
                case Trait.Chef:
                    serializer.Serialize(writer, "chef");
                    return;
                case Trait.Civilian:
                    serializer.Serialize(writer, "civilian");
                    return;
                case Trait.Clone:
                    serializer.Serialize(writer, "clone");
                    return;
                case Trait.CommandSkill:
                    serializer.Serialize(writer, "command_skill");
                    return;
                case Trait.Communicator:
                    serializer.Serialize(writer, "communicator");
                    return;
                case Trait.Constable:
                    serializer.Serialize(writer, "constable");
                    return;
                case Trait.Control:
                    serializer.Serialize(writer, "control");
                    return;
                case Trait.Costumed:
                    serializer.Serialize(writer, "costumed");
                    return;
                case Trait.Counselor:
                    serializer.Serialize(writer, "counselor");
                    return;
                case Trait.Courier:
                    serializer.Serialize(writer, "courier");
                    return;
                case Trait.Crafty:
                    serializer.Serialize(writer, "crafty");
                    return;
                case Trait.CrewMaxRarity1:
                    serializer.Serialize(writer, "crew_max_rarity_1");
                    return;
                case Trait.CrewMaxRarity2:
                    serializer.Serialize(writer, "crew_max_rarity_2");
                    return;
                case Trait.CrewMaxRarity3:
                    serializer.Serialize(writer, "crew_max_rarity_3");
                    return;
                case Trait.CrewMaxRarity4:
                    serializer.Serialize(writer, "crew_max_rarity_4");
                    return;
                case Trait.CrewMaxRarity5:
                    serializer.Serialize(writer, "crew_max_rarity_5");
                    return;
                case Trait.Criminal:
                    serializer.Serialize(writer, "criminal");
                    return;
                case Trait.CulturalFigure:
                    serializer.Serialize(writer, "cultural_figure");
                    return;
                case Trait.Cyberneticist:
                    serializer.Serialize(writer, "cyberneticist");
                    return;
                case Trait.DaharMaster:
                    serializer.Serialize(writer, "dahar_master");
                    return;
                case Trait.Deltan:
                    serializer.Serialize(writer, "deltan");
                    return;
                case Trait.Denobulan:
                    serializer.Serialize(writer, "denobulan");
                    return;
                case Trait.Desperate:
                    serializer.Serialize(writer, "desperate");
                    return;
                case Trait.DiplomacySkill:
                    serializer.Serialize(writer, "diplomacy_skill");
                    return;
                case Trait.Diplomat:
                    serializer.Serialize(writer, "diplomat");
                    return;
                case Trait.Doctor:
                    serializer.Serialize(writer, "doctor");
                    return;
                case Trait.Dominion:
                    serializer.Serialize(writer, "dominion");
                    return;
                case Trait.Dosi:
                    serializer.Serialize(writer, "dosi");
                    return;
                case Trait.Douwd:
                    serializer.Serialize(writer, "douwd");
                    return;
                case Trait.Duelist:
                    serializer.Serialize(writer, "duelist");
                    return;
                case Trait.Edosian:
                    serializer.Serialize(writer, "edosian");
                    return;
                case Trait.Efrosian:
                    serializer.Serialize(writer, "efrosian");
                    return;
                case Trait.Elaurian:
                    serializer.Serialize(writer, "elaurian");
                    return;
                case Trait.Elaysian:
                    serializer.Serialize(writer, "elaysian");
                    return;
                case Trait.Empath:
                    serializer.Serialize(writer, "empath");
                    return;
                case Trait.Engineered:
                    serializer.Serialize(writer, "engineered");
                    return;
                case Trait.EngineeringSkill:
                    serializer.Serialize(writer, "engineering_skill");
                    return;
                case Trait.Excalbian:
                    serializer.Serialize(writer, "excalbian");
                    return;
                case Trait.Exoarchaeology:
                    serializer.Serialize(writer, "exoarchaeology");
                    return;
                case Trait.Exobiology:
                    serializer.Serialize(writer, "exobiology");
                    return;
                case Trait.Exomycologist:
                    serializer.Serialize(writer, "exomycologist");
                    return;
                case Trait.Explorer:
                    serializer.Serialize(writer, "explorer");
                    return;
                case Trait.Federation:
                    serializer.Serialize(writer, "federation");
                    return;
                case Trait.Ferengi:
                    serializer.Serialize(writer, "ferengi");
                    return;
                case Trait.Gambler:
                    serializer.Serialize(writer, "gambler");
                    return;
                case Trait.Gardener:
                    serializer.Serialize(writer, "gardener");
                    return;
                case Trait.Geneticist:
                    serializer.Serialize(writer, "geneticist");
                    return;
                case Trait.Geologist:
                    serializer.Serialize(writer, "geologist");
                    return;
                case Trait.Gorn:
                    serializer.Serialize(writer, "gorn");
                    return;
                case Trait.Hero:
                    serializer.Serialize(writer, "hero");
                    return;
                case Trait.HighCommand:
                    serializer.Serialize(writer, "high_command");
                    return;
                case Trait.Hirogen:
                    serializer.Serialize(writer, "hirogen");
                    return;
                case Trait.Hologram:
                    serializer.Serialize(writer, "hologram");
                    return;
                case Trait.Human:
                    serializer.Serialize(writer, "human");
                    return;
                case Trait.Hunter:
                    serializer.Serialize(writer, "hunter");
                    return;
                case Trait.Ikaaran:
                    serializer.Serialize(writer, "ikaaran");
                    return;
                case Trait.ImperialGuard:
                    serializer.Serialize(writer, "imperial_guard");
                    return;
                case Trait.Innovator:
                    serializer.Serialize(writer, "innovator");
                    return;
                case Trait.Inspiring:
                    serializer.Serialize(writer, "inspiring");
                    return;
                case Trait.Interrogator:
                    serializer.Serialize(writer, "interrogator");
                    return;
                case Trait.Investigator:
                    serializer.Serialize(writer, "investigator");
                    return;
                case Trait.Jahsepp:
                    serializer.Serialize(writer, "jahsepp");
                    return;
                case Trait.Jemhadar:
                    serializer.Serialize(writer, "jemhadar");
                    return;
                case Trait.Jnaii:
                    serializer.Serialize(writer, "jnaii");
                    return;
                case Trait.JuryRigger:
                    serializer.Serialize(writer, "jury_rigger");
                    return;
                case Trait.Kaelon:
                    serializer.Serialize(writer, "kaelon");
                    return;
                case Trait.Kai:
                    serializer.Serialize(writer, "kai");
                    return;
                case Trait.Kalandan:
                    serializer.Serialize(writer, "kalandan");
                    return;
                case Trait.Kataan:
                    serializer.Serialize(writer, "kataan");
                    return;
                case Trait.Kazon:
                    serializer.Serialize(writer, "kazon");
                    return;
                case Trait.Kca:
                    serializer.Serialize(writer, "kca");
                    return;
                case Trait.Kelpien:
                    serializer.Serialize(writer, "kelpien");
                    return;
                case Trait.Klingon:
                    serializer.Serialize(writer, "klingon");
                    return;
                case Trait.Kraylor:
                    serializer.Serialize(writer, "kraylor");
                    return;
                case Trait.Krenim:
                    serializer.Serialize(writer, "krenim");
                    return;
                case Trait.Kriosian:
                    serializer.Serialize(writer, "kriosian");
                    return;
                case Trait.Ktarian:
                    serializer.Serialize(writer, "ktarian");
                    return;
                case Trait.Kwejian:
                    serializer.Serialize(writer, "kwejian");
                    return;
                case Trait.Linguist:
                    serializer.Serialize(writer, "linguist");
                    return;
                case Trait.Loqueeque:
                    serializer.Serialize(writer, "loqueeque");
                    return;
                case Trait.Lurian:
                    serializer.Serialize(writer, "lurian");
                    return;
                case Trait.M113Creature:
                    serializer.Serialize(writer, "m113_creature");
                    return;
                case Trait.Maco:
                    serializer.Serialize(writer, "maco");
                    return;
                case Trait.Malon:
                    serializer.Serialize(writer, "malon");
                    return;
                case Trait.Maquis:
                    serializer.Serialize(writer, "maquis");
                    return;
                case Trait.Marksman:
                    serializer.Serialize(writer, "marksman");
                    return;
                case Trait.Maverick:
                    serializer.Serialize(writer, "maverick");
                    return;
                case Trait.MedicineSkill:
                    serializer.Serialize(writer, "medicine_skill");
                    return;
                case Trait.Merchant:
                    serializer.Serialize(writer, "merchant");
                    return;
                case Trait.Mintakan:
                    serializer.Serialize(writer, "mintakan");
                    return;
                case Trait.MirrorUniverse:
                    serializer.Serialize(writer, "mirror_universe");
                    return;
                case Trait.Mugato:
                    serializer.Serialize(writer, "mugato");
                    return;
                case Trait.Musician:
                    serializer.Serialize(writer, "musician");
                    return;
                case Trait.Mylean:
                    serializer.Serialize(writer, "mylean");
                    return;
                case Trait.Nacene:
                    serializer.Serialize(writer, "nacene");
                    return;
                case Trait.Nakuhl:
                    serializer.Serialize(writer, "nakuhl");
                    return;
                case Trait.Nasat:
                    serializer.Serialize(writer, "nasat");
                    return;
                case Trait.Neural:
                    serializer.Serialize(writer, "neural");
                    return;
                case Trait.Neurologist:
                    serializer.Serialize(writer, "neurologist");
                    return;
                case Trait.Nurse:
                    serializer.Serialize(writer, "nurse");
                    return;
                case Trait.ObsidianOrder:
                    serializer.Serialize(writer, "obsidian_order");
                    return;
                case Trait.Ocampa:
                    serializer.Serialize(writer, "ocampa");
                    return;
                case Trait.Orion:
                    serializer.Serialize(writer, "orion");
                    return;
                case Trait.Pakled:
                    serializer.Serialize(writer, "pakled");
                    return;
                case Trait.Pandronian:
                    serializer.Serialize(writer, "pandronian");
                    return;
                case Trait.Pilot:
                    serializer.Serialize(writer, "pilot");
                    return;
                case Trait.Politician:
                    serializer.Serialize(writer, "politician");
                    return;
                case Trait.Presage:
                    serializer.Serialize(writer, "presage");
                    return;
                case Trait.Primal:
                    serializer.Serialize(writer, "primal");
                    return;
                case Trait.Prisoner:
                    serializer.Serialize(writer, "prisoner");
                    return;
                case Trait.Probe:
                    serializer.Serialize(writer, "probe");
                    return;
                case Trait.Prodigy:
                    serializer.Serialize(writer, "prodigy");
                    return;
                case Trait.Prophet:
                    serializer.Serialize(writer, "prophet");
                    return;
                case Trait.Q:
                    serializer.Serialize(writer, "q");
                    return;
                case Trait.QowatMilat:
                    serializer.Serialize(writer, "qowat_milat");
                    return;
                case Trait.QuantumMechanics:
                    serializer.Serialize(writer, "quantum_mechanics");
                    return;
                case Trait.Ramatis3_Native:
                    serializer.Serialize(writer, "ramatis_3_native");
                    return;
                case Trait.Reman:
                    serializer.Serialize(writer, "reman");
                    return;
                case Trait.Resourceful:
                    serializer.Serialize(writer, "resourceful");
                    return;
                case Trait.Risian:
                    serializer.Serialize(writer, "risian");
                    return;
                case Trait.Romantic:
                    serializer.Serialize(writer, "romantic");
                    return;
                case Trait.Romulan:
                    serializer.Serialize(writer, "romulan");
                    return;
                case Trait.Royalty:
                    serializer.Serialize(writer, "royalty");
                    return;
                case Trait.Saboteur:
                    serializer.Serialize(writer, "saboteur");
                    return;
                case Trait.Sarpeidon:
                    serializer.Serialize(writer, "sarpeidon");
                    return;
                case Trait.Saurian:
                    serializer.Serialize(writer, "saurian");
                    return;
                case Trait.ScienceSkill:
                    serializer.Serialize(writer, "science_skill");
                    return;
                case Trait.Scoundrel:
                    serializer.Serialize(writer, "scoundrel");
                    return;
                case Trait.Section31:
                    serializer.Serialize(writer, "section31");
                    return;
                case Trait.SecuritySkill:
                    serializer.Serialize(writer, "security_skill");
                    return;
                case Trait.Shapeshifter:
                    serializer.Serialize(writer, "shapeshifter");
                    return;
                case Trait.SiliconLifeform:
                    serializer.Serialize(writer, "silicon_lifeform");
                    return;
                case Trait.Smuggler:
                    serializer.Serialize(writer, "smuggler");
                    return;
                case Trait.Sona:
                    serializer.Serialize(writer, "sona");
                    return;
                case Trait.Species8472:
                    serializer.Serialize(writer, "species_8472");
                    return;
                case Trait.Spiritual:
                    serializer.Serialize(writer, "spiritual");
                    return;
                case Trait.Starfleet:
                    serializer.Serialize(writer, "starfleet");
                    return;
                case Trait.Suliban:
                    serializer.Serialize(writer, "suliban");
                    return;
                case Trait.Survivalist:
                    serializer.Serialize(writer, "survivalist");
                    return;
                case Trait.Syrrannite:
                    serializer.Serialize(writer, "syrrannite");
                    return;
                case Trait.Tactician:
                    serializer.Serialize(writer, "tactician");
                    return;
                case Trait.TalShiar:
                    serializer.Serialize(writer, "tal_shiar");
                    return;
                case Trait.Talaxian:
                    serializer.Serialize(writer, "talaxian");
                    return;
                case Trait.Talosian:
                    serializer.Serialize(writer, "talosian");
                    return;
                case Trait.Tamarian:
                    serializer.Serialize(writer, "tamarian");
                    return;
                case Trait.Taresian:
                    serializer.Serialize(writer, "taresian");
                    return;
                case Trait.Telekinetic:
                    serializer.Serialize(writer, "telekinetic");
                    return;
                case Trait.Telepath:
                    serializer.Serialize(writer, "telepath");
                    return;
                case Trait.TemporalAgent:
                    serializer.Serialize(writer, "temporal_agent");
                    return;
                case Trait.TerranEmpire:
                    serializer.Serialize(writer, "terran_empire");
                    return;
                case Trait.TerranRebellion:
                    serializer.Serialize(writer, "terran_rebellion");
                    return;
                case Trait.Terrellian:
                    serializer.Serialize(writer, "terrellian");
                    return;
                case Trait.TheoreticalEngineer:
                    serializer.Serialize(writer, "theoretical_engineer");
                    return;
                case Trait.Thief:
                    serializer.Serialize(writer, "thief");
                    return;
                case Trait.Tholian:
                    serializer.Serialize(writer, "tholian");
                    return;
                case Trait.Tkon:
                    serializer.Serialize(writer, "tkon");
                    return;
                case Trait.Tosk:
                    serializer.Serialize(writer, "tosk");
                    return;
                case Trait.Tribble:
                    serializer.Serialize(writer, "tribble");
                    return;
                case Trait.Trill:
                    serializer.Serialize(writer, "trill");
                    return;
                case Trait.UndercoverOperative:
                    serializer.Serialize(writer, "undercover_operative");
                    return;
                case Trait.Vedek:
                    serializer.Serialize(writer, "vedek");
                    return;
                case Trait.Veteran:
                    serializer.Serialize(writer, "veteran");
                    return;
                case Trait.Vidiian:
                    serializer.Serialize(writer, "vidiian");
                    return;
                case Trait.Villain:
                    serializer.Serialize(writer, "villain");
                    return;
                case Trait.Vorta:
                    serializer.Serialize(writer, "vorta");
                    return;
                case Trait.Voth:
                    serializer.Serialize(writer, "voth");
                    return;
                case Trait.Vulcan:
                    serializer.Serialize(writer, "vulcan");
                    return;
                case Trait.WarpTheorist:
                    serializer.Serialize(writer, "warp_theorist");
                    return;
                case Trait.Writer:
                    serializer.Serialize(writer, "writer");
                    return;
                case Trait.Xahean:
                    serializer.Serialize(writer, "xahean");
                    return;
                case Trait.Xenoanthropology:
                    serializer.Serialize(writer, "xenoanthropology");
                    return;
                case Trait.Xindi:
                    serializer.Serialize(writer, "xindi");
                    return;
                case Trait.Zahl:
                    serializer.Serialize(writer, "zahl");
                    return;
                case Trait.ZhatVash:
                    serializer.Serialize(writer, "zhat_vash");
                    return;
                case Trait.Zibelian:
                    serializer.Serialize(writer, "zibelian");
                    return;
            }
            throw new Exception("Cannot marshal type Trait");
        }

        public static readonly TraitConverter Singleton = new TraitConverter();
    }
}
