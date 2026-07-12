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

namespace LeetCode.Algorithms.BinarySearch;

/// <summary>
///     https://leetcode.com/problems/binary-search/
/// </summary>
public interface IBinarySearch
{
    /// <summary>
    ///     Searches the sorted array <paramref name="nums" /> for <paramref name="target" /> using binary search.
    /// </summary>
    /// <param name="nums">The sorted array of integers to search.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of <paramref name="target" /> in <paramref name="nums" />, or -1 if it is not present.</returns>
    int Search(int[] nums, int target);
}