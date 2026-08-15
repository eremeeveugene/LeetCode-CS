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

namespace LeetCode.Algorithms.AvailableCapturesForRook;

/// <inheritdoc />
public sealed class AvailableCapturesForRookSimulation : IAvailableCapturesForRook
{
    private const int BoardSize = 8;
    private const char Rook = 'R';
    private const char Bishop = 'B';
    private const char Pawn = 'p';

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumRookCaptures(char[][] board)
    {
        var rookRow = 0;
        var rookColumn = 0;

        for (var i = 0; i < BoardSize; i++)
        {
            var row = board[i];

            for (var j = 0; j < BoardSize; j++)
            {
                var cell = row[j];

                if (cell != Rook)
                {
                    continue;
                }

                rookRow = i;
                rookColumn = j;

                break;
            }
        }

        var captures = 0;

        captures += CountCapturesInDirection(board, rookRow, rookColumn, -1, 0);
        captures += CountCapturesInDirection(board, rookRow, rookColumn, 1, 0);
        captures += CountCapturesInDirection(board, rookRow, rookColumn, 0, -1);
        captures += CountCapturesInDirection(board, rookRow, rookColumn, 0, 1);

        return captures;
    }

    private static int CountCapturesInDirection(char[][] board, int rookRow, int rookColumn, int rowStep, int columnStep)
    {
        var row = rookRow + rowStep;
        var column = rookColumn + columnStep;

        while (row is >= 0 and < BoardSize && column is >= 0 and < BoardSize)
        {
            var cell = board[row][column];

            switch (cell)
            {
                case Bishop:
                    return 0;
                case Pawn:
                    return 1;
                default:
                    row += rowStep;
                    column += columnStep;
                    break;
            }
        }

        return 0;
    }
}