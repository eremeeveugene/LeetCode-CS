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

namespace LeetCode.Algorithms.MinimumOperationsToMakeArrayElementsZero;

/// <summary>
///     https://leetcode.com/problems/minimum-operations-to-make-array-elements-zero/description/
/// </summary>
public interface IMinimumOperationsToMakeArrayElementsZero
{
    /// <summary>
    ///     Finds the sum of the minimum operation counts required to reduce every value in each queried inclusive range to zero.
    /// </summary>
    /// <param name="queries">The inclusive [left, right] ranges.</param>
    /// <returns>The sum of the minimum operation counts for all queries.</returns>
    long MinOperations(int[][] queries);
}