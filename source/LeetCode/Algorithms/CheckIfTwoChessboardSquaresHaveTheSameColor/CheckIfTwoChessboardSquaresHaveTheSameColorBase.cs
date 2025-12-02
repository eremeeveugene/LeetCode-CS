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

namespace LeetCode.Algorithms.CheckIfTwoChessboardSquaresHaveTheSameColor;

/// <inheritdoc />
public abstract class CheckIfTwoChessboardSquaresHaveTheSameColorBase : ICheckIfTwoChessboardSquaresHaveTheSameColor
{
    public abstract bool CheckTwoChessboards(string coordinate1, string coordinate2);

    protected static (int X, int Y) ParseCoordinate(string coordinate)
    {
        var x = coordinate[0] - 'a';
        var y = coordinate[1] - '1';

        return (x, y);
    }

    protected static bool GetColor(int x, int y)
    {
        return (x + y) % 2 == 1;
    }
}