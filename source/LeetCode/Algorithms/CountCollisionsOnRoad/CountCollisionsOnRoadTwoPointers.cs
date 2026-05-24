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

namespace LeetCode.Algorithms.CountCollisionsOnRoad;

/// <inheritdoc />
public sealed class CountCollisionsOnRoadTwoPointers : ICountCollisionsOnRoad
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountCollisions(string directions)
    {
        var n = directions.Length;

        var left = 0;
        var right = n - 1;

        while (left < n && directions[left] == 'L')
        {
            left++;
        }

        while (right >= left && directions[right] == 'R')
        {
            right--;
        }

        var collisions = 0;

        for (var i = left; i <= right; i++)
        {
            if (directions[i] != 'S')
            {
                collisions++;
            }
        }

        return collisions;
    }
}