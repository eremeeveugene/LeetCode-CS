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
public sealed class LongestNiceSubarrayBruteForce : ILongestNiceSubarray
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int LongestNiceSubarray(int[] nums)
    {
        var maxLength = 0;

        for (var left = 0; left < nums.Length - maxLength; left++)
        {
            var currentLength = 0;
            var usedBits = nums[left];

            for (var right = left + 1; right < nums.Length; right++)
            {
                if ((usedBits & nums[right]) == 0)
                {
                    usedBits |= nums[right];

                    currentLength++;
                }
                else
                {
                    break;
                }
            }

            maxLength = Math.Max(maxLength, currentLength);
        }

        return maxLength + 1;
    }
}