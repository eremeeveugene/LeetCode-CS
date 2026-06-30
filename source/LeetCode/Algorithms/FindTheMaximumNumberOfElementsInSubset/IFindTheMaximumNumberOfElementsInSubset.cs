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

namespace LeetCode.Algorithms.FindTheMaximumNumberOfElementsInSubset;

/// <summary>
///     https://leetcode.com/problems/find-the-maximum-number-of-elements-in-subset/description/
/// </summary>
public interface IFindTheMaximumNumberOfElementsInSubset
{
    /// <summary>
    ///     Returns the maximum number of elements of a subset of <paramref name="nums" /> that can be arranged in a
    ///     pattern [x, x^2, x^4, ..., x^(k/2), x^k, x^(k/2), ..., x^4, x^2, x], where k is a non-negative power of 2.
    /// </summary>
    /// <param name="nums">The array of positive integers to select the subset from.</param>
    /// <returns>The maximum number of elements that the selected subset can contain.</returns>
    int MaximumLength(int[] nums);
}