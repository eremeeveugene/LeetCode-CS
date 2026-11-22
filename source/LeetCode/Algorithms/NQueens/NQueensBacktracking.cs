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

namespace LeetCode.Algorithms.NQueens;

/// <inheritdoc />
public sealed class NQueensBacktracking : INQueens
{
    private const char Queen = 'Q';
    private const char EmptySquare = '.';

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n!)
    ///     Space complexity - O(n^2)
    /// </remarks>
    public IList<IList<string>> SolveNQueens(int n)
    {
        var result = new List<IList<string>>();

        Span<char> board = stackalloc char[n * n];

        board.Fill(EmptySquare);

        var diagonalsCount = (2 * n) - 1;

        Span<bool> occupiedColumns = stackalloc bool[n];
        Span<bool> occupiedDiagonals = stackalloc bool[diagonalsCount];
        Span<bool> occupiedAntiDiagonals = stackalloc bool[diagonalsCount];

        Backtrack(board, n, 0, occupiedColumns, occupiedDiagonals, occupiedAntiDiagonals, result);

        return result;
    }

    /// <summary>
    ///     Places a queen in every safe column of <paramref name="row" /> and recurses into the next row, recording
    ///     each complete placement in <paramref name="result" />.
    /// </summary>
    /// <param name="board">The board being filled, stored row by row as <paramref name="n" /> * <paramref name="n" /> squares.</param>
    /// <param name="n">The size of the board.</param>
    /// <param name="row">The row in which to place the next queen.</param>
    /// <param name="occupiedColumns">Flags marking columns that already hold a queen.</param>
    /// <param name="occupiedDiagonals">Flags marking top-left to bottom-right diagonals that already hold a queen.</param>
    /// <param name="occupiedAntiDiagonals">Flags marking top-right to bottom-left diagonals that already hold a queen.</param>
    /// <param name="result">The collection that receives every complete board.</param>
    /// <remarks>
    ///     Time complexity - O(n!)
    ///     Space complexity - O(n)
    /// </remarks>
    private static void Backtrack(
        Span<char> board,
        int n,
        int row,
        Span<bool> occupiedColumns,
        Span<bool> occupiedDiagonals,
        Span<bool> occupiedAntiDiagonals,
        List<IList<string>> result)
    {
        if (row == n)
        {
            var boardRows = BuildBoardRows(board, n);

            result.Add(boardRows);

            return;
        }

        for (var column = 0; column < n; column++)
        {
            var squareIndex = (row * n) + column;
            var diagonalIndex = row - column + n - 1;
            var antiDiagonalIndex = row + column;

            if (occupiedColumns[column] || occupiedDiagonals[diagonalIndex] || occupiedAntiDiagonals[antiDiagonalIndex])
            {
                continue;
            }

            board[squareIndex] = Queen;
            occupiedColumns[column] = true;
            occupiedDiagonals[diagonalIndex] = true;
            occupiedAntiDiagonals[antiDiagonalIndex] = true;

            Backtrack(board, n, row + 1, occupiedColumns, occupiedDiagonals, occupiedAntiDiagonals, result);

            board[squareIndex] = EmptySquare;
            occupiedColumns[column] = false;
            occupiedDiagonals[diagonalIndex] = false;
            occupiedAntiDiagonals[antiDiagonalIndex] = false;
        }
    }

    /// <summary>
    ///     Converts the character rows of <paramref name="board" /> into strings.
    /// </summary>
    /// <param name="board">The board to convert, stored row by row as <paramref name="n" /> * <paramref name="n" /> squares.</param>
    /// <param name="n">The size of the board.</param>
    /// <returns>The rows of <paramref name="board" /> as strings.</returns>
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </remarks>
    private static List<string> BuildBoardRows(ReadOnlySpan<char> board, int n)
    {
        var boardRows = new List<string>(n);

        for (var row = 0; row < n; row++)
        {
            var boardRow = board.Slice(row * n, n);

            boardRows.Add(new string(boardRow));
        }

        return boardRows;
    }
}