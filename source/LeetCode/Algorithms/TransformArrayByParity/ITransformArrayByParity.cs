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

namespace LeetCode.Algorithms.TransformArrayByParity;

/// <summary>
///     https://leetcode.com/problems/transform-array-by-parity/description/
/// </summary>
public interface ITransformArrayByParity
{
    /// <summary>
    ///     Replaces each even element of <paramref name="nums" /> with 0 and each odd element with 1, then sorts
    ///     the resulting array in non-decreasing order.
    /// </summary>
    /// <param name="nums">The array of integers to transform.</param>
    /// <returns>The sorted array of 0s and 1s reflecting the parity of the original elements.</returns>
    int[] TransformArray(int[] nums);
}