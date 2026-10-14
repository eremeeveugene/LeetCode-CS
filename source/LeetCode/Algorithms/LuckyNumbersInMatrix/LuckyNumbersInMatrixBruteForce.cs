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

namespace LeetCode.Algorithms.LuckyNumbersInMatrix;

/// <inheritdoc />
public sealed class LuckyNumbersInMatrixBruteForce : ILuckyNumbersInMatrix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        var minRowItems = new int[matrix.Length];

        for (var i = 0; i < matrix.Length; i++)
        {
            var row = matrix[i];
            var minRowItem = row[0];

            for (var j = 1; j < row.Length; j++)
            {
                minRowItem = Math.Min(minRowItem, row[j]);
            }

            minRowItems[i] = minRowItem;
        }

        var transposedMatrix = new int[matrix[0].Length][];

        for (var i = 0; i < matrix[0].Length; i++)
        {
            transposedMatrix[i] = new int[matrix.Length];
        }

        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[0].Length; j++)
            {
                transposedMatrix[j][i] = matrix[i][j];
            }
        }

        var maxColumnItemsHashSet = new HashSet<int>();

        for (var i = 0; i < transposedMatrix.Length; i++)
        {
            var column = transposedMatrix[i];
            var maxColumnItem = column[0];

            for (var j = 1; j < column.Length; j++)
            {
                maxColumnItem = Math.Max(maxColumnItem, column[j]);
            }

            maxColumnItemsHashSet.Add(maxColumnItem);
        }

        var luckyNumbers = new List<int>();

        for (var i = 0; i < minRowItems.Length; i++)
        {
            var minRowItem = minRowItems[i];

            if (maxColumnItemsHashSet.Contains(minRowItem))
            {
                luckyNumbers.Add(minRowItem);
            }
        }

        return luckyNumbers;
    }
}