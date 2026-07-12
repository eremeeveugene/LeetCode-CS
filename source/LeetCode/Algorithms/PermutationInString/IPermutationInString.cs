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

namespace LeetCode.Algorithms.PermutationInString;

/// <summary>
///     https://leetcode.com/problems/permutation-in-string/description/
/// </summary>
public interface IPermutationInString
{
    /// <summary>
    ///     Determines whether <paramref name="s2" /> contains a contiguous substring that is a permutation of
    ///     <paramref name="s1" />.
    /// </summary>
    /// <param name="s1">The string whose permutations are searched for.</param>
    /// <param name="s2">The string to search within.</param>
    /// <returns><see langword="true" /> if <paramref name="s2" /> contains a permutation of <paramref name="s1" />; otherwise, <see langword="false" />.</returns>
    bool CheckInclusion(string s1, string s2);
}