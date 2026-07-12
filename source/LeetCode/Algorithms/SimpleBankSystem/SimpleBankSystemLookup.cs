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

/// <inheritdoc />
public sealed class SimpleBankSystemLookup : ISimpleBankSystem
{
    private readonly long[] _balance;
    private readonly int _balanceLength;

    /// <summary>
    ///     Initializes a new instance of the <see cref="SimpleBankSystemLookup" /> class.
    /// </summary>
    /// <param name="balance">The initial balance of each account, where account i has balance[i - 1].</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </remarks>
    public SimpleBankSystemLookup(long[] balance)
    {
        _balance = balance;
        _balanceLength = balance.Length;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool Transfer(int account1, int account2, long money)
    {
        if (account1 > _balanceLength || account2 > _balanceLength)
        {
            return false;
        }

        var balance1Index = account1 - 1;
        var balance2Index = account2 - 1;

        if (_balance[balance1Index] < money)
        {
            return false;
        }

        _balance[balance1Index] -= money;
        _balance[balance2Index] += money;

        return true;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool Deposit(int account, long money)
    {
        if (account > _balanceLength)
        {
            return false;
        }

        var balanceIndex = account - 1;

        _balance[balanceIndex] += money;

        return true;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool Withdraw(int account, long money)
    {
        if (account > _balanceLength)
        {
            return false;
        }

        var balanceIndex = account - 1;

        if (_balance[balanceIndex] < money)
        {
            return false;
        }

        _balance[balanceIndex] -= money;

        return true;
    }
}