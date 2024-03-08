using System;

namespace PlayerAchievements
{
    [Flags]
    public enum PlayerAchievements
    {
        DefeatOptionalBoss = 1 << 0,
        FindHiddenLevel  = 1 << 1,
        FinishGame  = 1 << 2
    }
}