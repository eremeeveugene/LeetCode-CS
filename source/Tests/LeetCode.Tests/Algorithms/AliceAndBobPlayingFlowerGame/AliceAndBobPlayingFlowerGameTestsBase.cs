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

using LeetCode.Algorithms.AliceAndBobPlayingFlowerGame;

namespace LeetCode.Tests.Algorithms.AliceAndBobPlayingFlowerGame;

public abstract class AliceAndBobPlayingFlowerGameTestsBase<T> where T : IAliceAndBobPlayingFlowerGame, new()
{
    [TestMethod]
    [DataRow(3, 2, 3)]
    [DataRow(1, 1, 0)]
    public void FlowerGame_WithFirstAndSecondLaneFlowerCounts_ReturnsTotalWinningPairsForAlice(int n, int m,
        long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FlowerGame(n, m);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}