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

namespace LeetCode.Algorithms.CanIWin;

/// <inheritdoc />
public class CanIWinDynamicProgramming : ICanIWin
{
    /// <summary>
    ///     Time complexity - O(n * 2^n)
    ///     Space complexity - O(2^n)
    /// </summary>
    /// <param name="maxChoosableInteger"></param>
    /// <param name="desiredTotal"></param>
    /// <returns></returns>
    public bool CanIWin(int maxChoosableInteger, int desiredTotal)
    {
        if (desiredTotal == 0)
        {
            return true;
        }

        if (desiredTotal > maxChoosableInteger * (maxChoosableInteger + 1) / 2)
        {
            return false;
        }

        return CanWinPlayer(maxChoosableInteger, 1, 0, desiredTotal, new int[1 << maxChoosableInteger]) == 1;
    }

    private static int CanWinPlayer(int n, int player, int selectedMask, int rest, int[] dp)
    {
        if (dp[selectedMask] != 0)
        {
            return dp[selectedMask];
        }

        for (int i = 1, mask = 1; i <= n; i++, mask <<= 1)
        {
            if ((selectedMask & mask) > 0)
            {
                continue;
            }

            if (rest - i <= 0)
            {
                return dp[selectedMask] = player;
            }

            if (-player != CanWinPlayer(n, -player, selectedMask | mask, rest - i, dp))
            {
                return dp[selectedMask] = player;
            }
        }

        return dp[selectedMask] = -player;
    }
}