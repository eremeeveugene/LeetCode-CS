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

namespace LeetCode.Algorithms.RotateFunction;

/// <summary>
///     https://leetcode.com/problems/rotate-function/description/
/// </summary>
public interface IRotateFunction
{
    /// <summary>
    ///     Finds the maximum value of the rotation function among all clockwise rotations of the specified array.
    /// </summary>
    /// <param name="nums">The integer array used to calculate rotation function values.</param>
    /// <returns>
    ///     The maximum value among F(0), F(1), ..., F(n - 1), where n is the length of <paramref name="nums" />.
    /// </returns>
    int MaxRotateFunction(int[] nums);
}