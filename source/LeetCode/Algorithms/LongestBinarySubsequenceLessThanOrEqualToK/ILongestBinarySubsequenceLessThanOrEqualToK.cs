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

namespace LeetCode.Algorithms.LongestBinarySubsequenceLessThanOrEqualToK;

/// <summary>
///     https://leetcode.com/problems/longest-binary-subsequence-less-than-or-equal-to-k/description/
/// </summary>
public interface ILongestBinarySubsequenceLessThanOrEqualToK
{
    /// <summary>
    ///     Finds the length of the longest subsequence of the binary string <paramref name="s" /> that, when interpreted as a binary number, has a value
    ///     less than or equal to <paramref name="k" />.
    /// </summary>
    /// <param name="s">The binary string to select a subsequence from.</param>
    /// <param name="k">The maximum allowed numeric value of the subsequence.</param>
    /// <returns>The length of the longest valid subsequence.</returns>
    int LongestSubsequence(string s, int k);
}