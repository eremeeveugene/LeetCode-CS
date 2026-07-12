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

namespace LeetCode.Algorithms.MostBeautifulItemForEachQuery;

/// <summary>
///     https://leetcode.com/problems/most-beautiful-item-for-each-query/description/
/// </summary>
public interface IMostBeautifulItemForEachQuery
{
    /// <summary>
    ///     For each query in <paramref name="queries" />, finds the maximum beauty among all items in
    ///     <paramref name="items" /> whose price does not exceed the query value.
    /// </summary>
    /// <param name="items">The list of items, each represented as a [price, beauty] pair.</param>
    /// <param name="queries">The array of maximum price thresholds to query against.</param>
    /// <returns>An array where each element is the maximum beauty found for the corresponding query, or 0 if none qualify.</returns>
    int[] MaximumBeauty(int[][] items, int[] queries);
}