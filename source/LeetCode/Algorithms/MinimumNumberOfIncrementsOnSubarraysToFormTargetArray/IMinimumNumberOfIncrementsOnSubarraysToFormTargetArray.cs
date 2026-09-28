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

namespace LeetCode.Algorithms.MinimumNumberOfIncrementsOnSubarraysToFormTargetArray;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-increments-on-subarrays-to-form-a-target-array/description/
/// </summary>
public interface IMinimumNumberOfIncrementsOnSubarraysToFormTargetArray
{
    /// <summary>
    ///     Finds the minimum number of subarray increments needed to form the target from an all-zero array.
    /// </summary>
    /// <param name="target">The nonempty array of positive target values.</param>
    /// <returns>The minimum number of operations.</returns>
    int MinNumberOperations(int[] target);
}