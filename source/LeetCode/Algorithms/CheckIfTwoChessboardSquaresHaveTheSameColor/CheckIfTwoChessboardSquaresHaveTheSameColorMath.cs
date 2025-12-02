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
public class CheckIfTwoChessboardSquaresHaveTheSameColorMath : CheckIfTwoChessboardSquaresHaveTheSameColorBase
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="coordinate1"></param>
    /// <param name="coordinate2"></param>
    /// <returns></returns>
    public override bool CheckTwoChessboards(string coordinate1, string coordinate2)
    {
        var (x1, y1) = ParseCoordinate(coordinate1);
        var (x2, y2) = ParseCoordinate(coordinate2);

        return GetColor(x1, y1) == GetColor(x2, y2);
    }
}