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

namespace LeetCode.Algorithms.CountValidSubstringsI;

/// <summary>
///     https://leetcode.com/problems/count-valid-substrings-i/description/
/// </summary>
public interface ICountValidSubstringsI
{
    /// <summary>
    ///     Counts the substrings of <paramref name="s" /> that do not contain "abc" as a substring.
    /// </summary>
    /// <param name="s">The string consisting only of the characters 'a', 'b' and 'c'.</param>
    /// <returns>The number of valid substrings, counting substrings with different start or end indices separately.</returns>
    long CountValidSubstrings(string s);
}