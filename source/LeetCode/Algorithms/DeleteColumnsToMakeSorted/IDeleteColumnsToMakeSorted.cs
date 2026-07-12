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

namespace LeetCode.Algorithms.DeleteColumnsToMakeSorted;

/// <summary>
///     https://leetcode.com/problems/delete-columns-to-make-sorted/description/
/// </summary>
public interface IDeleteColumnsToMakeSorted
{
    /// <summary>
    ///     Counts the columns of the grid formed by <paramref name="strs" /> that are not sorted lexicographically and
    ///     therefore must be deleted.
    /// </summary>
    /// <param name="strs">The array of equal-length strings forming the grid.</param>
    /// <returns>The number of columns that need to be deleted so every remaining column is sorted.</returns>
    int MinDeletionSize(string[] strs);
}