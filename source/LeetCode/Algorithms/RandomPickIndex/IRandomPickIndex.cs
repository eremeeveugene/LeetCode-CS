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

namespace LeetCode.Algorithms.RandomPickIndex;

/// <summary>
///     https://leetcode.com/problems/random-pick-index/description/
/// </summary>
public interface IRandomPickIndex
{
    /// <summary>
    ///     Randomly picks and returns an index from the constructor's <c>nums</c> array whose value equals
    ///     <paramref name="target" />, such that every valid index has an equal probability of being returned.
    /// </summary>
    /// <param name="target">The value whose indices should be considered.</param>
    /// <returns>A uniformly random index <c>i</c> such that <c>nums[i] == target</c>.</returns>
    int Pick(int target);
}