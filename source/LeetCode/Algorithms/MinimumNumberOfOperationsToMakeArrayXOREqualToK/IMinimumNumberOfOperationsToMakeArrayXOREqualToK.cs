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

namespace LeetCode.Algorithms.MinimumNumberOfOperationsToMakeArrayXOREqualToK;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-operations-to-make-array-xor-equal-to-k/
/// </summary>
public interface IMinimumNumberOfOperationsToMakeArrayXOREqualToK
{
    /// <summary>
    ///     Finds the minimum number of single-bit flips, applied to any elements of <paramref name="nums" />,
    ///     required so that the bitwise XOR of all elements equals <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of integers to modify.</param>
    /// <param name="k">The target value for the bitwise XOR of the array.</param>
    /// <returns>The minimum number of bit flips required.</returns>
    int MinOperations(int[] nums, int k);
}