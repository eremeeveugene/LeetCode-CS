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

namespace LeetCode.Algorithms.SubtractTheProductAndSumOfDigitsOfAnInteger;

/// <inheritdoc />
public class SubtractTheProductAndSumOfDigitsOfAnIntegerString : ISubtractTheProductAndSumOfDigitsOfAnInteger
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int SubtractProductAndSum(int n)
    {
        var productOfDigits = 1;
        var sumOfDigits = 0;

        foreach (var numericValue in n.ToString().Select(c => (int)char.GetNumericValue(c)))
        {
            productOfDigits *= numericValue;
            sumOfDigits += numericValue;
        }

        return productOfDigits - sumOfDigits;
    }
}