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

namespace LeetCode.Algorithms.TrionicArray1;

/// <summary>
///     https://leetcode.com/problems/trionic-array-i/description/
/// </summary>
public interface ITrionicArray1
{
    /// <summary>
    ///     Determines whether <paramref name="nums" /> is trionic — strictly increasing, then strictly decreasing,
    ///     then strictly increasing again, across three consecutive segments.
    /// </summary>
    /// <param name="nums">The array of integers to check.</param>
    /// <returns><see langword="true" /> if <paramref name="nums" /> is a trionic array; otherwise, <see langword="false" />.</returns>
    bool IsTrionic(int[] nums);
}