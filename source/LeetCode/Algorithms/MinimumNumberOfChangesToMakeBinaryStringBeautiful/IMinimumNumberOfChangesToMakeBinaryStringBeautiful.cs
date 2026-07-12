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

namespace LeetCode.Algorithms.MinimumNumberOfChangesToMakeBinaryStringBeautiful;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-changes-to-make-binary-string-beautiful/description/
/// </summary>
public interface IMinimumNumberOfChangesToMakeBinaryStringBeautiful
{
    /// <summary>
    ///     Finds the minimum number of character changes needed so that the binary string <paramref name="s" /> can
    ///     be partitioned into contiguous substrings of even length, each consisting of the same character.
    /// </summary>
    /// <param name="s">The binary string, of even length, to make beautiful.</param>
    /// <returns>The minimum number of changes required.</returns>
    int MinChanges(string s);
}