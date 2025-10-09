// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
    ///     Time complexity - O(n * m), where n is the length of skill and m is the length of mana
    ///     Space complexity - O(n), where n is the length of skill
    /// </summary>
    /// <param name="skill"></param>
    /// <param name="mana"></param>
    /// <returns></returns>
    public long MinTime(int[] skill, int[] mana)
    {
        var n = skill.Length;
        var m = mana.Length;

        Span<long> times = stackalloc long[n];

        for (var j = 0; j < m; j++)
        {
            long currentTime = 0;

            for (var i = 0; i < n; i++)
            {
                currentTime = Math.Max(currentTime, times[i]) + ((long)skill[i] * mana[j]);
            }

            times[n - 1] = currentTime;

            for (var i = n - 2; i >= 0; i--)
            {
                times[i] = times[i + 1] - ((long)skill[i + 1] * mana[j]);
            }
        }

        return times[n - 1];
    }
}