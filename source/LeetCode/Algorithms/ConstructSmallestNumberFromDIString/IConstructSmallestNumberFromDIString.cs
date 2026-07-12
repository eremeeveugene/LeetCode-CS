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

namespace LeetCode.Algorithms.ConstructSmallestNumberFromDIString;

/// <summary>
///     https://leetcode.com/problems/construct-smallest-number-from-di-string/description/
/// </summary>
public interface IConstructSmallestNumberFromDIString
{
    /// <summary>
    ///     Constructs the lexicographically smallest permutation of digits 1-9 (no repeats) that satisfies the
    ///     increasing/decreasing constraints encoded in <paramref name="pattern" />.
    /// </summary>
    /// <param name="pattern">The string of 'I' and 'D' characters describing the increase/decrease pattern.</param>
    /// <returns>The smallest numeric string that satisfies <paramref name="pattern" />.</returns>
    string SmallestNumber(string pattern);
}