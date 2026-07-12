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

namespace LeetCode.Algorithms.TakeKOfEachCharacterFromLeftAndRight;

/// <summary>
///     https://leetcode.com/problems/take-k-of-each-character-from-left-and-right/description/
/// </summary>
public interface ITakeKOfEachCharacterFromLeftAndRight
{
    /// <summary>
    ///     Finds the minimum number of characters that must be removed from either end of <paramref name="s" /> so
    ///     that the removed characters contain at least <paramref name="k" /> occurrences each of <c>'a'</c>,
    ///     <c>'b'</c>, and <c>'c'</c>.
    /// </summary>
    /// <param name="s">The string consisting of the characters <c>'a'</c>, <c>'b'</c>, and <c>'c'</c>.</param>
    /// <param name="k">The minimum required count of each of the three characters to remove.</param>
    /// <returns>The minimum number of minutes (removed characters) needed, or -1 if it is not possible.</returns>
    int TakeCharacters(string s, int k);
}