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
public sealed class FindTheWinningPlayerInCoinGameMath : IFindTheWinningPlayerInCoinGame
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public string WinningPlayer(int x, int y)
    {
        var rounds = Math.Min(x, y / 4);

        return rounds % 2 == 1 ? "Alice" : "Bob";
    }
}