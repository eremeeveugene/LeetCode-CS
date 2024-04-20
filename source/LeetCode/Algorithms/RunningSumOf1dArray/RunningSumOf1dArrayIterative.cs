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

namespace LeetCode.Algorithms.RunningSumOf1dArray;

/// <inheritdoc />
public class RunningSumOf1dArrayIterative : IRunningSumOf1dArray
{
    public int[] RunningSum(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return nums;
        }

        for (var i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        return nums;
    }
}