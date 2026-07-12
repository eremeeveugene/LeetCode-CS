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

namespace LeetCode.Algorithms.ReplaceNonCoprimeNumbersInArray;

/// <summary>
///     https://leetcode.com/problems/replace-non-coprime-numbers-in-array/description/
/// </summary>
public interface IReplaceNonCoprimeNumbersInArray
{
    /// <summary>
    ///     Repeatedly merges adjacent elements of <paramref name="nums" /> that are not coprime by replacing them with
    ///     their least common multiple, until every pair of adjacent elements is coprime.
    /// </summary>
    /// <param name="nums">The array of integers to process.</param>
    /// <returns>The resulting array after all non-coprime adjacent elements have been merged.</returns>
    IList<int> ReplaceNonCoprimes(int[] nums);
}