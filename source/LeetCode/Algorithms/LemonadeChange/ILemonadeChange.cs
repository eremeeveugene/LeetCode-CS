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

namespace LeetCode.Algorithms.LemonadeChange;

/// <summary>
///     https://leetcode.com/problems/lemonade-change/
/// </summary>
public interface ILemonadeChange
{
    /// <summary>
    ///     Determines whether every customer, paying in the order given by <paramref name="bills" />, can be given correct change for a $5 lemonade using
    ///     only $5, $10, and $20 bills received so far.
    /// </summary>
    /// <param name="bills">The array of bills, in order, that customers use to pay.</param>
    /// <returns><see langword="true" /> if every customer can be given correct change; otherwise, <see langword="false" />.</returns>
    bool LemonadeChange(int[] bills);
}