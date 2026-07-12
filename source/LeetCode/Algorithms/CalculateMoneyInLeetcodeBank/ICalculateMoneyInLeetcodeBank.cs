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

namespace LeetCode.Algorithms.CalculateMoneyInLeetcodeBank;

/// <summary>
///     https://leetcode.com/problems/calculate-money-in-leetcode-bank/
/// </summary>
public interface ICalculateMoneyInLeetcodeBank
{
    /// <summary>
    ///     Computes the total amount of money in the LeetCode bank after <paramref name="n" /> days, where the deposit
    ///     starts at 1 dollar, increases by 1 each day and restarts at 1 more than the previous Monday every week.
    /// </summary>
    /// <param name="n">The number of days of deposits.</param>
    /// <returns>The total amount of money in the bank after <paramref name="n" /> days.</returns>
    int TotalMoney(int n);
}