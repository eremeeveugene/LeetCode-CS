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

namespace LeetCode.Algorithms.DesignSpreadsheet;

/// <inheritdoc />
public sealed class DesignSpreadsheetMatrix : IDesignSpreadsheet
{
    private const int Columns = 'Z' - 'A' + 1;

    private readonly int[,] _spreadsheet;

    /// <summary>
    ///     Time complexity - O(n), where n is rows
    ///     Space complexity - O(n), where n is rows
    /// </summary>
    /// <param name="rows"></param>
    public DesignSpreadsheetMatrix(int rows)
    {
        _spreadsheet = new int[rows, Columns];
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m), where m is the cell length
    ///     Space complexity - O(1)
    /// </remarks>
    public void SetCell(string cell, int value)
    {
        var (row, column) = ParseCell(cell, 0, cell.Length);

        _spreadsheet[row, column] = value;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m), where m is the cell length
    ///     Space complexity - O(1)
    /// </remarks>
    public void ResetCell(string cell)
    {
        SetCell(cell, 0);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m), where m is the formula length
    ///     Space complexity - O(1)
    /// </remarks>
    public int GetValue(string formula)
    {
        var indexOfPlus = formula.IndexOf('+');

        var left = ParseToken(formula, 1, indexOfPlus);

        var right = ParseToken(formula, indexOfPlus + 1, formula.Length);

        return left + right;
    }

    /// <summary>
    ///     Time complexity - O(m), where m is the s length
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    private int ParseToken(string s, int start, int end)
    {
        if (char.IsDigit(s[start]))
        {
            return ParseValue(s, start, end);
        }

        var (row, column) = ParseCell(s, start, end);

        return _spreadsheet[row, column];
    }

    /// <summary>
    ///     Time complexity - O(m), where m is the length of the s string
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    private static (int Row, int Column) ParseCell(string s, int start, int end)
    {
        var column = s[start] - 'A';

        var row = ParseValue(s, start + 1, end) - 1;

        return (row, column);
    }

    /// <summary>
    ///     Time complexity - O(m), where m is the s length
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    private static int ParseValue(string s, int start, int end)
    {
        var value = 0;

        for (var i = start; i < end; i++)
        {
            var c = s[i];

            value = (value * 10) + (c - '0');
        }

        return value;
    }
}