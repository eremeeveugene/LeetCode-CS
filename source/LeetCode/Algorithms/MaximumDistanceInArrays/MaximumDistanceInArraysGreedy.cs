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

        var min = int.MaxValue;
        var max = int.MinValue;

        for (var i = 0; i < arrays.Count; i++)
        {
            var array = arrays[i];
            var currentMin = array[0];
            var currentMax = array[^1];

            if (i > 0)
            {
                maxDistance = Math.Max(maxDistance, Math.Abs(currentMax - min));
                maxDistance = Math.Max(maxDistance, Math.Abs(max - currentMin));
            }

            min = Math.Min(min, currentMin);
            max = Math.Max(max, currentMax);
        }

        return maxDistance;
    }
}