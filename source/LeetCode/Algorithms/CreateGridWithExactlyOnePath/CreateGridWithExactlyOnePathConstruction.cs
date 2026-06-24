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

namespace LeetCode.Algorithms.CreateGridWithExactlyOnePath;

/// <inheritdoc />
public sealed class CreateGridWithExactlyOnePathConstruction : ICreateGridWithExactlyOnePath
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public string[] CreateGrid(int m, int n)
    {
        var grid = new string[m];

        var lastColumn = n - 1;

        Span<char> cells = stackalloc char[n];

        for (var row = 0; row < m; row++)
        {
            for (var column = 0; column < n; column++)
            {
                if (row == 0 || column == lastColumn)
                {
                    cells[column] = '.';
                }
                else
                {
                    cells[column] = '#';
                }
            }

            grid[row] = new string(cells);
        }

        return grid;
    }
}