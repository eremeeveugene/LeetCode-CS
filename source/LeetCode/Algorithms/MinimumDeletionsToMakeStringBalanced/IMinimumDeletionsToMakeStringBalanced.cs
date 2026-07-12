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

namespace LeetCode.Algorithms.MinimumDeletionsToMakeStringBalanced;

/// <summary>
///     https://leetcode.com/problems/minimum-deletions-to-make-string-balanced/description/
/// </summary>
public interface IMinimumDeletionsToMakeStringBalanced
{
    /// <summary>
    ///     Finds the minimum number of characters that must be deleted from the binary string <paramref name="s" />
    ///     (containing only 'a' and 'b') so that no 'b' appears before an 'a'.
    /// </summary>
    /// <param name="s">The string consisting of characters 'a' and 'b'.</param>
    /// <returns>The minimum number of deletions required to balance the string.</returns>
    int MinimumDeletions(string s);
}