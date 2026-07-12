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

namespace LeetCode.Algorithms.CustomSortString;

/// <summary>
///     https://leetcode.com/problems/custom-sort-string/
/// </summary>
public interface ICustomSortString
{
    /// <summary>
    ///     Permutes the characters of <paramref name="s" /> so that they match the relative order of the characters in
    ///     <paramref name="order" />; characters not present in <paramref name="order" /> may appear in any position.
    /// </summary>
    /// <param name="order">The string defining the custom order of characters.</param>
    /// <param name="s">The string to permute.</param>
    /// <returns>A permutation of <paramref name="s" /> that satisfies the custom order defined by <paramref name="order" />.</returns>
    string CustomSortString(string order, string s);
}