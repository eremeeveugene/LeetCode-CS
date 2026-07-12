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

namespace LeetCode.Algorithms.FindLuckyIntegerInAnArray;

/// <summary>
///     https://leetcode.com/problems/find-lucky-integer-in-an-array/description/
/// </summary>
public interface IFindLuckyIntegerInAnArray
{
    /// <summary>
    ///     Finds the largest lucky integer in <paramref name="arr" />, where a lucky integer is one whose frequency in the
    ///     array equals its value.
    /// </summary>
    /// <param name="arr">The array of integers.</param>
    /// <returns>The largest lucky integer, or -1 if none exists.</returns>
    int FindLucky(int[] arr);
}