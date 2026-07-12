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

namespace LeetCode.Algorithms.LongestStrictlyIncreasingOrStrictlyDecreasingSubarray;

/// <inheritdoc />
public sealed class LongestStrictlyIncreasingOrStrictlyDecreasingSubarrayIterative : ILongestStrictlyIncreasingOrStrictlyDecreasingSubarray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int LongestMonotonicSubarray(int[] nums)
    {
        var increasingLength = 1;
        var decreasingLength = 1;
        var maxLength = 1;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                decreasingLength++;
                increasingLength = 1;
            }
            else if (nums[i] < nums[i + 1])
            {
                increasingLength++;
                decreasingLength = 1;
            }
            else
            {
                increasingLength = 1;
                decreasingLength = 1;
            }

            maxLength = Math.Max(maxLength, Math.Max(increasingLength, decreasingLength));
        }

        return maxLength;
    }
}