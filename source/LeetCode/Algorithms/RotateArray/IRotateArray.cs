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

namespace LeetCode.Algorithms.RotateArray;

/// <summary>
///     https://leetcode.com/problems/rotate-array/description/
/// </summary>
public interface IRotateArray
{
    /// <summary>
    ///     Rotates <paramref name="nums" /> in place to the right by <paramref name="k" /> positions.
    /// </summary>
    /// <param name="nums">The array of integers to rotate in place.</param>
    /// <param name="k">The number of positions to rotate the array to the right.</param>
    void Rotate(int[] nums, int k);
}