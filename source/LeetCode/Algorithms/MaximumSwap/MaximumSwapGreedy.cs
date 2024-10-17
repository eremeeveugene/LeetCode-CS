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

namespace LeetCode.Algorithms.MaximumSwap;

/// <inheritdoc />
public class MaximumSwapGreedy : IMaximumSwap
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int MaximumSwap(int num)
    {
        var digits = num.ToString().ToCharArray();

        var last = new int[10];

        for (var i = 0; i < digits.Length; i++)
        {
            last[digits[i] - '0'] = i;
        }

        for (var i = 0; i < digits.Length; i++)
        {
            for (var d = 9; d > digits[i] - '0'; d--)
            {
                if (last[d] <= i)
                {
                    continue;
                }

                (digits[i], digits[last[d]]) = (digits[last[d]], digits[i]);

                return int.Parse(new string(digits));
            }
        }

        return num;
    }
}