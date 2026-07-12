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

namespace LeetCode.Algorithms.ZeroArrayTransformation1;

/// <summary>
///     https://leetcode.com/problems/zero-array-transformation-i/description/
/// </summary>
public interface IZeroArrayTransformation1
{
    /// <summary>
    ///     Determines whether <paramref name="nums" /> can be transformed into an array of all zeros by applying
    ///     every range decrement operation described by <paramref name="queries" />.
    /// </summary>
    /// <param name="nums">The array of non-negative integers to transform.</param>
    /// <param name="queries">The array of range operations, each decrementing by one every element within an inclusive range.</param>
    /// <returns><see langword="true" /> if <paramref name="nums" /> can become all zeros; otherwise, <see langword="false" />.</returns>
    bool IsZeroArray(int[] nums, int[][] queries);
}