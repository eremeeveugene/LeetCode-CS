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

namespace LeetCode.Algorithms.LongestNiceSubarray;

/// <inheritdoc />
public class LongestNiceSubarraySlidingWindow : ILongestNiceSubarray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int LongestNiceSubarray(int[] nums)
    {
        var maxLength = 0;
        var left = 0;
        var mask = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            while ((mask & nums[right]) != 0)
            {
                mask ^= nums[left];

                left++;
            }

            mask |= nums[right];

            maxLength = Math.Max(maxLength, right - left);
        }

        return maxLength + 1;
    }
}