﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MissingNumber;

/// <inheritdoc />
public class MissingNumberIterativeSumAndSubtract : IMissingNumber
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MissingNumber(int[] nums)
    {
        var sum = nums.Sum();

        for (var i = 0; i < nums.Length + 1; i++)
        {
            sum -= i;
        }

        return -sum;
    }
}