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

namespace LeetCode.Algorithms.TwoKeysKeyboard;

/// <summary>
///     https://leetcode.com/problems/2-keys-keyboard/
/// </summary>
public interface ITwoKeysKeyboard
{
    /// <summary>
    ///     Computes the minimum number of "Copy All" and "Paste" operations, starting from a single character,
    ///     needed to produce exactly <paramref name="n" /> characters.
    /// </summary>
    /// <param name="n">The target number of characters to produce.</param>
    /// <returns>The minimum number of operations required to reach <paramref name="n" /> characters.</returns>
    int MinSteps(int n);
}