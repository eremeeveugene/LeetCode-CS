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
///     The first k moves remove 10 + 9 + ... + (11 - k) = k * (21 - k) / 2 stones. The number of moves made is the
///     largest k with k * (21 - k) / 2 &lt;= n, which is the floor of the smaller root of k^2 - 21k + 2n = 0, and Alice
///     wins exactly when that number is odd.
/// </remarks>
public sealed class StoneRemovalGameMath : IStoneRemovalGame
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanAliceWin(int n)
    {
        var discriminant = 441 - (8 * n);

        var discriminantSqrt = Math.Sqrt(discriminant);

        var movesCount = (int)((21 - discriminantSqrt) / 2);

        return movesCount % 2 == 1;
    }
}