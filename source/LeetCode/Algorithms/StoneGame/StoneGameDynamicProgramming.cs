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

namespace LeetCode.Algorithms.StoneGame;

/// <inheritdoc />
public class StoneGameDynamicProgramming : IStoneGame
{
    /// <summary>
    ///     Time complexity - O(piles.Length^2)
    ///     Space complexity - O(piles.Length^2)
    /// </summary>
    /// <param name="piles"></param>
    /// <returns></returns>
    public bool StoneGame(int[] piles)
    {
        var dp = new int[piles.Length, piles.Length];

        for (var i = 0; i < piles.Length; i++)
        {
            dp[i, i] = piles[i];
        }

        for (var length = 2; length <= piles.Length; length++)
        {
            for (var i = 0; i <= piles.Length - length; i++)
            {
                var j = i + length - 1;

                dp[i, j] = Math.Max(piles[i] - dp[i + 1, j], piles[j] - dp[i, j - 1]);
            }
        }

        return dp[0, piles.Length - 1] > 0;
    }
}