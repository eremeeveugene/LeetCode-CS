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

namespace LeetCode.Algorithms.FindingPairsWithCertainSum;

/// <summary>
///     https://leetcode.com/problems/finding-pairs-with-a-certain-sum/description/
/// </summary>
public interface IFindingPairsWithCertainSum
{
    /// <summary>
    ///     Adds <paramref name="val" /> to the element of the second array at position <paramref name="index" />.
    /// </summary>
    /// <param name="index">The index of the element in the second array to modify.</param>
    /// <param name="val">The value to add to the element.</param>
    void Add(int index, int val);

    /// <summary>
    ///     Counts the pairs of elements, one from each array, whose sum equals <paramref name="tot" />.
    /// </summary>
    /// <param name="tot">The target sum of a pair.</param>
    /// <returns>The number of pairs whose sum equals <paramref name="tot" />.</returns>
    int Count(int tot);
}