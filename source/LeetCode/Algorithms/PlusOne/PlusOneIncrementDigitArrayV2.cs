// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.PlusOne;

/// <summary>
///     https://leetcode.com/problems/plus-one/
/// </summary>
public static class PlusOneIncrementDigitArrayV2
{
    /// <summary>
    ///     Time complexity - O (n)
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public static int[] GetResult(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }

        int[] newDigits = new int[digits.Length + 1];
        newDigits[0] = 1;
        return newDigits;
    }
}