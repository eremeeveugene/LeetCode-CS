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

namespace LeetCode.Algorithms.SuccessfulPairsOfSpellsAndPotions;

/// <inheritdoc />
public sealed class SuccessfulPairsOfSpellsAndPotionsSortingBinarySearch : ISuccessfulPairsOfSpellsAndPotions
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O((n + m) log m), where n is the number of spells and m is the number of potions
    ///     Space complexity - O(m)
    /// </remarks>
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);

        var n = spells.Length;

        var result = new int[n];

        var m = potions.Length;

        for (var i = 0; i < n; i++)
        {
            var spell = spells[i];

            if ((long)spell * potions[^1] < success)
            {
                continue;
            }

            var left = 0;
            var right = m - 1;

            while (left < right)
            {
                var middle = ((right - left) / 2) + left;

                var potion = potions[middle];

                if ((long)spell * potion < success)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }

            result[i] = m - left;
        }

        return result;
    }
}