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

namespace LeetCode.Algorithms.OnesAndZeroes;

/// <summary>
///     https://leetcode.com/problems/ones-and-zeroes/description/
/// </summary>
public interface IOnesAndZeroes
{
    /// <summary>
    ///     Finds the size of the largest subset of <paramref name="strs" /> that can be formed using at most
    ///     <paramref name="m" /> zeroes and at most <paramref name="n" /> ones in total.
    /// </summary>
    /// <param name="strs">The array of binary strings to choose a subset from.</param>
    /// <param name="m">The maximum total number of '0' characters available.</param>
    /// <param name="n">The maximum total number of '1' characters available.</param>
    /// <returns>The size of the largest subset of <paramref name="strs" /> satisfying the character budget.</returns>
    int FindMaxForm(string[] strs, int m, int n);
}