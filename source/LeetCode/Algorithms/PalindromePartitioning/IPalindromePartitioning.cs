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

namespace LeetCode.Algorithms.PalindromePartitioning;

/// <summary>
///     https://leetcode.com/problems/palindrome-partitioning/
/// </summary>
public interface IPalindromePartitioning
{
    /// <summary>
    ///     Finds every way to partition <paramref name="s" /> into substrings such that each substring is a
    ///     palindrome.
    /// </summary>
    /// <param name="s">The string to partition into palindromic substrings.</param>
    /// <returns>A list of all possible palindrome partitions of <paramref name="s" />, each represented as a list of substrings.</returns>
    IList<IList<string>> Partition(string s);
}