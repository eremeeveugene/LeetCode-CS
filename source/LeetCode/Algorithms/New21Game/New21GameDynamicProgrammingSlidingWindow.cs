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

namespace LeetCode.Algorithms.New21Game;

/// <inheritdoc />
public class New21GameDynamicProgrammingSlidingWindow : INew21Game
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <param name="maxPts"></param>
    /// <returns></returns>
    public double New21Game(int n, int k, int maxPts)
    {
        if (k == 0 || n >= k - 1 + maxPts)
        {
            return 1;
        }

        var dp = new double[n + 1];

        dp[0] = 1.0;

        var windowSum = 0.0;
        var result = 0.0;

        for (var score = 1; score <= n; score++)
        {
            if (score - 1 < k)
            {
                windowSum += dp[score - 1];
            }

            var outgoing = score - 1 - maxPts;

            if (outgoing >= 0 && outgoing < k)
            {
                windowSum -= dp[outgoing];
            }

            dp[score] = windowSum / maxPts;

            if (score >= k)
            {
                result += dp[score];
            }
        }

        return result;
    }
}