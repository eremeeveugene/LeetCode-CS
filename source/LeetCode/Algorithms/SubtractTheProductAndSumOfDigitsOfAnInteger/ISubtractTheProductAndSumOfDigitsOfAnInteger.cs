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

/// <summary>
///     https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
/// </summary>
public interface ISubtractTheProductAndSumOfDigitsOfAnInteger
{
    /// <summary>
    ///     Computes the difference between the product of the digits of <paramref name="n" /> and the sum of
    ///     its digits.
    /// </summary>
    /// <param name="n">The non-negative integer whose digits are processed.</param>
    /// <returns>The product of the digits of <paramref name="n" /> minus the sum of its digits.</returns>
    int SubtractProductAndSum(int n);
}