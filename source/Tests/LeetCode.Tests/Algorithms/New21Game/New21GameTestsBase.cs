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
    [DataRow(5, 0, 10, 1)]
    [DataRow(1, 0, 1, 1)]
    [DataRow(1, 1, 1, 1)]
    [DataRow(0, 0, 1, 1)]
    [DataRow(5, 5, 5, 0.41472)]
    [DataRow(10, 5, 3, 1)]
    [DataRow(100, 50, 10, 1)]
    [DataRow(30, 20, 10, 1)]
    [DataRow(2, 2, 2, 0.75)]
    [DataRow(50, 25, 20, 1)]
    [DataRow(7, 4, 5, 0.9424)]
    [DataRow(15, 10, 10, 0.80426)]
    [DataRow(20, 0, 5, 1)]
    [DataRow(100, 100, 1, 1)]
    [DataRow(100, 99, 2, 1)]
    [DataRow(300, 200, 20, 1)]
    [DataRow(1000, 500, 50, 1)]
    [DataRow(5, 3, 2, 1)]
    [DataRow(12, 6, 4, 1)]
    [DataRow(75, 60, 6, 1)]
    [DataRow(40, 30, 25, 0.66193)]
    [DataRow(3, 3, 3, 0.59259)]
    [DataRow(10, 8, 5, 0.81359)]
    [DataRow(20, 15, 10, 0.82942)]
    [DataRow(30, 25, 12, 0.72664)]
    [DataRow(100, 90, 20, 0.78569)]
    [DataRow(50, 40, 15, 0.91635)]
    [DataRow(200, 150, 100, 0.76687)]
    [DataRow(500, 400, 200, 0.75113)]
    [DataRow(1000, 900, 300, 0.55927)]
    [DataRow(60, 50, 30, 0.59951)]
    [DataRow(9, 3, 10, 0.847)]
    [DataRow(1, 1, 2, 0.5)]
    [DataRow(3, 2, 3, 0.88889)]
    [DataRow(25, 20, 10, 0.81425)]
    public void New21Game_WithPointsThresholdAndMaxPoints_ReturnsProbabilityOfPointsNotExceedingLimit(int n, int k, int maxPts, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = Math.Round(solution.New21Game(n, k, maxPts), 5);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}