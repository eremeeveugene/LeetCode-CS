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

namespace LeetCode.Algorithms.RangeAddition2;

/// <inheritdoc />
public class RangeAddition2Greedy : IRangeAddition2
{
    /// <summary>
    ///     Time complexity - O(n), where n is the length of ops
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <param name="ops"></param>
    /// <returns></returns>
    public int MaxCount(int m, int n, int[][] ops)
    {
        for (var i = 0; i < ops.Length; i++)
        {
            var op = ops[i];

            var a = op[0];
            var b = op[1];

            m = Math.Min(m, a);
            n = Math.Min(n, b);
        }

        return m * n;
    }
}