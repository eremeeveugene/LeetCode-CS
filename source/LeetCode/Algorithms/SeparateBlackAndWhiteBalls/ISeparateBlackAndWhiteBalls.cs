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

namespace LeetCode.Algorithms.SeparateBlackAndWhiteBalls;

/// <summary>
///     https://leetcode.com/problems/separate-black-and-white-balls/description/
/// </summary>
public interface ISeparateBlackAndWhiteBalls
{
    /// <summary>
    ///     Computes the minimum number of adjacent swaps required to group all black balls ('1') to the right
    ///     and all white balls ('0') to the left in <paramref name="s" />.
    /// </summary>
    /// <param name="s">The binary string representing the arrangement of balls.</param>
    /// <returns>The minimum number of adjacent swaps needed to separate the balls.</returns>
    long MinimumSteps(string s);
}