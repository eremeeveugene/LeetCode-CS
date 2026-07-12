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

namespace LeetCode.Algorithms.MaximumCountOfPositiveIntegerAndNegativeInteger;

/// <summary>
///     https://leetcode.com/problems/maximum-count-of-positive-integer-and-negative-integer/description/
/// </summary>
public interface IMaximumCountOfPositiveIntegerAndNegativeInteger
{
    /// <summary>
    ///     Computes the larger of the count of positive integers and the count of negative integers in the sorted array
    ///     <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The sorted array of integers to count positive and negative values in.</param>
    /// <returns>The maximum between the number of positive integers and the number of negative integers in <paramref name="nums" />.</returns>
    int MaximumCount(int[] nums);
}