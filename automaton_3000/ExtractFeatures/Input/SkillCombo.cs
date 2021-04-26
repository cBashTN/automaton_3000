using System;

namespace ExtractFeatures.Input
{
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
        Command     = 1,
        Diplomacy   = 2,
        Engineering = 4,
        Medicine    = 8,
        Science     = 16,
        Security    = 32
    }
}