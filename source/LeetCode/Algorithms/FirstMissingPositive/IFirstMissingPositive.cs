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

namespace LeetCode.Algorithms.FirstMissingPositive;

/// <summary>
///     https://leetcode.com/problems/first-missing-positive/description/
/// </summary>
public interface IFirstMissingPositive
{
    /// <summary>
    ///     Finds the smallest positive integer that is not present in <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <returns>The smallest missing positive integer.</returns>
    int FirstMissingPositive(int[] nums);
}