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

namespace LeetCode.Algorithms.MaximalScoreAfterApplyingKOperations;

/// <summary>
///     https://leetcode.com/problems/maximal-score-after-applying-k-operations/description/
/// </summary>
public interface IMaximalScoreAfterApplyingKOperations
{
    /// <summary>
    ///     Performs <paramref name="k" /> operations on <paramref name="nums" />, each time adding the current maximum
    ///     element to a running score and replacing it with its ceiling divided by 3, to maximize the total score.
    /// </summary>
    /// <param name="nums">The array of positive integers to operate on.</param>
    /// <param name="k">The number of operations to perform.</param>
    /// <returns>The maximum possible score achievable after performing <paramref name="k" /> operations.</returns>
    long MaxKelements(int[] nums, int k);
}