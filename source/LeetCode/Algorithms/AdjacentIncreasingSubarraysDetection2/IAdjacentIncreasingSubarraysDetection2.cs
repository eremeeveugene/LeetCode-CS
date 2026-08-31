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

namespace LeetCode.Algorithms.AdjacentIncreasingSubarraysDetection2;

/// <summary>
///     https://leetcode.com/problems/adjacent-increasing-subarrays-detection-ii/description/
/// </summary>
public interface IAdjacentIncreasingSubarraysDetection2
{
    /// <summary>
    ///     Finds the greatest length of two adjacent strictly increasing subarrays in <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The list of integers.</param>
    /// <returns>The maximum common length of two adjacent strictly increasing subarrays.</returns>
    int MaxIncreasingSubarrays(IList<int> nums);
}