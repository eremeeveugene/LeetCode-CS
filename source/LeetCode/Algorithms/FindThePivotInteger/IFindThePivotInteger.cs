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

namespace LeetCode.Algorithms.FindThePivotInteger;

/// <summary>
///     https://leetcode.com/problems/find-the-pivot-integer/
/// </summary>
public interface IFindThePivotInteger
{
    /// <summary>
    ///     Finds the pivot integer <c>x</c> in the range <c>[1, n]</c> such that the sum of all integers from <c>1</c> to <c>x</c> equals the sum of all
    ///     integers from <c>x</c> to <paramref name="n" />.
    /// </summary>
    /// <param name="n">The upper bound of the range to search.</param>
    /// <returns>The pivot integer if one exists; otherwise, <c>-1</c>.</returns>
    int PivotInteger(int n);
}