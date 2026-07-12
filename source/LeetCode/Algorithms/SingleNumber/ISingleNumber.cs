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

namespace LeetCode.Algorithms.SingleNumber;

/// <summary>
///     https://leetcode.com/problems/single-number/
/// </summary>
public interface ISingleNumber
{
    /// <summary>
    ///     Finds the element in <paramref name="nums" /> that appears exactly once, given that every other
    ///     element appears exactly twice.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <returns>The single element that appears only once in <paramref name="nums" />.</returns>
    int SingleNumber(int[] nums);
}