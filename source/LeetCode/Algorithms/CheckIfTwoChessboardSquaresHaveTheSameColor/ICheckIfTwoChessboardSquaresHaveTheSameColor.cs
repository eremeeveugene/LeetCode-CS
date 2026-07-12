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

/// <summary>
///     https://leetcode.com/problems/check-if-two-chessboard-squares-have-the-same-color/description/
/// </summary>
public interface ICheckIfTwoChessboardSquaresHaveTheSameColor
{
    /// <summary>
    ///     Determines whether the chessboard squares <paramref name="coordinate1" /> and <paramref name="coordinate2" />
    ///     have the same color.
    /// </summary>
    /// <param name="coordinate1">The coordinate of the first square.</param>
    /// <param name="coordinate2">The coordinate of the second square.</param>
    /// <returns><c>true</c> if both squares have the same color; otherwise, <c>false</c>.</returns>
    bool CheckTwoChessboards(string coordinate1, string coordinate2);
}