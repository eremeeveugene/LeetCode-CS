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

namespace LeetCode.Algorithms.FindMinimumOperationsToMakeAllElementsDivisibleByThree;

/// <summary>
///     https://leetcode.com/problems/find-minimum-operations-to-make-all-elements-divisible-by-three/
/// </summary>
public interface IFindMinimumOperationsToMakeAllElementsDivisibleByThree
{
    /// <summary>
    ///     Computes the minimum number of operations needed to make all elements of <paramref name="nums" /> divisible by
    ///     three, where each operation adds or subtracts one from any element.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The minimum number of operations required.</returns>
    int MinimumOperations(int[] nums);
}