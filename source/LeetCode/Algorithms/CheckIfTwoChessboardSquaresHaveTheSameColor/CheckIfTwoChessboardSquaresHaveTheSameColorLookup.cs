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

namespace LeetCode.Algorithms.CheckIfTwoChessboardSquaresHaveTheSameColor;

/// <inheritdoc />
public sealed class CheckIfTwoChessboardSquaresHaveTheSameColorLookup : CheckIfTwoChessboardSquaresHaveTheSameColorBase
{
    private const int BoardSize = 8;
    private static readonly bool[,] CellsLookup = CreateCellsLookup();

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public override bool CheckTwoChessboards(string coordinate1, string coordinate2)
    {
        var (x1, y1) = ParseCoordinate(coordinate1);
        var (x2, y2) = ParseCoordinate(coordinate2);

        return CellsLookup[x1, y1] == CellsLookup[x2, y2];
    }

    private static bool[,] CreateCellsLookup()
    {
        var cells = new bool[BoardSize, BoardSize];

        for (var x = 0; x < BoardSize; x++)
        {
            for (var y = 0; y < BoardSize; y++)
            {
                cells[x, y] = GetColor(x, y);
            }
        }

        return cells;
    }
}