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

using LeetCode.Algorithms.FindWinnerOnTicTacToeGame;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindWinnerOnTicTacToeGame;

public abstract class FindWinnerOnTicTacToeGameTestsBase<T> where T : IFindWinnerOnTicTacToeGame, new()
{
    [TestMethod]
    [DataRow("[[0,0],[2,0],[1,1],[2,1],[2,2]]", "A")]
    [DataRow("[[0,0],[1,1],[0,1],[0,2],[1,0],[2,0]]", "B")]
    [DataRow("[[0,0],[1,1],[2,0],[1,0],[1,2],[2,1],[0,1],[0,2],[2,2]]", "Draw")]
    public void Tictactoe_WithMoveSequence_ReturnsGameOutcome(string movesJsonArray, string expectedResult)
    {
        // Arrange
        var moves = JsonHelper<int>.DeserializeToJaggedArray(movesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.Tictactoe(moves);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}