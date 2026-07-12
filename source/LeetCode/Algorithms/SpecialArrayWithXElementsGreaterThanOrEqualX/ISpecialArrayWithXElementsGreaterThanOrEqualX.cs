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

namespace LeetCode.Algorithms.SpecialArrayWithXElementsGreaterThanOrEqualX;

/// <summary>
///     https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x/
/// </summary>
public interface ISpecialArrayWithXElementsGreaterThanOrEqualX
{
    /// <summary>
    ///     Finds a unique value x such that exactly x elements of <paramref name="nums" /> are greater than or
    ///     equal to x.
    /// </summary>
    /// <param name="nums">The array of non-negative integers to check.</param>
    /// <returns>The unique value x satisfying the special array condition, or -1 if no such value exists.</returns>
    int SpecialArray(int[] nums);
}