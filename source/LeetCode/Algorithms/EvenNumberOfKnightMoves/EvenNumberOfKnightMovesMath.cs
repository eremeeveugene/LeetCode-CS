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

namespace LeetCode.Algorithms.EvenNumberOfKnightMoves;

/// <inheritdoc />
public sealed class EvenNumberOfKnightMovesMath : IEvenNumberOfKnightMoves
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanReach(int[] start, int[] target)
    {
        var startX = start[0];
        var startY = start[1];

        var targetX = target[0];
        var targetY = target[1];

        var sum = startX - targetX + startY - targetY;

        return sum % 2 == 0;
    }
}