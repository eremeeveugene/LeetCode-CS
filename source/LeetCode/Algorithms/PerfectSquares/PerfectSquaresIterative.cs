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

namespace LeetCode.Algorithms.PerfectSquares;

/// <inheritdoc />
public class PerfectSquaresIterative : IPerfectSquares
{
    /// <summary>
    ///     Time complexity - O(n sqrt(n))
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int NumSquares(int n)
    {
        var dp = new int[n + 1];

        for (var i = 0; i <= n; i++)
        {
            dp[i] = int.MaxValue;
        }

        dp[0] = 0;

        for (var i = 1; i <= n; i++)
        {
            for (var j = 1; j * j <= i; j++)
            {
                dp[i] = Math.Min(dp[i], dp[i - (j * j)] + 1);
            }
        }

        return dp[n];
    }
}