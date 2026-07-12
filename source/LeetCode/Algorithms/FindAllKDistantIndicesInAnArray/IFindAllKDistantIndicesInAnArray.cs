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

namespace LeetCode.Algorithms.FindAllKDistantIndicesInAnArray;

/// <summary>
///     https://leetcode.com/problems/find-all-k-distant-indices-in-an-array/description/
/// </summary>
public interface IFindAllKDistantIndicesInAnArray
{
    /// <summary>
    ///     Finds all indices of <paramref name="nums" /> that are within distance <paramref name="k" /> of an index whose
    ///     value equals <paramref name="key" />.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <param name="key">The value to search for in the array.</param>
    /// <param name="k">The maximum allowed distance to an index containing <paramref name="key" />.</param>
    /// <returns>The list of k-distant indices in increasing order.</returns>
    IList<int> FindKDistantIndices(int[] nums, int key, int k);
}