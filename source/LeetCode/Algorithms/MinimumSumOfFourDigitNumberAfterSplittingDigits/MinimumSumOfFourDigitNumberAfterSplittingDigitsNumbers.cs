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

namespace LeetCode.Algorithms.MinimumSumOfFourDigitNumberAfterSplittingDigits;

/// <inheritdoc />
public class MinimumSumOfFourDigitNumberAfterSplittingDigitsNumbers : IMinimumSumOfFourDigitNumberAfterSplittingDigits
{
    /// <summary>
    ///     Time complexity - O(1)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int MinimumSum(int num)
    {
        var digits = new int[4];

        for (var i = 0; i < 4; i++)
        {
            digits[i] = num % 10;

            num /= 10;
        }

        Array.Sort(digits);

        return (digits[0] * 10) + (digits[1] * 10) + digits[2] + digits[3];
    }
}