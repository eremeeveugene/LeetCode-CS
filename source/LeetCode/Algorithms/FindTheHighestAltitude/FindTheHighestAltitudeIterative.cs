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

namespace LeetCode.Algorithms.FindTheHighestAltitude;

/// <inheritdoc />
public sealed class FindTheHighestAltitudeIterative : IFindTheHighestAltitude
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int LargestAltitude(int[] gains)
    {
        var altitude = 0;
        var maxAltitude = 0;

        for (var i = 0; i < gains.Length; i++)
        {
            var gain = gains[i];

            altitude += gain;

            maxAltitude = Math.Max(maxAltitude, altitude);
        }

        return maxAltitude;
    }
}