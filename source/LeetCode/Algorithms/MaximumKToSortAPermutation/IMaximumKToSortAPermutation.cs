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

namespace LeetCode.Algorithms.MaximumKToSortAPermutation;

/// <summary>
///     https://leetcode.com/problems/maximum-k-to-sort-a-permutation/description/
/// </summary>
public interface IMaximumKToSortAPermutation
{
    /// <summary>
    ///     Finds the maximum k such that the permutation can be sorted by swapping elements whose bitwise AND equals k.
    /// </summary>
    /// <param name="nums">The permutation of the integers from 0 to n - 1.</param>
    /// <returns>The maximum value of k that allows sorting, or 0 if the permutation is already sorted.</returns>
    int SortPermutation(int[] nums);
}