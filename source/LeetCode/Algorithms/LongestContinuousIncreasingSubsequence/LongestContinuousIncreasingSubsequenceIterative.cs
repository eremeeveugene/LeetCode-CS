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

namespace LeetCode.Algorithms.LongestContinuousIncreasingSubsequence;

/// <inheritdoc />
public sealed class LongestContinuousIncreasingSubsequenceIterative : ILongestContinuousIncreasingSubsequence
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FindLengthOfLCIS(int[] nums)
    {
        var n = nums.Length;

        var currentLength = 1;
        var longestLength = 1;

        for (var i = 1; i < n; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;
            }

            longestLength = Math.Max(longestLength, currentLength);
        }

        return longestLength;
    }
}