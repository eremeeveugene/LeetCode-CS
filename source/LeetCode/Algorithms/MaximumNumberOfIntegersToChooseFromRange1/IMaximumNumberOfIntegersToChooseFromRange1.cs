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

namespace LeetCode.Algorithms.MaximumNumberOfIntegersToChooseFromRange1;

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-integers-to-choose-from-a-range-i/description/
/// </summary>
public interface IMaximumNumberOfIntegersToChooseFromRange1
{
    /// <summary>
    ///     Chooses the maximum count of distinct integers from the range [1, <paramref name="n" />], excluding those in
    ///     <paramref name="banned" />, such that their sum does not exceed <paramref name="maxSum" />.
    /// </summary>
    /// <param name="banned">The array of integers that may not be chosen.</param>
    /// <param name="n">The upper bound (inclusive) of the range of integers to choose from.</param>
    /// <param name="maxSum">The maximum allowed sum of the chosen integers.</param>
    /// <returns>The maximum count of integers that can be chosen while satisfying the constraints.</returns>
    int MaxCount(int[] banned, int n, int maxSum);
}