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

using LeetCode.Algorithms.New21Game;

namespace LeetCode.Tests.Algorithms.New21Game;

public abstract class New21GameTestsBase<T> where T : INew21Game, new()
{
    [TestMethod]
    [DataRow(10, 1, 10, 1)]
    [DataRow(6, 1, 10, 0.6)]
    [DataRow(21, 17, 10, 0.73278)]
    public void New21Game_WithPointsThresholdAndMaxPoints_ReturnsProbabilityOfPointsNotExceedingLimit(int n,
        int k, int maxPts, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = Math.Round(solution.New21Game(n, k, maxPts), 5);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}