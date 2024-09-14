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

namespace LeetCode.Algorithms.LongestSubarrayWithMaximumBitwiseAND;

/// <inheritdoc />
public class LongestSubarrayWithMaximumBitwiseANDIterative : ILongestSubarrayWithMaximumBitwiseAND
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int LongestSubarray(int[] nums)
    {
        var maxNum = 0;
        var maxLength = 0;
        var currentLength = 0;

        foreach (var num in nums)
        {
            if (num == maxNum)
            {
                currentLength++;
            }
            else if (num > maxNum)
            {
                maxNum = num;

                currentLength = 1;
                maxLength = 1;
            }
            else
            {
                currentLength = 0;
            }

            maxLength = Math.Max(maxLength, currentLength);
        }

        return maxLength;
    }
}