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

namespace LeetCode.Algorithms.MinimumElementAfterReplacementWithDigitSum;

/// <summary>
///     https://leetcode.com/problems/minimum-element-after-replacement-with-digit-sum/description/
/// </summary>
public interface IMinimumElementAfterReplacementWithDigitSum
{
    /// <summary>
    ///     Replaces every element with the sum of its digits and returns the minimum resulting value.
    /// </summary>
    /// <param name="nums">The integer array whose elements should be replaced with their digit sums.</param>
    /// <returns>The minimum element of the array after each value is replaced by its digit sum.</returns>
    int MinElement(int[] nums);
}