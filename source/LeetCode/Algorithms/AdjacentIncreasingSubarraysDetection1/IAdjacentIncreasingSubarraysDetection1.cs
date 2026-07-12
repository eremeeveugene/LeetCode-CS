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

namespace LeetCode.Algorithms.AdjacentIncreasingSubarraysDetection1;

/// <summary>
///     https://leetcode.com/problems/adjacent-increasing-subarrays-detection-i/description/
/// </summary>
public interface IAdjacentIncreasingSubarraysDetection1
{
    /// <summary>
    ///     Determines whether <paramref name="nums" /> contains two adjacent strictly increasing subarrays, each of length
    ///     <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The list of integers.</param>
    /// <param name="k">The required length of each subarray.</param>
    /// <returns><c>true</c> if two adjacent strictly increasing subarrays of length <paramref name="k" /> exist; otherwise, <c>false</c>.</returns>
    bool HasIncreasingSubarrays(IList<int> nums, int k);
}