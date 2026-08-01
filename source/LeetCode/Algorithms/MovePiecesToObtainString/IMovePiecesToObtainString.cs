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

namespace LeetCode.Algorithms.MovePiecesToObtainString;

/// <summary>
///     https://leetcode.com/problems/move-pieces-to-obtain-a-string/description/
/// </summary>
public interface IMovePiecesToObtainString
{
    /// <summary>
    ///     Determines whether <paramref name="start" /> can be transformed into <paramref name="target" /> by moving
    ///     'L' pieces leftward into adjacent '_' blanks and 'R' pieces rightward into adjacent '_' blanks, any number
    ///     of times.
    /// </summary>
    /// <param name="start">The initial string of 'L', 'R', and '_' characters.</param>
    /// <param name="target">The target string of 'L', 'R', and '_' characters to reach.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="start" /> can be transformed into <paramref name="target" />; otherwise, <see langword="false" />
    ///     .
    /// </returns>
    bool CanChange(string start, string target);
}