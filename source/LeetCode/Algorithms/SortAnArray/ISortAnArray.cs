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

namespace LeetCode.Algorithms.SortAnArray;

/// <summary>
///     https://leetcode.com/problems/sort-an-array/description/
/// </summary>
public interface ISortAnArray
{
    /// <summary>
    ///     Sorts <paramref name="nums" /> in ascending order.
    /// </summary>
    /// <param name="nums">The array of integers to sort.</param>
    /// <returns>A new array containing the elements of <paramref name="nums" /> sorted in ascending order.</returns>
    int[] SortArray(int[] nums);
}