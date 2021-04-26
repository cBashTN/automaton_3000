using Newtonsoft.Json;

namespace ExtractFeatures.Output
{
    /// <summary>
    /// Feature ideas not implemented:
    /// - Collections are now counted. But they might not be weighted evenly. So we could "one hot encoding" every collection. Eg. "is_in_collection_HehChoMruakTah"
    /// - "Obtained" should not influence the tier. Shouldn't it?
    /// 
    /// </summary>
    class CrewFeatures
    {
        /// <summary>
        /// This is the target. Not normalized.
        /// </summary>
        [JsonProperty("bigbook_tier")] public float BigBookTier { get; set; }

        /// <summary>
        /// The count of skills. "DIP"+"SEC" = 2 skills
        /// </summary>
        [JsonProperty("skills_count")] public float SkillsCount { get; set; }

        /// <summary>
        /// Some combinations occur more frequently than others. This value indicates how rare this combination is in relation to the others.
        /// Eg. DIP/CMD is not that rare.
        /// </summary>
        [JsonProperty("skills_combinationRarity")] public float SkillsCombinationRarity { get; set; }

        /// <summary>
        /// Like SkillsCombinationRarity but here only the rarity for each crew rarity is calculated.
        /// Eg. DIP/CMD is not that rare in 3* crew. But it is even rarer in 2* crew.
        /// </summary>
        [JsonProperty("skills_combinationRarity_perCrewRarity")] public float SkillsCombinationRarityPerCrewRarity { get; set; }

        [JsonProperty("max_rarity")] public float MaxRarity { get; set; }

        [JsonProperty("voyRank")] public float? VoyRank { get; set; }

        [JsonProperty("gauntletRank")] public float? GauntletRank { get; set; }

        [JsonProperty("science_skill_core")] public float? 	ScienceSkillCore	 { get; set; }
        [JsonProperty("science_skill_range_min")] public float? 	ScienceSkillRangeMin		 { get; set; }
        [JsonProperty("science_skill_range_max")] public float? ScienceSkillRangeMax { get; set; }
        [JsonProperty("security_skill_core")] public float? SecuritySkillCore { get; set; }
        [JsonProperty("security_skill_range_min")] public float? SecuritySkillRangeMin { get; set; }
        [JsonProperty("security_skill_range_max")] public float? SecuritySkillRangeMax { get; set; }
        [JsonProperty("command_skill_core")] public float? 	CommandSkillCore	 { get; set; }
        [JsonProperty("command_skill_range_min")] public float? CommandSkillRangeMin { get; set; }
        [JsonProperty("command_skill_range_max")] public float? CommandSkillRangeMax { get; set; }
        [JsonProperty("diplomacy_skill_core")] public float? DiplomacySkillCore { get; set; }
        [JsonProperty("diplomacy_skill_range_min")] public float? DiplomacySkillRangeMin { get; set; }
        [JsonProperty("diplomacy_skill_range_max")] public float? DiplomacySkillRangeMax { get; set; }
        [JsonProperty("engineering_skill_core")] public float? EngineeringSkillCore { get; set; }
        [JsonProperty("engineering_skill_range_min")] public float? EngineeringSkillRangeMin { get; set; }
        [JsonProperty("engineering_skill_range_max")] public float? EngineeringSkillRangeMax { get; set; }
        [JsonProperty("medicine_skill_core")] public float? MedicineSkillCore { get; set; }
        [JsonProperty("medicine_skill_range_min")] public float? MedicineSkillRangeMin { get; set; }
        [JsonProperty("medicine_skill_range_max")] public float? MedicineSkillRangeMax { get; set; }


