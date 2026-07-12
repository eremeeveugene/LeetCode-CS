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

namespace LeetCode.Algorithms.CheckIfOneStringSwapCanMakeStringsEqual;

/// <summary>
///     https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal/description/
/// </summary>
public interface ICheckIfOneStringSwapCanMakeStringsEqual
{
    /// <summary>
    ///     Determines whether <paramref name="s1" /> and <paramref name="s2" /> can be made equal by performing at most one
    ///     swap of two characters within exactly one of the strings.
    /// </summary>
    /// <param name="s1">The first string.</param>
    /// <param name="s2">The second string.</param>
    /// <returns><c>true</c> if the strings can be made equal with at most one swap; otherwise, <c>false</c>.</returns>
    bool AreAlmostEqual(string s1, string s2);
}