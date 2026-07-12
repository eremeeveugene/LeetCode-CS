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

namespace LeetCode.Algorithms.TransformArrayToAllEqualElements;

/// <summary>
///     https://leetcode.com/problems/transform-array-to-all-equal-elements/description/
/// </summary>
public interface ITransformArrayToAllEqualElements
{
    /// <summary>
    ///     Determines whether every element of <paramref name="nums" /> (each either 1 or -1) can be made equal
    ///     using at most <paramref name="k" /> operations, where each operation swaps two adjacent elements with
    ///     different values.
    /// </summary>
    /// <param name="nums">The array of integers, each equal to 1 or -1, to transform.</param>
    /// <param name="k">The maximum number of adjacent swap operations allowed.</param>
    /// <returns><see langword="true" /> if all elements can be made equal within <paramref name="k" /> operations; otherwise, <see langword="false" />.</returns>
    bool CanMakeEqual(int[] nums, int k);
}