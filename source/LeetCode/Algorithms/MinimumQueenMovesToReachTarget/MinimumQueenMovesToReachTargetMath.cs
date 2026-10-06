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

namespace LeetCode.Algorithms.MinimumQueenMovesToReachTarget;

/// <inheritdoc />
public sealed class MinimumQueenMovesToReachTargetMath : IMinimumQueenMovesToReachTarget
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinQueenMoves(int[] source, int[] target)
    {
        var sourceRow = source[0];
        var sourceColumn = source[1];

        var targetRow = target[0];
        var targetColumn = target[1];

        var isSameRow = IsSameRow(sourceRow, targetRow);
        var isSameColumn = IsSameColumn(sourceColumn, targetColumn);

        if (isSameRow && isSameColumn)
        {
            return 0;
        }

        if (isSameRow || isSameColumn)
        {
            return 1;
        }

        return IsSameDiagonal(sourceRow, sourceColumn, targetRow, targetColumn) ? 1 : 2;
    }

    /// <summary>
    ///     Determines whether the source and target are in the same row.
    /// </summary>
    /// <param name="sourceRow">The source row.</param>
    /// <param name="targetRow">The target row.</param>
    /// <returns><c>true</c> if the rows are equal; otherwise, <c>false</c>.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsSameRow(int sourceRow, int targetRow)
    {
        return sourceRow == targetRow;
    }

    /// <summary>
    ///     Determines whether the source and target are in the same column.
    /// </summary>
    /// <param name="sourceColumn">The source column.</param>
    /// <param name="targetColumn">The target column.</param>
    /// <returns><c>true</c> if the columns are equal; otherwise, <c>false</c>.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsSameColumn(int sourceColumn, int targetColumn)
    {
        return sourceColumn == targetColumn;
    }

    /// <summary>
    ///     Determines whether the source and target lie on the same diagonal.
    /// </summary>
    /// <param name="sourceRow">The source row.</param>
    /// <param name="sourceColumn">The source column.</param>
    /// <param name="targetRow">The target row.</param>
    /// <param name="targetColumn">The target column.</param>
    /// <returns><c>true</c> if the row and column distances are equal; otherwise, <c>false</c>.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsSameDiagonal(int sourceRow, int sourceColumn, int targetRow, int targetColumn)
    {
        var rowDistance = Math.Abs(sourceRow - targetRow);
        var columnDistance = Math.Abs(sourceColumn - targetColumn);

        return rowDistance == columnDistance;
    }
}