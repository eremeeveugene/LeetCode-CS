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

namespace LeetCode.Algorithms.DeleteColumnsToMakeSorted2;

/// <summary>
///     https://leetcode.com/problems/delete-columns-to-make-sorted-ii/description/
/// </summary>
public interface IDeleteColumnsToMakeSorted2
{
    /// <summary>
    ///     Computes the minimum number of columns that must be deleted from the grid formed by <paramref name="strs" />
    ///     so that the remaining rows are in lexicographic order.
    /// </summary>
    /// <param name="strs">The array of equal-length strings forming the grid.</param>
    /// <returns>The minimum number of columns to delete so the rows become lexicographically sorted.</returns>
    int MinDeletionSize(string[] strs);
}