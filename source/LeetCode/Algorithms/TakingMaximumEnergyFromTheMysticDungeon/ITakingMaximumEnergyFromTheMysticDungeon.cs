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

namespace LeetCode.Algorithms.TakingMaximumEnergyFromTheMysticDungeon;

/// <summary>
///     https://leetcode.com/problems/taking-maximum-energy-from-the-mystic-dungeon/description/
/// </summary>
public interface ITakingMaximumEnergyFromTheMysticDungeon
{
    /// <summary>
    ///     Determines the maximum amount of energy that can be gained by starting at any magician in
    ///     <paramref name="energies" /> and repeatedly jumping <paramref name="k" /> positions forward, gaining the
    ///     energy of every magician visited, until the next jump would go out of bounds.
    /// </summary>
    /// <param name="energies">The array where <c>energy[i]</c> represents the energy the ith magician can give.</param>
    /// <param name="k">The number of positions advanced on each jump.</param>
    /// <returns>The maximum amount of energy that can be gained.</returns>
    int MaximumEnergy(int[] energies, int k);
}