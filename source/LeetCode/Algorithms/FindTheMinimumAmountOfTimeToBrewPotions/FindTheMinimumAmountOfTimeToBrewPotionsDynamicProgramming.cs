// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindTheMinimumAmountOfTimeToBrewPotions;

/// <inheritdoc />
public class FindTheMinimumAmountOfTimeToBrewPotionsDynamicProgramming : IFindTheMinimumAmountOfTimeToBrewPotions
{
    /// <summary>
    ///     Time complexity - O(n * m), where n is the length of wizardSkills and m is the length of potionMana
    ///     Space complexity - O(n), where n is the length of wizardSkills
    /// </summary>
    /// <param name="wizardSkills"></param>
    /// <param name="potionMana"></param>
    /// <returns></returns>
    public long MinTime(int[] wizardSkills, int[] potionMana)
    {
        var wizardCount = wizardSkills.Length;
        var potionCount = potionMana.Length;

        Span<long> prefixSkillSum = stackalloc long[wizardCount];

        for (var i = 1; i < wizardCount; i++)
        {
            prefixSkillSum[i] = prefixSkillSum[i - 1] + wizardSkills[i];
        }

        var totalTime = (long)wizardSkills[0] * potionMana[0];

        for (var potionIndex = 1; potionIndex < potionCount; potionIndex++)
        {
            long previousMana = potionMana[potionIndex - 1];
            long currentMana = potionMana[potionIndex];

            var potionCompletionTime = wizardSkills[0] * currentMana;

            for (var wizardIndex = 1; wizardIndex < wizardCount; wizardIndex++)
            {
                var totalPrevSkills = prefixSkillSum[wizardIndex];
                var totalPrevSkillsExcludingCurrent = prefixSkillSum[wizardIndex - 1];

                var wizardDelay = (totalPrevSkills * previousMana) - (totalPrevSkillsExcludingCurrent * currentMana);

                potionCompletionTime = long.Max(potionCompletionTime, wizardDelay);
            }

            totalTime += potionCompletionTime;
        }

        totalTime += prefixSkillSum[wizardCount - 1] * potionMana[potionCount - 1];

        return totalTime;
    }
}