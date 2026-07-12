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

namespace LeetCode.Algorithms.SearchInsertPosition;

/// <summary>
///     https://leetcode.com/problems/search-insert-position/description/
/// </summary>
public interface ISearchInsertPosition
{
    /// <summary>
    ///     Finds the index of <paramref name="target" /> in the sorted array <paramref name="nums" />, or the
    ///     index where it would be inserted to keep the array sorted.
    /// </summary>
    /// <param name="nums">The sorted array of distinct integers.</param>
    /// <param name="target">The value to search for or insert.</param>
    /// <returns>The index of <paramref name="target" /> in <paramref name="nums" />, or its insertion index.</returns>
    int SearchInsert(int[] nums, int target);
}