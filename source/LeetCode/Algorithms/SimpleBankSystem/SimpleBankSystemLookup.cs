// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class SimpleBankSystemLookup : ISimpleBankSystem
{
    private readonly long[] _balance;
    private readonly int _balanceLength;

    public SimpleBankSystemLookup(long[] balance)
    {
        _balance = balance;
        _balanceLength = balance.Length;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="account1"></param>
    /// <param name="account2"></param>
    /// <param name="money"></param>
    /// <returns></returns>
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

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="account"></param>
    /// <param name="money"></param>
    /// <returns></returns>
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

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="account"></param>
    /// <param name="money"></param>
    /// <returns></returns>
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