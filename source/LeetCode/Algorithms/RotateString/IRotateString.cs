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

namespace LeetCode.Algorithms.RotateString;

/// <summary>
///     https://leetcode.com/problems/rotate-string/description/
/// </summary>
public interface IRotateString
{
    /// <summary>
    ///     Determines whether the specified source string can become the target string after zero or more left shifts.
    /// </summary>
    /// <param name="s">The source string to shift.</param>
    /// <param name="goal">The target string to compare against shifted versions of <paramref name="s" />.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="s" /> can become <paramref name="goal" /> after zero or more
    ///     left shifts; otherwise, <see langword="false" />.
    /// </returns>
    bool RotateString(string s, string goal);
}