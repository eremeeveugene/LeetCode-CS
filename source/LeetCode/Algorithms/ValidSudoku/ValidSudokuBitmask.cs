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

namespace LeetCode.Algorithms.ValidSudoku;

/// <inheritdoc />
public class ValidSudokuBitmask : ValidSudokuBase
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="board"></param>
    /// <returns></returns>
    public override bool IsValidSudoku(char[][] board)
    {
        Span<int> rows = stackalloc int[N];
        Span<int> columns = stackalloc int[N];
        Span<int> boxes = stackalloc int[N];

        for (var rowIndex = 0; rowIndex < N; rowIndex++)
        {
            var row = board[rowIndex];

            for (var columnIndex = 0; columnIndex < N; columnIndex++)
            {
                var cell = row[columnIndex];

                if (cell == EmptyCell)
                {
                    continue;
                }

                var cellIndex = GetCellIndex(cell);

                var bit = 1 << cellIndex;

                var boxIndex = GetBoxIndex(rowIndex, columnIndex);

                if (HasSeen(rows[rowIndex], bit) ||
                    HasSeen(columns[columnIndex], bit) ||
                    HasSeen(boxes[boxIndex], bit))
                {
                    return false;
                }

                rows[rowIndex] |= bit;
                columns[columnIndex] |= bit;
                boxes[boxIndex] |= bit;
            }
        }

        return true;
    }

    private static bool HasSeen(int mask, int bit)
    {
        return (mask & bit) != 0;
    }
}