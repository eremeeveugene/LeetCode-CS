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

namespace LeetCode.Algorithms.StoneRemovalGame;

/// <inheritdoc />
public sealed class StoneRemovalGameSimulation : IStoneRemovalGame
{
    private const int FirstMoveStones = 10;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanAliceWin(int n)
    {
        var remainingStones = n;
        var stonesToRemove = FirstMoveStones;
        var isAliceTurn = true;

        while (remainingStones >= stonesToRemove)
        {
            remainingStones -= stonesToRemove;

            stonesToRemove--;

            isAliceTurn = !isAliceTurn;
        }

        return !isAliceTurn;
    }
}