// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.LongestSubarrayOfOnesAfterDeletingOneElement;

/// <inheritdoc />
public class LongestSubarrayOfOnesAfterDeletingOneElementCounting : ILongestSubarrayOf1AfterDeletingOneElement
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int LongestSubarray(int[] nums)
    {
        var maxLength = 0;

        var currentLength = 0;
        var previousLength = 0;

        foreach (var num in nums)
        {
            if (num == 0)
            {
                maxLength = Math.Max(maxLength, previousLength + currentLength);

                previousLength = currentLength;
                currentLength = 0;
            }
            else
            {
                currentLength++;
            }
        }

        maxLength = Math.Max(maxLength, previousLength + currentLength);

        if (maxLength == nums.Length)
        {
            return nums.Length - 1;
        }

        return maxLength;
    }
}