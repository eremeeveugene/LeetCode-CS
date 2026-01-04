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
public class ValidSudokuBoolTables : ValidSudokuBase
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </summary>
    /// <param name="board"></param>
    /// <returns></returns>
    public override bool IsValidSudoku(char[][] board)
    {
        Span<bool> rows = stackalloc bool[N * N];
        Span<bool> columns = stackalloc bool[N * N];
        Span<bool> boxes = stackalloc bool[N * N];

        for (var rowIndex = 0; rowIndex < N; rowIndex++)
        {
            var row = board[rowIndex];

            for (var columnIndex = 0; columnIndex < N; columnIndex++)
            {
                int cell = row[columnIndex];

                if (cell == EmptyCell)
                {
                    continue;
                }

                var cellIndex = GetCellIndex(cell);
                var boxIndex = GetBoxIndex(rowIndex, columnIndex);

                var rowSlot = (rowIndex * N) + cellIndex;
                var columnSlot = (columnIndex * N) + cellIndex;
                var boxSlot = (boxIndex * N) + cellIndex;

                if (rows[rowSlot] || columns[columnSlot] || boxes[boxSlot])
                {
                    return false;
                }

                rows[rowSlot] = true;
                columns[columnSlot] = true;
                boxes[boxSlot] = true;
            }
        }

        return true;
    }
}