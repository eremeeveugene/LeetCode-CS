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

namespace LeetCode.Algorithms.InsertInterval;

/// <summary>
///     https://leetcode.com/problems/insert-interval/
/// </summary>
public interface IInsertInterval
{
    /// <summary>
    ///     Inserts <paramref name="newInterval" /> into the sorted, non-overlapping <paramref name="intervals" />, merging
    ///     overlapping intervals so the result remains sorted and non-overlapping.
    /// </summary>
    /// <param name="intervals">The non-overlapping intervals sorted in ascending order by start.</param>
    /// <param name="newInterval">The interval to insert.</param>
    /// <returns>The intervals after inserting and merging <paramref name="newInterval" />.</returns>
    int[][] Insert(int[][] intervals, int[] newInterval);
}