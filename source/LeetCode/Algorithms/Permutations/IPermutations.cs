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

namespace LeetCode.Algorithms.Permutations;

/// <summary>
///     https://leetcode.com/problems/permutations/
/// </summary>
public interface IPermutations
{
    /// <summary>
    ///     Generates all possible permutations of the distinct integers in <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of distinct integers to permute.</param>
    /// <returns>A list containing all permutations of <paramref name="nums" />.</returns>
    IList<IList<int>> Permute(int[] nums);
}