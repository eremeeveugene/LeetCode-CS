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
public static class CountingBitsDynamicProgramming
{
    /// <summary>
    ///     Time complexity - O (n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int[] GetResult(int n)
    {
        int[] result = new int[n + 1];

        for (int i = 1; i < n + 1; i++)
        {
            result[i] = result[i & (i - 1)] + 1;
        }

        return result;
    }
}