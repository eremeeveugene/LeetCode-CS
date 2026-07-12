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

namespace LeetCode.Algorithms.RemoveDuplicatesFromSortedArray2;

/// <summary>
///     https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/description/
/// </summary>
public interface IRemoveDuplicatesFromSortedArray2
{
    /// <summary>
    ///     Removes duplicate values in place from the sorted array <paramref name="nums" /> so that each unique element
    ///     appears at most twice, preserving order.
    /// </summary>
    /// <param name="nums">The sorted array of integers to deduplicate in place.</param>
    /// <returns>The number of elements remaining at the front of <paramref name="nums" /> after deduplication.</returns>
    int RemoveDuplicates(int[] nums);
}