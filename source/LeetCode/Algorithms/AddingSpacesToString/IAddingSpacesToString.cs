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

namespace LeetCode.Algorithms.AddingSpacesToString;

/// <summary>
///     https://leetcode.com/problems/adding-spaces-to-a-string/description/
/// </summary>
public interface IAddingSpacesToString
{
    /// <summary>
    ///     Inserts a space into <paramref name="s" /> before each index specified in <paramref name="spaces" />.
    /// </summary>
    /// <param name="s">The original string.</param>
    /// <param name="spaces">The indices in the original string before which spaces are inserted.</param>
    /// <returns>The modified string with spaces inserted at the specified indices.</returns>
    string AddSpaces(string s, int[] spaces);
}