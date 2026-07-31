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
public sealed class TakingMaximumEnergyFromTheMysticDungeonBruteForce : ITakingMaximumEnergyFromTheMysticDungeon
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2 / k), where n is the length of energies
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaximumEnergy(int[] energies, int k)
    {
        var n = energies.Length;

        var maximumEnergy = int.MinValue;

        for (var i = 0; i < n; i++)
        {
            var totalEnergy = 0;

            for (var j = i; j < n; j += k)
            {
                var energy = energies[j];

                totalEnergy += energy;
            }

            maximumEnergy = Math.Max(maximumEnergy, totalEnergy);
        }

        return maximumEnergy;
    }
}