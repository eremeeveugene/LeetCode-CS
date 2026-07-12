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

namespace LeetCode.Algorithms.SimpleBankSystem;

/// <summary>
///     https://leetcode.com/problems/simple-bank-system/description/
/// </summary>
public interface ISimpleBankSystem
{
    /// <summary>
    ///     Transfers <paramref name="money" /> from <paramref name="account1" /> to <paramref name="account2" />
    ///     if both accounts are valid and <paramref name="account1" /> has sufficient balance.
    /// </summary>
    /// <param name="account1">The 1-indexed account number to withdraw from.</param>
    /// <param name="account2">The 1-indexed account number to deposit into.</param>
    /// <param name="money">The amount of money to transfer.</param>
    /// <returns><see langword="true" /> if the transfer succeeds; otherwise, <see langword="false" />.</returns>
    bool Transfer(int account1, int account2, long money);

    /// <summary>
    ///     Deposits <paramref name="money" /> into <paramref name="account" /> if the account is valid.
    /// </summary>
    /// <param name="account">The 1-indexed account number to deposit into.</param>
    /// <param name="money">The amount of money to deposit.</param>
    /// <returns><see langword="true" /> if the deposit succeeds; otherwise, <see langword="false" />.</returns>
    bool Deposit(int account, long money);

    /// <summary>
    ///     Withdraws <paramref name="money" /> from <paramref name="account" /> if the account is valid and has
    ///     sufficient balance.
    /// </summary>
    /// <param name="account">The 1-indexed account number to withdraw from.</param>
    /// <param name="money">The amount of money to withdraw.</param>
    /// <returns><see langword="true" /> if the withdrawal succeeds; otherwise, <see langword="false" />.</returns>
    bool Withdraw(int account, long money);
}