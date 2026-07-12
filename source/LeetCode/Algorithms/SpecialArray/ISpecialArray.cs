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

namespace LeetCode.Algorithms.SpecialArray;

/// <summary>
///     https://leetcode.com/problems/special-array-i/description/
/// </summary>
public interface ISpecialArray
{
    /// <summary>
    ///     Determines whether every pair of adjacent elements in <paramref name="nums" /> has different parity.
    /// </summary>
    /// <param name="nums">The array of integers to check.</param>
    /// <returns><see langword="true" /> if <paramref name="nums" /> is special; otherwise, <see langword="false" />.</returns>
    bool IsArraySpecial(int[] nums);
}