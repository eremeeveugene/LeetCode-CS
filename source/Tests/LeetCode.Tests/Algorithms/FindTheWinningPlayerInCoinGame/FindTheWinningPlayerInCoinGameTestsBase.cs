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

using LeetCode.Algorithms.FindTheWinningPlayerInCoinGame;

namespace LeetCode.Tests.Algorithms.FindTheWinningPlayerInCoinGame;

public abstract class FindTheWinningPlayerInCoinGameTestsBase<T> where T : IFindTheWinningPlayerInCoinGame, new()
{
    [TestMethod]
    [DataRow(2, 7, "Alice")]
    [DataRow(4, 11, "Bob")]
    public void WinningPlayer_WithGivenMoveCountsAndStones_ReturnsCorrectWinner(int x, int y, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.WinningPlayer(x, y);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}