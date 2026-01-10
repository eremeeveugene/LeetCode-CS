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

namespace LeetCode.Algorithms.FindTheWinningPlayerInCoinGame;

/// <inheritdoc />
public sealed class FindTheWinningPlayerInCoinGameSimulation : IFindTheWinningPlayerInCoinGame
{
    /// <summary>
    ///     Time complexity - O(min(x,y))
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public string WinningPlayer(int x, int y)
    {
        var moves = 0;

        while (x > 0 && y > 3)
        {
            x -= 1;
            y -= 4;

            moves++;
        }

        return moves % 2 == 1 ? "Alice" : "Bob";
    }
}