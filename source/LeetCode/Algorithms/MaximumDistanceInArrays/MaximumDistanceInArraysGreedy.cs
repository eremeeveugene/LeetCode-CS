// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MaximumDistanceInArrays;

/// <inheritdoc />
public class MaximumDistanceInArraysGreedy : IMaximumDistanceInArrays
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arrays"></param>
    /// <returns></returns>
    public int MaxDistance(IList<IList<int>> arrays)
    {
        var maxDistance = 0;

        var max = arrays[0][arrays[0].Count - 1];
        var min = arrays[0][0];

        for (var i = 1; i < arrays.Count; i++)
        {
            var currentMin = arrays[i][0];
            var currentMax = arrays[i][^1];

            maxDistance = Math.Max(maxDistance, Math.Abs(currentMax - min));
            maxDistance = Math.Max(maxDistance, Math.Abs(max - currentMin));

            min = Math.Min(min, currentMin);
            max = Math.Max(max, currentMax);
        }

        return maxDistance;
    }
}