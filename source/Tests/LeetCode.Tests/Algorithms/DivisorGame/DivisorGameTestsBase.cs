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

using LeetCode.Algorithms.DivisorGame;

namespace LeetCode.Tests.Algorithms.DivisorGame;

public abstract class DivisorGameTestsBase<T> where T : IDivisorGame, new()
{
    [TestMethod]
    [DataRow(1, false)]
    [DataRow(2, true)]
    [DataRow(3, false)]
    [DataRow(4, true)]
    [DataRow(9, false)]
    [DataRow(5, false)]
    [DataRow(6, true)]
    [DataRow(7, false)]
    [DataRow(8, true)]
    [DataRow(10, true)]
    [DataRow(11, false)]
    [DataRow(12, true)]
    [DataRow(13, false)]
    [DataRow(16, true)]
    [DataRow(17, false)]
    [DataRow(20, true)]
    [DataRow(31, false)]
    [DataRow(100, true)]
    [DataRow(101, false)]
    [DataRow(500, true)]
    public void DivisorGame_WithStartingNumber_ReturnsWinningOutcome(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DivisorGame(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}