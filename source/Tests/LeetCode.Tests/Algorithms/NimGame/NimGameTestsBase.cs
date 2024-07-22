// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.NimGame;

namespace LeetCode.Tests.Algorithms.NimGame;

public abstract class NimGameTestsBase<T> where T : INimGame, new()
{
    [TestMethod]
    [DataRow(1, true)]
    [DataRow(2, true)]
    [DataRow(3, true)]
    [DataRow(4, false)]
    [DataRow(5, true)]
    [DataRow(6, true)]
    [DataRow(7, true)]
    [DataRow(8, false)]
    public void CanWinNim_WithStartingNumber_ReturnsCorrectOutcome(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanWinNim(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}