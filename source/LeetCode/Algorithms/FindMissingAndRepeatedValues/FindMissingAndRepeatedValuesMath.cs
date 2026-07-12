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

namespace LeetCode.Algorithms.FindMissingAndRepeatedValues;

/// <inheritdoc />
public sealed class FindMissingAndRepeatedValuesMath : IFindMissingAndRepeatedValues
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        var n = grid.Length * grid.Length;

        var expectedSum = (long)n * (n + 1) / 2;
        var expectedSumSquares = (long)n * (n + 1) * ((2 * n) + 1) / 6;

        long actualSum = 0;
        long actualSumSquares = 0;

        foreach (var row in grid)
        {
            foreach (var num in row)
            {
                actualSum += num;
                actualSumSquares += (long)num * num;
            }
        }

        var diff = expectedSum - actualSum;
        var sumDiff = (expectedSumSquares - actualSumSquares) / diff;

        var missingNumber = (int)((diff + sumDiff) / 2);
        var repeatedNumber = (int)(sumDiff - missingNumber);

        return [repeatedNumber, missingNumber];
    }
}