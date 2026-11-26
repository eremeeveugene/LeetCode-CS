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
/// <remarks>
///     The thresholds 10, 19, 27, 34, 40, 45 and 49 are the running totals 10, 10 + 9, 10 + 9 + 8 and so on. Each one
///     makes one more move possible, so the winner alternates between consecutive thresholds.
/// </remarks>
public sealed class StoneRemovalGameSwitch : IStoneRemovalGame
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanAliceWin(int n)
    {
        return n switch
        {
            < 10 => false,
            < 19 => true,
            < 27 => false,
            < 34 => true,
            < 40 => false,
            < 45 => true,
            < 49 => false,
            _ => true
        };
    }
}