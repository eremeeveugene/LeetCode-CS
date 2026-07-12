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

namespace LeetCode.Algorithms.MinimumDeletionsToMakeStringKSpecial;

/// <summary>
///     https://leetcode.com/problems/minimum-deletions-to-make-string-k-special/description/
/// </summary>
public interface IMinimumDeletionsToMakeStringKSpecial
{
    /// <summary>
    ///     Finds the minimum number of characters that must be deleted from <paramref name="word" /> so that, for
    ///     every pair of characters remaining in it, the difference between their frequencies is at most
    ///     <paramref name="k" />.
    /// </summary>
    /// <param name="word">The string whose character frequencies must be balanced.</param>
    /// <param name="k">The maximum allowed difference between the frequencies of any two characters.</param>
    /// <returns>The minimum number of character deletions required to make <paramref name="word" /> k-special.</returns>
    int MinimumDeletions(string word, int k);
}