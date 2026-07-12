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

namespace LeetCode.Algorithms.Maximum69Number;

/// <summary>
///     https://leetcode.com/problems/maximum-69-number/
/// </summary>
public interface IMaximum69Number
{
    /// <summary>
    ///     Changes at most one digit of <paramref name="num" /> (which consists only of digits 6 and 9) from 6 to 9 to
    ///     maximize its value.
    /// </summary>
    /// <param name="num">The integer, composed only of the digits 6 and 9, to maximize.</param>
    /// <returns>The maximum possible value obtainable by changing at most one digit of <paramref name="num" />.</returns>
    int Maximum69Number(int num);
}