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

namespace LeetCode.Algorithms.SmallestIndexWithDigitSumEqualToIndex;

/// <inheritdoc />
public sealed class SmallestIndexWithDigitSumEqualToIndexBruteForce : ISmallestIndexWithDigitSumEqualToIndex
{
    /// <summary>
    ///     Time complexity - O(n * d)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SmallestIndex(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var digitSum = 0;

            var num = nums[i];

            while (num > 0)
            {
                digitSum += num % 10;

                num /= 10;
            }

            if (i == digitSum)
            {
                return i;
            }
        }

        return -1;
    }
}