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

/// <summary>
///     https://leetcode.com/problems/simple-bank-system/description/
/// </summary>
public interface ISimpleBankSystem
{
    bool Transfer(int account1, int account2, long money);
    bool Deposit(int account, long money);
    bool Withdraw(int account, long money);
}