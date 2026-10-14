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

using LeetCode.Algorithms.AliceAndBobPlayingFlowerGame;

namespace LeetCode.Tests.Algorithms.AliceAndBobPlayingFlowerGame;

public abstract class AliceAndBobPlayingFlowerGameTestsBase<T> where T : IAliceAndBobPlayingFlowerGame, new()
{
    [TestMethod]
    [DataRow(3, 2, 3)]
    [DataRow(1, 1, 0)]
    [DataRow(1, 2, 1)]
    [DataRow(2, 1, 1)]
    [DataRow(2, 2, 2)]
    [DataRow(3, 3, 4)]
    [DataRow(4, 4, 8)]
    [DataRow(5, 5, 12)]
    [DataRow(10, 10, 50)]
    [DataRow(1, 100, 50)]
    [DataRow(100, 1, 50)]
    [DataRow(100000, 100000, 5000000000)]
    [DataRow(99999, 100000, 4999950000)]
    [DataRow(7, 3, 10)]
    [DataRow(6, 5, 15)]
    [DataRow(1, 3, 1)]
    [DataRow(3, 1, 1)]
    [DataRow(2, 3, 3)]
    [DataRow(8, 9, 36)]
    [DataRow(11, 13, 71)]
    public void FlowerGame_WithFirstAndSecondLaneFlowerCounts_ReturnsTotalWinningPairsForAlice(int n, int m, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FlowerGame(n, m);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}