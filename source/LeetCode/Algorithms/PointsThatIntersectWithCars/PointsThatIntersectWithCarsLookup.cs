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

namespace LeetCode.Algorithms.PointsThatIntersectWithCars;

/// <inheritdoc />
public sealed class PointsThatIntersectWithCarsLookup : IPointsThatIntersectWithCars
{
    /// <summary>
    ///     Time complexity - O(n * R), where n is the length of nums and R = max(end) - min(start) + 1
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int NumberOfPoints(IList<IList<int>> nums)
    {
        Span<bool> lookup = stackalloc bool[100];

        for (var i = 0; i < nums.Count; i++)
        {
            var num = nums[i];
            var start = num[0];
            var end = num[1];

            for (var j = start; j <= end; j++)
            {
                lookup[j - 1] = true;
            }
        }

        var result = 0;

        for (var i = 0; i < lookup.Length; i++)
        {
            if (lookup[i])
            {
                result++;
            }
        }

        return result;
    }
}