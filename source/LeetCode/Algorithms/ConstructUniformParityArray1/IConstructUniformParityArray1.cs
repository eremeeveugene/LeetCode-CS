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

namespace LeetCode.Algorithms.ConstructUniformParityArray1;

/// <summary>
///     https://leetcode.com/problems/construct-uniform-parity-array-i/description/
/// </summary>
public interface IConstructUniformParityArray1
{
    /// <summary>
    ///     Determines whether <paramref name="nums1" /> can be rearranged so that all its elements have the same parity.
    /// </summary>
    /// <param name="nums1">The array of integers to check.</param>
    /// <returns><see langword="true" /> if all elements share the same parity; otherwise, <see langword="false" />.</returns>
    bool UniformArray(int[] nums1);
}