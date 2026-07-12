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

namespace LeetCode.Algorithms.DivideArrayInSetsOfKConsecutiveNumbers;

/// <summary>
///     https://leetcode.com/problems/divide-array-in-sets-of-k-consecutive-numbers/
/// </summary>
public interface IDivideArrayInSetsOfKConsecutiveNumbers
{
    /// <summary>
    ///     Determines whether <paramref name="nums" /> can be divided into groups of <paramref name="k" /> consecutive
    ///     numbers.
    /// </summary>
    /// <param name="nums">The array of integers to divide.</param>
    /// <param name="k">The required size and consecutiveness length of each group.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="nums" /> can be divided into such groups; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    bool IsPossibleDivide(int[] nums, int k);
}