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

namespace LeetCode.Algorithms.ThreeSum;

/// <summary>
///     https://leetcode.com/problems/3sum/
/// </summary>
public interface IThreeSum
{
    /// <summary>
    ///     Finds all unique triplets in <paramref name="nums" /> whose elements sum to zero.
    /// </summary>
    /// <param name="nums">The array of integers to search for triplets in.</param>
    /// <returns>A list of triplets, each summing to zero, with no duplicate triplets.</returns>
    IList<IList<int>> ThreeSum(int[] nums);
}