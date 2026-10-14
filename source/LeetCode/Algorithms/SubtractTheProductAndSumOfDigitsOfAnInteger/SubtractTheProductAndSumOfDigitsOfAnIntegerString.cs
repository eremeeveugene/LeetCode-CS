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

namespace LeetCode.Algorithms.SubtractTheProductAndSumOfDigitsOfAnInteger;

/// <inheritdoc />
public sealed class SubtractTheProductAndSumOfDigitsOfAnIntegerString : ISubtractTheProductAndSumOfDigitsOfAnInteger
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(d), where d is the number of digits in the integer n
    ///     Space complexity - O(d), where d is the number of digits in the integer n
    /// </remarks>
    public int SubtractProductAndSum(int n)
    {
        var productOfDigits = 1;
        var sumOfDigits = 0;

        var digits = n.ToString();

        for (var i = 0; i < digits.Length; i++)
        {
            var numericValue = (int)char.GetNumericValue(digits[i]);

            productOfDigits *= numericValue;
            sumOfDigits += numericValue;
        }

        return productOfDigits - sumOfDigits;
    }
}