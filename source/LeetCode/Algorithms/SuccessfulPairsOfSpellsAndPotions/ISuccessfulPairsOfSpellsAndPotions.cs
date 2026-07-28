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

/// <summary>
///     https://leetcode.com/problems/successful-pairs-of-spells-and-potions/description/
/// </summary>
public interface ISuccessfulPairsOfSpellsAndPotions
{
    /// <summary>
    ///     Counts, for every spell, how many potions form a successful pair with it. A pair is successful when the product of
    ///     the spell's strength and the potion's strength is at least <paramref name="success" />.
    /// </summary>
    /// <param name="spells">The strengths of the available spells.</param>
    /// <param name="potions">The strengths of the available potions.</param>
    /// <param name="success">The minimum product a spell-potion pair must reach to be successful.</param>
    /// <returns>An array where each element is the number of potions that form a successful pair with the matching spell.</returns>
    int[] SuccessfulPairs(int[] spells, int[] potions, long success);
}