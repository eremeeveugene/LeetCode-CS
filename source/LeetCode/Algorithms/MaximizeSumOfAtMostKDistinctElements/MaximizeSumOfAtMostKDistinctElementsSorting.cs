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

namespace LeetCode.Algorithms.MaximizeSumOfAtMostKDistinctElements;

/// <inheritdoc />
public sealed class MaximizeSumOfAtMostKDistinctElementsSorting : IMaximizeSumOfAtMostKDistinctElements
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n), where n is the length of nums array
    ///     Space complexity - O(k)
    /// </remarks>
    public int[] MaxKDistinct(int[] nums, int k)
    {
        Array.Sort(nums, (a, b) => b.CompareTo(a));

        Span<int> temp = stackalloc int[k];

        var count = 0;

        temp[count++] = nums[0];

        for (var i = 1; i < nums.Length && count < k; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                continue;
            }

            temp[count++] = nums[i];
        }

        var result = new int[count];

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = temp[i];
        }

        return result;
    }
}