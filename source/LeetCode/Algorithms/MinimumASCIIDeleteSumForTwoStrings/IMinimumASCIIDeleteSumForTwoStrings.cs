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

namespace LeetCode.Algorithms.MinimumASCIIDeleteSumForTwoStrings;

/// <summary>
///     https://leetcode.com/problems/minimum-ascii-delete-sum-for-two-strings/description/
/// </summary>
public interface IMinimumASCIIDeleteSumForTwoStrings
{
    /// <summary>
    ///     Finds the minimum sum of ASCII values of the characters that must be deleted from <paramref name="s1" />
    ///     and <paramref name="s2" /> to make the two strings equal.
    /// </summary>
    /// <param name="s1">The first string.</param>
    /// <param name="s2">The second string.</param>
    /// <returns>The minimum sum of ASCII values of deleted characters required to equalize the two strings.</returns>
    int MinimumDeleteSum(string s1, string s2);
}