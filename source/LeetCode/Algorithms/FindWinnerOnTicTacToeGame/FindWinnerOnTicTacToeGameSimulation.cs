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

namespace LeetCode.Algorithms.FindWinnerOnTicTacToeGame;

/// <inheritdoc />
public sealed class FindWinnerOnTicTacToeGameSimulation : IFindWinnerOnTicTacToeGame
{
    private const int GridSize = 3;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="moves"></param>
    /// <returns></returns>
    public string Tictactoe(int[][] moves)
    {
        var rowSum = new int[GridSize];
        var columnSum = new int[GridSize];
        var leftDiagonalSum = 0;
        var rightDiagonalSum = 0;

        for (var i = 0; i < moves.Length; i++)
        {
            var value = i % 2 == 0 ? 1 : -1;

            var row = moves[i][0];
            var col = moves[i][1];

            rowSum[row] += value;
            columnSum[col] += value;

            if (row == col)
            {
                leftDiagonalSum += value;
            }

            if (row + col == GridSize - 1)
            {
                rightDiagonalSum += value;
            }

            if (Math.Abs(rowSum[row]) == GridSize || Math.Abs(columnSum[col]) == GridSize || Math.Abs(leftDiagonalSum) == GridSize ||
                Math.Abs(rightDiagonalSum) == GridSize)
            {
                return value == 1 ? "A" : "B";
            }
        }

        return moves.Length == GridSize * GridSize ? "Draw" : "Pending";
    }
}