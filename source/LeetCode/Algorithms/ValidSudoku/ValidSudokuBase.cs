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
public abstract class ValidSudokuBase : IValidSudoku
{
    protected const char EmptyCell = '.';
    protected const int N = 9;

    public abstract bool IsValidSudoku(char[][] board);

    protected static int GetCellIndex(int cell)
    {
        return cell - '1';
    }

    protected static int GetBoxIndex(int rowIndex, int columnIndex)
    {
        return (rowIndex / 3 * 3) + (columnIndex / 3);
    }
}