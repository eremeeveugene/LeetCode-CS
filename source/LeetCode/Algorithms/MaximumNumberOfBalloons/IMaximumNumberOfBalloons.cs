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

namespace LeetCode.Algorithms.MaximumNumberOfBalloons;

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-balloons/description
/// </summary>
public interface IMaximumNumberOfBalloons
{
    /// <summary>
    ///     Determines the maximum number of instances of the word "balloon" that can be formed by taking and rearranging the
    ///     characters of <paramref name="text" />, where each character of <paramref name="text" /> can be used in at most one
    ///     instance.
    /// </summary>
    /// <param name="text">The source string supplying the available characters.</param>
    /// <returns>The maximum number of instances of the word "balloon" that can be formed.</returns>
    int MaxNumberOfBalloons(string text);
}