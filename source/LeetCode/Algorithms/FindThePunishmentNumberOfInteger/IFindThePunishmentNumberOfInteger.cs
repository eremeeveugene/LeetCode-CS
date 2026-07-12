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

namespace LeetCode.Algorithms.FindThePunishmentNumberOfInteger;

/// <summary>
///     https://leetcode.com/problems/find-the-punishment-number-of-an-integer/
/// </summary>
public interface IFindThePunishmentNumberOfInteger
{
    /// <summary>
    ///     Computes the punishment number of <paramref name="n" />, which is the sum of the squares of all integers i in
    ///     the range [1, <paramref name="n" />] whose squared decimal representation can be partitioned into contiguous
    ///     substrings summing to i.
    /// </summary>
    /// <param name="n">The upper bound of the range of integers to consider.</param>
    /// <returns>The punishment number of <paramref name="n" />.</returns>
    int PunishmentNumber(int n);
}