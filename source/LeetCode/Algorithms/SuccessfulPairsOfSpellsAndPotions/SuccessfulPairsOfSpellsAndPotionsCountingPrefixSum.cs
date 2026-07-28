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
public sealed class SuccessfulPairsOfSpellsAndPotionsCountingPrefixSum : ISuccessfulPairsOfSpellsAndPotions
{
    private const int Limit = 100001;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m + s), where n is the number of spells, m is the number of potions and s is the maximum
    ///     spell strength
    ///     Space complexity - O(s)
    /// </remarks>
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Span<int> counts = stackalloc int[Limit];

        var m = potions.Length;

        for (var i = 0; i < m; i++)
        {
            var potion = potions[i];

            var neededSpell = success / potion;

            if (success % potion != 0)
            {
                neededSpell++;
            }

            if (neededSpell < Limit)
            {
                counts[(int)neededSpell]++;
            }
        }

        for (var i = 1; i < Limit; i++)
        {
            counts[i] += counts[i - 1];
        }

        var n = spells.Length;

        var result = new int[n];

        for (var i = 0; i < n; i++)
        {
            var spell = spells[i];

            result[i] = counts[spell];
        }

        return result;
    }
}