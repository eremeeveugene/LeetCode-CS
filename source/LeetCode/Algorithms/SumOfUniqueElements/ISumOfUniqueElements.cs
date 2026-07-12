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

namespace LeetCode.Algorithms.SumOfUniqueElements;

/// <summary>
///     https://leetcode.com/problems/sum-of-unique-elements/description/
/// </summary>
public interface ISumOfUniqueElements
{
    /// <summary>
    ///     Sums every element of <paramref name="nums" /> that occurs exactly once in the array.
    /// </summary>
    /// <param name="nums">The array of integers to inspect.</param>
    /// <returns>The sum of all unique elements in <paramref name="nums" />.</returns>
    int SumOfUnique(int[] nums);
}