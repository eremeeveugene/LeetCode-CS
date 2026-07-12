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

namespace LeetCode.Algorithms.CheckDivisibilityByDigitSumAndProduct;

/// <summary>
///     https://leetcode.com/problems/check-divisibility-by-digit-sum-and-product/description/
/// </summary>
public interface ICheckDivisibilityByDigitSumAndProduct
{
    /// <summary>
    ///     Determines whether <paramref name="n" /> is divisible by the sum of its digit sum and digit product.
    /// </summary>
    /// <param name="n">The number to check.</param>
    /// <returns>
    ///     <c>true</c> if <paramref name="n" /> is divisible by the sum of its digit sum and digit product; otherwise,
    ///     <c>false</c>.
    /// </returns>
    bool CheckDivisibility(int n);
}