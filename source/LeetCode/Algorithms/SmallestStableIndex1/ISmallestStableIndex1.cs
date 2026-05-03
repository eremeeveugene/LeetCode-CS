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

namespace LeetCode.Algorithms.SmallestStableIndex1;

/// <summary>
///     https://leetcode.com/problems/smallest-stable-index-i/description/
/// </summary>
public interface ISmallestStableIndex1
{
    /// <summary>
    ///     Finds the smallest stable index in the specified array.
    /// </summary>
    /// <param name="nums">The integer array used to search for a stable index.</param>
    /// <param name="k">The modulo value used to determine whether an index is stable.</param>
    /// <returns>
    ///     The smallest index i such that nums[i] % k == i % k; otherwise, -1 if no stable index exists.
    /// </returns>
    int FirstStableIndex(int[] nums, int k);
}