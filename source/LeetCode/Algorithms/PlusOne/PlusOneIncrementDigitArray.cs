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
///     Plus One
///     https://leetcode.com/problems/plus-one/
///     You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the
///     integer.
///     The digits are ordered from most significant to least significant in left-to-right order.
///     The large integer does not contain any leading 0's.
///     Increment the large integer by one and return the resulting array of digits.
///     Example 1:
///     Input: digits = [1,2,3]
///     Output: [1,2,4]
///     Explanation: The array represents the integer 123.
///     Incrementing by one gives 123 + 1 = 124.
///     Thus, the result should be [1,2,4].
///     Example 2:
///     Input: digits = [4,3,2,1]
///     Output: [4,3,2,2]
///     Explanation: The array represents the integer 4321.
///     Incrementing by one gives 4321 + 1 = 4322.
///     Thus, the result should be [4,3,2,2].
///     Example 3:
///     Input: digits = [9]
///     Output: [1,0]
///     Explanation: The array represents the integer 9.
///     Incrementing by one gives 9 + 1 = 10.
///     Thus, the result should be [1,0].
///     Constraints:
///     1 less than or equal to digits.length less than or equal to 100
///     0 less than or equal to digits[i] less than or equal to 9
///     digits does not contain any leading 0's.
/// </summary>
public static class PlusOneIncrementDigitArray
{
    /// <summary>
    ///     Time complexity - O (n)
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public static int[] GetResult(int[] digits)
    {
        var carryDigit = 0;

        digits[^1] += 1;

        for (var index = digits.Length - 1; index >= 0; index--)
            if (digits[index] + carryDigit > 9)
            {
                digits[index] = 0;
                carryDigit    = 1;
            }
            else
            {
                digits[index] += carryDigit;
                carryDigit    =  0;
                break;
            }

        if (carryDigit > 0)
            return new[]
            {
                carryDigit
            }.Concat(digits).ToArray();
        return digits;
    }
}