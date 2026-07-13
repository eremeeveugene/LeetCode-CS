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

namespace LeetCode.Algorithms.SequentialDigits;

/// <summary>
///     https://leetcode.com/problems/sequential-digits/description/
/// </summary>
public interface ISequentialDigits
{
    /// <summary>
    ///     Finds all integers in the range [<paramref name="low" />, <paramref name="high" />] that have sequential digits,
    ///     where each digit is one more than the previous digit.
    /// </summary>
    /// <param name="low">The lower bound of the range, inclusive.</param>
    /// <param name="high">The upper bound of the range, inclusive.</param>
    /// <returns>A sorted list of all integers in the range that have sequential digits.</returns>
    IList<int> SequentialDigits(int low, int high);
}