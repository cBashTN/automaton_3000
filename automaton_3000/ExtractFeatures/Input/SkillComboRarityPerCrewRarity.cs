namespace ExtractFeatures.Input
{
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