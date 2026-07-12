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

namespace LeetCode.Algorithms.MaximumTotalDamageWithSpellCasting;

/// <summary>
///     https://leetcode.com/problems/maximum-total-damage-with-spell-casting/description/
/// </summary>
public interface IMaximumTotalDamageWithSpellCasting
{
    /// <summary>
    ///     Selects spells from <paramref name="power" /> to maximize total damage, given that casting a spell of
    ///     damage <c>x</c> forbids casting any spell of damage <c>x - 2</c>, <c>x - 1</c>, <c>x + 1</c>, or
    ///     <c>x + 2</c>.
    /// </summary>
    /// <param name="power">The array of damage values for each available spell.</param>
    /// <returns>The maximum total damage that can be dealt.</returns>
    long MaximumTotalDamage(int[] power);
}