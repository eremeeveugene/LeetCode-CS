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

namespace LeetCode.Algorithms.IntersectionOfMultipleArrays;

/// <inheritdoc />
public sealed class IntersectionOfMultipleArraysCounting : IIntersectionOfMultipleArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m), where n is the number of arrays in nums and m is the length of arrays in nums
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<int> Intersection(int[][] nums)
    {
        Span<int> numsFrequencies = stackalloc int[1001];

        for (var i = 0; i < nums.Length; i++)
        {
            var row = nums[i];

            for (var j = 0; j < row.Length; j++)
            {
                var cell = row[j];

                numsFrequencies[cell]++;
            }
        }

        var result = new List<int>();

        for (var i = 0; i < numsFrequencies.Length; i++)
        {
            var numsFrequency = numsFrequencies[i];

            if (numsFrequency == nums.Length)
            {
                result.Add(i);
            }
        }

        return result;
    }
}