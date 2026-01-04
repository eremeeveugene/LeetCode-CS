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

namespace LeetCode.Algorithms.SumOfGoodNumbers;

/// <inheritdoc />
public class SumOfGoodNumbersIterative : ISumOfGoodNumbers
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int SumOfGoodNumbers(int[] nums, int k)
    {
        var sum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var left = int.MinValue;

            if (i - k >= 0)
            {
                left = nums[i - k];
            }

            var right = int.MinValue;

            if (i + k < nums.Length)
            {
                right = nums[i + k];
            }

            if (nums[i] > left && nums[i] > right)
            {
                sum += nums[i];
            }
        }

        return sum;
    }
}