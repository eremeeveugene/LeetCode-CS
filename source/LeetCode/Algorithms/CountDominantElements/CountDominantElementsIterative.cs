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

namespace LeetCode.Algorithms.CountDominantElements;

/// <inheritdoc />
/// <remarks>
///     The two end elements have a single neighbor each and are checked directly, while every inner element is dominant
///     when twice its value is at least the sum of its two neighbors, which avoids a fractional average.
/// </remarks>
public sealed class CountDominantElementsIterative : ICountDominantElements
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountDominantElements(int[] nums)
    {
        var n = nums.Length;

        if (n == 1)
        {
            return 1;
        }

        var result = 0;

        if (nums[0] >= nums[1])
        {
            result++;
        }

        if (nums[^1] >= nums[^2])
        {
            result++;
        }

        for (var i = 1; i < n - 1; i++)
        {
            var num = nums[i];

            if (num * 2 < nums[i - 1] + nums[i + 1])
            {
                continue;
            }

            result++;
        }

        return result;
    }
}