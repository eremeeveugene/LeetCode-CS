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

namespace LeetCode.Algorithms.SortTheMatrixDiagonally;

/// <inheritdoc />
public sealed class SortTheMatrixDiagonallyFrequencyArray : ISortTheMatrixDiagonally
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="mat"></param>
    /// <returns></returns>
    public int[][] DiagonalSort(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        var frequencyArray = new int[101];

        for (var row = 0; row < m; row++)
        {
            SortDiagonalCount(mat, row, 0, frequencyArray);
        }

        for (var column = 1; column < n; column++)
        {
            SortDiagonalCount(mat, 0, column, frequencyArray);
        }

        return mat;
    }

    private static void SortDiagonalCount(int[][] mat, int row, int column, int[] frequencyArray)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        var rowIndex = row;
        var columnIndex = column;

        while (rowIndex < m && columnIndex < n)
        {
            frequencyArray[mat[rowIndex][columnIndex]]++;

            rowIndex++;
            columnIndex++;
        }

        rowIndex = row;
        columnIndex = column;

        for (var frequency = 0; frequency < frequencyArray.Length; frequency++)
        {
            for (var count = frequencyArray[frequency]; count > 0; count--)
            {
                mat[rowIndex][columnIndex] = frequency;

                rowIndex++;
                columnIndex++;
            }
        }

        Array.Clear(frequencyArray, 0, frequencyArray.Length);
    }
}