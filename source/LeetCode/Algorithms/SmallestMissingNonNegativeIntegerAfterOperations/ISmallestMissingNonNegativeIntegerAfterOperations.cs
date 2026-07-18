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

namespace LeetCode.Algorithms.SmallestMissingNonNegativeIntegerAfterOperations;

/// <summary>
///     https://leetcode.com/problems/smallest-missing-non-negative-integer-after-operations/description/
/// </summary>
public interface ISmallestMissingNonNegativeIntegerAfterOperations
{
    /// <summary>
    ///     Computes the maximum MEX (the smallest missing non-negative integer) of the array that can be achieved by
    ///     adding or subtracting the given value from any element any number of times.
    /// </summary>
    /// <param name="nums">The array of integers to evaluate.</param>
    /// <param name="value">The value that can be added to or subtracted from any element.</param>
    /// <returns>The maximum achievable MEX of the array.</returns>
    int FindSmallestInteger(int[] nums, int value);
}