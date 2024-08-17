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
public class MaximumDistanceInArraysBruteForce : IMaximumDistanceInArrays
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arrays"></param>
    /// <returns></returns>
    public int MaxDistance(IList<IList<int>> arrays)
    {
        var maxDistance = 0;

        for (var i = 0; i < arrays.Count - 1; i++)
        {
            var array = arrays[i];

            for (var j = i + 1; j < arrays.Count; j++)
            {
                maxDistance = Math.Max(maxDistance, Math.Abs(array[0] - arrays[j][arrays[j].Count - 1]));
                maxDistance = Math.Max(maxDistance, Math.Abs(array[^1] - arrays[j][0]));
            }
        }

        return maxDistance;
    }
}