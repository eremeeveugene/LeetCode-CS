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

namespace LeetCode.Algorithms.FurthestPointFromOrigin;

/// <inheritdoc />
public sealed class FurthestPointFromOriginGreedy : IFurthestPointFromOrigin
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FurthestDistanceFromOrigin(string moves)
    {
        var count = 0;
        var jokerCount = 0;

        for (var i = 0; i < moves.Length; i++)
        {
            var move = moves[i];

            switch (move)
            {
                case 'L':
                    count++;
                    break;
                case 'R':
                    count--;
                    break;
                default:
                    jokerCount++;
                    break;
            }
        }

        return Math.Abs(count) + jokerCount;
    }
}