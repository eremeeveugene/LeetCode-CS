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

namespace LeetCode.Algorithms.MinimumOperationsToConvertAllElementsToZero;

/// <summary>
///     https://leetcode.com/problems/minimum-operations-to-convert-all-elements-to-zero/description/
/// </summary>
public interface IMinimumOperationsToConvertAllElementsToZero
{
    /// <summary>
    ///     Finds the minimum number of operations needed to convert all elements of <paramref name="nums" /> to zero,
    ///     where each operation selects a subarray and replaces every element in it with the minimum value in that
    ///     subarray.
    /// </summary>
    /// <param name="nums">The array of integers to convert to all zeros.</param>
    /// <returns>The minimum number of operations required.</returns>
    int MinOperations(int[] nums);
}