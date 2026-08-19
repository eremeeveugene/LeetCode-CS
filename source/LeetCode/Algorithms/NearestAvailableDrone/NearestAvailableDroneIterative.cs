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

namespace LeetCode.Algorithms.NearestAvailableDrone;

/// <inheritdoc />
public sealed class NearestAvailableDroneIterative : INearestAvailableDrone
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NearestDrone(int[][] drones, int[] target)
    {
        var n = drones.Length;

        var tx = target[0];
        var ty = target[1];

        var nearestDrone = -1;
        var minimumManhattanDistance = int.MaxValue;

        for (var i = 0; i < n; i++)
        {
            var drone = drones[i];

            var x = drone[0];
            var y = drone[1];
            var range = drone[2];

            var manhattanDistance = Math.Abs(x - tx) + Math.Abs(y - ty);

            if (manhattanDistance > range || manhattanDistance >= minimumManhattanDistance)
            {
                continue;
            }

            minimumManhattanDistance = manhattanDistance;

            nearestDrone = i;
        }

        return nearestDrone;
    }
}