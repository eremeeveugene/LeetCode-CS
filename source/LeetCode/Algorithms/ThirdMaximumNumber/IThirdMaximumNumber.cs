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

namespace LeetCode.Algorithms.ThirdMaximumNumber;

/// <summary>
///     https://leetcode.com/problems/third-maximum-number/description/
/// </summary>
public interface IThirdMaximumNumber
{
    /// <summary>
    ///     Finds the third distinct maximum number in <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <returns>The third distinct maximum number, or the maximum number if it does not exist.</returns>
    int ThirdMax(int[] nums);
}