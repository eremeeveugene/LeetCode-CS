// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.CountingBits;

/// <summary>
///     https://leetcode.com/problems/counting-bits/
/// </summary>
public static class CountingBitsIterative
{
    /// <summary>
    ///     Time complexity - O (n log n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int[] GetResult(int n)
    {
        var result = new int[n + 1];

        for (var i = 0; i < n + 1; i++)
        {
            result[i] = Convert.ToString(i, 2).Count(b => b.Equals('1'));
        }

        return result;
    }
}