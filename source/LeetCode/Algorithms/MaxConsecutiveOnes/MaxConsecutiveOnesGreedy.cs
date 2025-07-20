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

namespace LeetCode.Algorithms.MaxConsecutiveOnes;

/// <inheritdoc />
public class MaxConsecutiveOnesGreedy : IMaxConsecutiveOnes
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var maxLength = 0;

        var length = 0;

        foreach (var num in nums)
        {
            if (num == 1)
            {
                length++;
            }
            else
            {
                maxLength = Math.Max(maxLength, length);

                length = 0;
            }
        }

        return Math.Max(maxLength, length);
    }
}