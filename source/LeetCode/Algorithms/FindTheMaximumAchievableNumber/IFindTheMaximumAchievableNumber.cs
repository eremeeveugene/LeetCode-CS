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

namespace LeetCode.Algorithms.FindTheMaximumAchievableNumber;

/// <summary>
///     https://leetcode.com/problems/find-the-maximum-achievable-number/
/// </summary>
public interface IFindTheMaximumAchievableNumber
{
    /// <summary>
    ///     Finds the maximum achievable number that can become equal to <paramref name="num" /> after applying at most
    ///     <paramref name="t" /> operations, where each operation increases or decreases the number by 1 while
    ///     simultaneously increasing or decreasing <paramref name="num" /> by 1.
    /// </summary>
    /// <param name="num">The target number.</param>
    /// <param name="t">The maximum number of operations allowed.</param>
    /// <returns>The maximum achievable number.</returns>
    int TheMaximumAchievableX(int num, int t);
}