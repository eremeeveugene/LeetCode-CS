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

namespace LeetCode.Algorithms.PlusOne;

/// <inheritdoc />
public class PlusOneIncrementDigitArray : IPlusOne
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public int[] PlusOne(int[] digits)
    {
        var carryDigit = 0;

        digits[^1] += 1;

        for (var index = digits.Length - 1; index >= 0; index--)
        {
            if (digits[index] + carryDigit > 9)
            {
                digits[index] = 0;
                carryDigit = 1;
            }
            else
            {
                digits[index] += carryDigit;
                carryDigit = 0;
                break;
            }
        }

        return carryDigit > 0 ? digits.Prepend(carryDigit).ToArray() : digits;
    }
}