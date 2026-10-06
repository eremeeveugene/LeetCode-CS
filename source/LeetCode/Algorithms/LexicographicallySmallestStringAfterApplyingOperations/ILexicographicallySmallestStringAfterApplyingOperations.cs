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

namespace LeetCode.Algorithms.LexicographicallySmallestStringAfterApplyingOperations;

/// <summary>
///     https://leetcode.com/problems/lexicographically-smallest-string-after-applying-operations/description/
/// </summary>
public interface ILexicographicallySmallestStringAfterApplyingOperations
{
    /// <summary>
    ///     Finds the lexicographically smallest string reachable by repeatedly adding a to every odd index digit
    ///     and rotating the string right by b positions.
    /// </summary>
    /// <param name="s">The string of digits, of even length.</param>
    /// <param name="a">The value added to every digit at an odd index, modulo 10.</param>
    /// <param name="b">The number of positions to rotate the string to the right.</param>
    /// <returns>The lexicographically smallest reachable string.</returns>
    string FindLexSmallestString(string s, int a, int b);
}