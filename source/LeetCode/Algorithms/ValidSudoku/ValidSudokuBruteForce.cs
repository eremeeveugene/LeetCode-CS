// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class ValidSudokuBruteForce : ValidSudokuBase
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="board"></param>
    /// <returns></returns>
    public override bool IsValidSudoku(char[][] board)
    {
        Span<bool> seen = stackalloc bool[N];

        return AreValidRows(seen, board) &&
               AreValidColumns(seen, board) &&
               AreValidBoxes(seen, board);
    }

    private static bool AreValidRows(scoped Span<bool> seen, char[][] board)
    {
        for (var row = 0; row < N; row++)
        {
            for (var column = 0; column < N; column++)
            {
                if (!TryInsert(seen, board[row][column]))
                {
                    return false;
                }
            }

            seen.Clear();
        }

        return true;
    }

    private static bool AreValidColumns(scoped Span<bool> seen, char[][] board)
    {
        for (var column = 0; column < N; column++)
        {
            for (var row = 0; row < N; row++)
            {
                if (!TryInsert(seen, board[row][column]))
                {
                    return false;
                }
            }

            seen.Clear();
        }

        return true;
    }

    private static bool AreValidBoxes(scoped Span<bool> seen, char[][] board)
    {
        for (var boxRow = 0; boxRow < N; boxRow += 3)
        {
            for (var boxColumn = 0; boxColumn < N; boxColumn += 3)
            {
                for (var row = boxRow; row < boxRow + 3; row++)
                {
                    for (var column = boxColumn; column < boxColumn + 3; column++)
                    {
                        if (!TryInsert(seen, board[row][column]))
                        {
                            return false;
                        }
                    }
                }

                seen.Clear();
            }
        }

        return true;
    }

    private static bool TryInsert(scoped Span<bool> seen, int cell)
    {
        if (cell == EmptyCell)
        {
            return true;
        }

        var cellIndex = GetCellIndex(cell);

        if (seen[cellIndex])
        {
            return false;
        }

        seen[cellIndex] = true;

        return true;
    }
}