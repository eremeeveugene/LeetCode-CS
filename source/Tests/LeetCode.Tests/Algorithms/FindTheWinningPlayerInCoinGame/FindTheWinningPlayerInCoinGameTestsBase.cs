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

using LeetCode.Algorithms.FindTheWinningPlayerInCoinGame;

namespace LeetCode.Tests.Algorithms.FindTheWinningPlayerInCoinGame;

public abstract class FindTheWinningPlayerInCoinGameTestsBase<T> where T : IFindTheWinningPlayerInCoinGame, new()
{
    [TestMethod]
    [DataRow(2, 7, "Alice")]
    [DataRow(4, 11, "Bob")]
    [DataRow(1, 100, "Alice")]
    [DataRow(2, 100, "Bob")]
    [DataRow(3, 100, "Alice")]
    [DataRow(4, 100, "Bob")]
    [DataRow(1, 3, "Bob")]
    [DataRow(1, 7, "Alice")]
    [DataRow(100, 4, "Alice")]
    [DataRow(100, 8, "Bob")]
    [DataRow(5, 20, "Alice")]
    [DataRow(5, 19, "Bob")]
    [DataRow(1, 4, "Alice")]
    [DataRow(2, 4, "Alice")]
    [DataRow(2, 8, "Bob")]
    [DataRow(3, 4, "Alice")]
    [DataRow(3, 8, "Bob")]
    [DataRow(3, 12, "Alice")]
    [DataRow(10, 4, "Alice")]
    [DataRow(7, 3, "Bob")]
    public void WinningPlayer_WithCoinCounts_ReturnsPlayerName(int x, int y, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.WinningPlayer(x, y);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}