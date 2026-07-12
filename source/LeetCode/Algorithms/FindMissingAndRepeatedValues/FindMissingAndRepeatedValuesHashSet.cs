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
public sealed class FindMissingAndRepeatedValuesHashSet : IFindMissingAndRepeatedValues
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </remarks>
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        var n = grid.Length * grid.Length;

        var repeatedNumber = 0;
        var missingNumber = n * (n + 1) / 2;

        var hashSet = new HashSet<int>();

        foreach (var row in grid)
        {
            foreach (var cell in row)
            {
                if (hashSet.Add(cell))
                {
                    missingNumber -= cell;
                }
                else
                {
                    repeatedNumber = cell;
                }
            }
        }

        return [repeatedNumber, missingNumber];
    }
}