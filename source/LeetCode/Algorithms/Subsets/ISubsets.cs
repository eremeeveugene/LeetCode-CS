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

namespace LeetCode.Algorithms.Subsets;

/// <summary>
///     https://leetcode.com/problems/subsets/
/// </summary>
public interface ISubsets
{
    /// <summary>
    ///     Generates all possible subsets (the power set) of the distinct integers in <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of distinct integers to generate subsets from.</param>
    /// <returns>A list of all possible subsets of <paramref name="nums" />.</returns>
    IList<IList<int>> Subsets(int[] nums);
}