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

namespace LeetCode.Algorithms.AppleRedistributionIntoBoxes;

/// <summary>
///     https://leetcode.com/problems/apple-redistribution-into-boxes/description/
/// </summary>
public interface IAppleRedistributionIntoBoxes
{
    /// <summary>
    ///     Computes the minimum number of boxes needed to redistribute all apples from the packs in
    ///     <paramref name="apples" /> into boxes with the given <paramref name="capacities" />.
    /// </summary>
    /// <param name="apples">The number of apples in each pack.</param>
    /// <param name="capacities">The capacity of each box.</param>
    /// <returns>The minimum number of boxes required to hold all the apples.</returns>
    int MinimumBoxes(int[] apples, int[] capacities);
}