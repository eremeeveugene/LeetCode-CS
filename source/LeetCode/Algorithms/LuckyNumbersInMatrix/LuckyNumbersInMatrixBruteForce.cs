// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class LuckyNumbersInMatrixBruteForce : ILuckyNumbersInMatrix
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        var minRowItems = matrix.Select(row => row.Min());

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

        var maxColumnItems = transposedMatrix.Select(column => column.Max());
        var maxColumnItemsHashSet = new HashSet<int>(maxColumnItems);

        return minRowItems.Where(maxColumnItemsHashSet.Contains).ToArray();
    }
}