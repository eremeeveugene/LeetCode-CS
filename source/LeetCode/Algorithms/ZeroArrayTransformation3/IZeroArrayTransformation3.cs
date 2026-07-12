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

namespace LeetCode.Algorithms.ZeroArrayTransformation3;

/// <summary>
///     https://leetcode.com/problems/zero-array-transformation-iii/description/
/// </summary>
public interface IZeroArrayTransformation3
{
    /// <summary>
    ///     Finds the maximum number of range operations from <paramref name="queries" /> that can be removed while
    ///     the remaining operations can still transform <paramref name="nums" /> into an array of all zeros.
    /// </summary>
    /// <param name="nums">The array of non-negative integers to transform.</param>
    /// <param name="queries">The array of range operations, each decrementing by one every element within an inclusive range.</param>
    /// <returns>The maximum number of operations that can be removed, or -1 if the array cannot be zeroed out.</returns>
    int MaxRemoval(int[] nums, int[][] queries);
}