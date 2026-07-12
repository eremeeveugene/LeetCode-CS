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

namespace LeetCode.Algorithms.ApplyOperationsToAnArray;

/// <summary>
///     https://leetcode.com/problems/apply-operations-to-an-array/description/
/// </summary>
public interface IApplyOperationsToAnArray
{
    /// <summary>
    ///     Applies the operations to <paramref name="nums" /> by doubling each element equal to its successor and zeroing
    ///     the successor, then shifts all zeros to the end of the array.
    /// </summary>
    /// <param name="nums">The array of non-negative integers.</param>
    /// <returns>The resulting array after applying the operations and shifting all zeros to the end.</returns>
    int[] ApplyOperations(int[] nums);
}