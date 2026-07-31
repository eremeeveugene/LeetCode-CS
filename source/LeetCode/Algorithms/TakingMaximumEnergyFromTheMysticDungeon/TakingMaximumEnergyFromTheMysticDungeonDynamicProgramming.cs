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

/// <inheritdoc />
public sealed class TakingMaximumEnergyFromTheMysticDungeonDynamicProgramming : ITakingMaximumEnergyFromTheMysticDungeon
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of energies
    ///     Space complexity - O(n)
    /// </remarks>
    public int MaximumEnergy(int[] energies, int k)
    {
        var n = energies.Length;

        Span<int> totalEnergy = stackalloc int[n];

        var maximumEnergy = int.MinValue;

        for (var i = n - 1; i >= 0; i--)
        {
            var energy = energies[i];
            var nextIndex = i + k;
            var nextTotalEnergy = nextIndex < n ? totalEnergy[nextIndex] : 0;

            var currentTotalEnergy = energy + nextTotalEnergy;

            totalEnergy[i] = currentTotalEnergy;

            maximumEnergy = Math.Max(maximumEnergy, currentTotalEnergy);
        }

        return maximumEnergy;
    }
}