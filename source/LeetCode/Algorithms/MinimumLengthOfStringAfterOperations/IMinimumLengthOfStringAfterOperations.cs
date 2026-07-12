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

namespace LeetCode.Algorithms.MinimumLengthOfStringAfterOperations;

/// <summary>
///     https://leetcode.com/problems/minimum-length-of-string-after-operations/description/
/// </summary>
public interface IMinimumLengthOfStringAfterOperations
{
    /// <summary>
    ///     Repeatedly selects an index whose character has at least one closer occurrence on each side and removes
    ///     both of those closest occurrences from <paramref name="s" />, and finds the minimum possible length of
    ///     the string after performing any number of such operations.
    /// </summary>
    /// <param name="s">The string to reduce.</param>
    /// <returns>The minimum length of the string after all possible operations.</returns>
    int MinimumLength(string s);
}