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

namespace LeetCode.Algorithms.DesignAnATMMachine;

/// <summary>
///     https://leetcode.com/problems/design-an-atm-machine/description/
/// </summary>
public interface IDesignAnATMMachine
{
    /// <summary>
    ///     Deposits the given counts of banknotes of denominations $20, $50, $100, $200 and $500 into the ATM machine.
    /// </summary>
    /// <param name="banknotesCounts">The counts of banknotes to deposit, ordered by denomination.</param>
    void Deposit(int[] banknotesCounts);

    /// <summary>
    ///     Withdraws <paramref name="amount" /> of money from the ATM machine, using the largest denominations first.
    /// </summary>
    /// <param name="amount">The amount of money to withdraw.</param>
    /// <returns>
    ///     The counts of banknotes of each denomination handed out, or <c>[-1]</c> if the amount cannot be withdrawn.
    /// </returns>
    int[] Withdraw(int amount);
}