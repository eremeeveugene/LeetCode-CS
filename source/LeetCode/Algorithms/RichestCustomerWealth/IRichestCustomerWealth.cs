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

namespace LeetCode.Algorithms.RichestCustomerWealth;

/// <summary>
///     https://leetcode.com/problems/richest-customer-wealth/
/// </summary>
public interface IRichestCustomerWealth
{
    /// <summary>
    ///     Determines the maximum wealth among the customers described by <paramref name="accounts" />, where each
    ///     customer's wealth is the sum of the balances in their bank accounts.
    /// </summary>
    /// <param name="accounts">A grid where each row lists a customer's account balances.</param>
    /// <returns>The wealth of the richest customer.</returns>
    int MaximumWealth(int[][] accounts);
}