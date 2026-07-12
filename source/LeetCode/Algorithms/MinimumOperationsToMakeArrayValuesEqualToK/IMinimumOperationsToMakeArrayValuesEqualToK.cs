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

namespace LeetCode.Algorithms.MinimumOperationsToMakeArrayValuesEqualToK;

/// <summary>
///     https://leetcode.com/problems/minimum-operations-to-make-array-values-equal-to-k/description/
/// </summary>
public interface IMinimumOperationsToMakeArrayValuesEqualToK
{
    /// <summary>
    ///     Finds the minimum number of operations needed to make every element of <paramref name="nums" /> equal to
    ///     <paramref name="k" />, where each operation decreases every element greater than the current minimum down
    ///     to that minimum.
    /// </summary>
    /// <param name="nums">The array of integers to equalize.</param>
    /// <param name="k">The target value that every element should be reduced to.</param>
    /// <returns>The minimum number of operations required, or -1 if it is not possible.</returns>
    int MinOperations(int[] nums, int k);
}