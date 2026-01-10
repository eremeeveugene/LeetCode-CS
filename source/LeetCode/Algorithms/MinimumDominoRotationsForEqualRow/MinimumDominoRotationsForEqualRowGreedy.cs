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

namespace LeetCode.Algorithms.MinimumDominoRotationsForEqualRow;

/// <inheritdoc />
public sealed class MinimumDominoRotationsForEqualRowGreedy : IMinimumDominoRotationsForEqualRow
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="tops"></param>
    /// <param name="bottoms"></param>
    /// <returns></returns>
    public int MinDominoRotations(int[] tops, int[] bottoms)
    {
        var result = TryTarget(tops, bottoms, tops[0]);

        if (result != -1 || tops[0] == bottoms[0])
        {
            return result;
        }

        return TryTarget(tops, bottoms, bottoms[0]);
    }

    private static int TryTarget(int[] tops, int[] bottoms, int target)
    {
        var topRotations = 0;
        var bottomRotations = 0;

        for (var i = 0; i < tops.Length; i++)
        {
            if (tops[i] != target && bottoms[i] != target)
            {
                return -1;
            }

            if (tops[i] != target)
            {
                topRotations++;
            }

            if (bottoms[i] != target)
            {
                bottomRotations++;
            }
        }

        return Math.Min(topRotations, bottomRotations);
    }
}