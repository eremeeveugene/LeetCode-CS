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

namespace LeetCode.Algorithms.SetMismatch;

/// <summary>
///     https://leetcode.com/problems/set-mismatch/description/
/// </summary>
public interface ISetMismatch
{
    /// <summary>
    ///     Finds the number in <paramref name="nums" /> that appears twice and the number that is missing from
    ///     the range 1 to n, where one number in the original set 1..n was replaced by a duplicate of another.
    /// </summary>
    /// <param name="nums">The array of integers that should contain each of 1..n exactly once.</param>
    /// <returns>An array containing the duplicated number followed by the missing number.</returns>
    int[] FindErrorNums(int[] nums);
}