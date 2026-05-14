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

namespace LeetCode.Algorithms.CountIndicesWithOppositeParity;

/// <summary>
///     https://leetcode.com/problems/count-indices-with-opposite-parity/description/
/// </summary>
public interface ICountIndicesWithOppositeParity
{
    /// <summary>
    ///     Counts, for each index, the number of following values that have the opposite parity.
    /// </summary>
    /// <param name="nums">The integer array whose values should be checked by parity.</param>
    /// <returns>An array where each value contains the count of following values with the opposite parity.</returns>
    int[] CountOppositeParity(int[] nums);
}