        [JsonProperty("B_CMD"    )] public float? B_CMD      { get; set; } 
        [JsonProperty("A_CMD"    )] public float? A_CMD      { get; set; }
        [JsonProperty("B_SCI"    )] public float? B_SCI      { get; set; }
        [JsonProperty("A_SCI"    )] public float? A_SCI      { get; set; }
        [JsonProperty("B_SEC"    )] public float? B_SEC      { get; set; }
        [JsonProperty("A_SEC"    )] public float? A_SEC      { get; set; }
        [JsonProperty("V_CMD_SCI")] public float? V_CMD_SCI  { get; set; }
        [JsonProperty("G_CMD_SCI")] public float? G_CMD_SCI  { get; set; }
        [JsonProperty("V_CMD_SEC")] public float? V_CMD_SEC  { get; set; }
        [JsonProperty("G_CMD_SEC")] public float? G_CMD_SEC  { get; set; }
        [JsonProperty("V_CMD_ENG")] public float? V_CMD_ENG  { get; set; }
        [JsonProperty("G_CMD_ENG")] public float? G_CMD_ENG  { get; set; }
        [JsonProperty("V_CMD_DIP")] public float? V_CMD_DIP  { get; set; }
        [JsonProperty("G_CMD_DIP")] public float? G_CMD_DIP  { get; set; }
        [JsonProperty("V_CMD_MED")] public float? V_CMD_MED  { get; set; }
        [JsonProperty("G_CMD_MED")] public float? G_CMD_MED  { get; set; }
        [JsonProperty("V_SCI_SEC")] public float? V_SCI_SEC  { get; set; }
        [JsonProperty("G_SCI_SEC")] public float? G_SCI_SEC  { get; set; }
        [JsonProperty("V_SCI_ENG")] public float? V_SCI_ENG  { get; set; }
        [JsonProperty("G_SCI_ENG")] public float? G_SCI_ENG  { get; set; }
        [JsonProperty("V_SCI_DIP")] public float? V_SCI_DIP  { get; set; }
        [JsonProperty("G_SCI_DIP")] public float? G_SCI_DIP  { get; set; }
        [JsonProperty("V_SCI_MED")] public float? V_SCI_MED  { get; set; }
        [JsonProperty("G_SCI_MED")] public float? G_SCI_MED  { get; set; }
        [JsonProperty("V_SEC_ENG")] public float? V_SEC_ENG  { get; set; }
        [JsonProperty("G_SEC_ENG")] public float? G_SEC_ENG  { get; set; }
        [JsonProperty("V_SEC_DIP")] public float? V_SEC_DIP  { get; set; }
        [JsonProperty("G_SEC_DIP")] public float? G_SEC_DIP  { get; set; }
        [JsonProperty("V_SEC_MED")] public float? V_SEC_MED  { get; set; }
        [JsonProperty("G_SEC_MED")] public float? G_SEC_MED  { get; set; }
        [JsonProperty("V_ENG_DIP")] public float? V_ENG_DIP  { get; set; }
        [JsonProperty("V_ENG_MED")] public float? V_ENG_MED  { get; set; }
        [JsonProperty("V_DIP_MED")] public float? V_DIP_MED  { get; set; }
        [JsonProperty("events")] public float EventsCount { get; set; }
        [JsonProperty("in_portal")] public bool IsInPortal { get; set; }

        /// <summary>
        /// The count of days the crew was added (date_added)
        /// </summary>
        [JsonProperty("days_from_date_added")] public int DaysFromDateAdded { get; set; }


        [JsonProperty("collections_count")] public int InCollectionsCount { get; set; }


        [JsonProperty("series_ds9")] public bool IsInSeries_ds9 { get; set; }
        /// <summary>
        /// This series is still running and, therefore, events with its crew are more likely
        /// </summary>
        [JsonProperty("series_dsc")] public bool IsInSeries_dsc { get; set; }
        [JsonProperty("series_ent")] public bool IsInSeries_ent { get; set; }
        [JsonProperty("series_original")] public bool IsInSeries_original { get; set; }
        /// <summary>
        /// This series is still running and, therefore, events with its crew are more likely
        /// </summary>
        [JsonProperty("series_pic")] public bool IsInSeries_pic { get; set; }
        [JsonProperty("series_tas")] public bool IsInSeries_tas { get; set; }
        [JsonProperty("series_tng")] public bool IsInSeries_tng { get; set; }
        [JsonProperty("series_tos")] public bool IsInSeries_tos { get; set; }
        [JsonProperty("series_voy")] public bool IsInSeries_voy { get; set; }

        [JsonProperty("ship_battle_accuracy_max")] public float? ShipBattleAccuracyMax { get; set; }
        [JsonProperty("ship_battle_evasion_max")] public float? ShipBattleEvasionMax { get; set; }
        [JsonProperty("ship_battle_crit_chance_max")] public float? ShipBattleCritChanceMax { get; set; }
        [JsonProperty("ship_battle_crit_bonus_max")] public float? ShipBattleCritBonusMax { get; set; }

        [JsonProperty("action_bonus_amount")] public float? ActionBonusAmount { get; set; }
        [JsonProperty("action_cooldown")] public float? ActionCooldown { get; set; }
        [JsonProperty("action_initial_cooldown")] public float? ActionInitialCooldown { get; set; }
        [JsonProperty("action_duration")] public float? ActionDuration { get; set; }
        [JsonProperty("action_limit")] public float? ActionLimit { get; set; }
        [JsonProperty("action_bonus_type")] public float? ActionBonusType { get; set; }
        [JsonProperty("action_ability_condition")] public float? ActionAbilityCondition { get; set; }
        [JsonProperty("action_ability_type")] public float? ActionAbilityType { get; set; }
        [JsonProperty("action_ability_amount")] public float? ActionAbilityAmount { get; set; }
        [JsonProperty("action_penalty_type")] public float? ActionPenaltyType { get; set; }
        [JsonProperty("action_penalty_amount")] public float? ActionPenaltyAmount { get; set; }


        [JsonProperty("traits_count")] public int TraitsCount { get; set; }

        /// <summary>
        /// NEEDS one hot encoding
        /// </summary>
        [JsonProperty("traits")] public string Traits { get; set; }

        /// <summary>
        /// NEEDS one hot encoding
        /// </summary>
        [JsonProperty("traits_hidden")] public string TraitsHidden { get; set; }
    }
}
