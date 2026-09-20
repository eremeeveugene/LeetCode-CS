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

namespace LeetCode.Algorithms.MaximumManhattanDistanceAfterKChanges;

/// <inheritdoc />
public sealed class MaximumManhattanDistanceAfterKChangesGreedy : IMaximumManhattanDistanceAfterKChanges
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxDistance(string s, int k)
    {
        var n = s.Length;

        var x = 0;
        var y = 0;

        var maximumDistanceGain = k * 2;

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            var direction = s[i];

            switch (direction)
            {
                case 'N':
                    y++;
                    break;
                case 'S':
                    y--;
                    break;
                case 'E':
                    x++;
                    break;
                default:
                    x--;
                    break;
            }

            var distance = Math.Abs(x) + Math.Abs(y);
            var distanceLimit = i + 1;
            var potentialDistanceAfterChanges = distance + maximumDistanceGain;
            var maximumDistance = Math.Min(distanceLimit, potentialDistanceAfterChanges);

            result = Math.Max(result, maximumDistance);
        }

        return result;
    }
}