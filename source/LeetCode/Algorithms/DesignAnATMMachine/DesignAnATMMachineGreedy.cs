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

/// <inheritdoc />
public sealed class DesignAnATMMachineGreedy : IDesignAnATMMachine
{
    private const int BanknotesCount = 5;
    private static readonly int[] InvalidOperation = [-1];
    private readonly int[] _banknotes = [20, 50, 100, 200, 500];
    private readonly long[] _banknotesCounts = new long[BanknotesCount];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Deposit(int[] banknotesCounts)
    {
        for (var i = 0; i < 5; i++)
        {
            _banknotesCounts[i] += banknotesCounts[i];
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] Withdraw(int amount)
    {
        var used = new int[BanknotesCount];

        var remaining = amount;

        for (var i = used.Length - 1; i >= 0; i--)
        {
            var canTakeByAmount = remaining / _banknotes[i];
            var canTake = (int)Math.Min(_banknotesCounts[i], canTakeByAmount);

            used[i] = canTake;
            remaining -= used[i] * _banknotes[i];
        }

        if (remaining != 0)
        {
            return InvalidOperation;
        }

        for (var i = 0; i < BanknotesCount; i++)
        {
            _banknotesCounts[i] -= used[i];
        }

        return used;
    }
}