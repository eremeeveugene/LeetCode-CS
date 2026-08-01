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

namespace LeetCode.Algorithms.MakeStringSubsequenceUsingCyclicIncrements;

/// <summary>
///     https://leetcode.com/problems/make-string-a-subsequence-using-cyclic-increments/description/
/// </summary>
public interface IMakeStringSubsequenceUsingCyclicIncrements
{
    /// <summary>
    ///     Determines whether <paramref name="str2" /> can be made a subsequence of <paramref name="str1" /> by cyclically
    ///     incrementing (i.e. 'z' wraps to 'a') any subset of the characters of <paramref name="str1" /> at most once.
    /// </summary>
    /// <param name="str1">The source string whose characters may be cyclically incremented.</param>
    /// <param name="str2">The target string to check as a possible subsequence of the modified <paramref name="str1" />.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="str2" /> can become a subsequence of <paramref name="str1" /> after the allowed increments;
    ///     otherwise, <see langword="false" />.
    /// </returns>
    bool CanMakeSubsequence(string str1, string str2);
}