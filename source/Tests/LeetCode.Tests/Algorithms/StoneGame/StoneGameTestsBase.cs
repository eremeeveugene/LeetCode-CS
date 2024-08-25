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

using LeetCode.Algorithms.StoneGame;

namespace LeetCode.Tests.Algorithms.StoneGame;

public abstract class StoneGameTestsBase<T> where T : IStoneGame, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 3, 4, 5 }, true)]
    [DataRow(new[] { 3, 7, 2, 3 }, true)]
    public void StoneGame_WithGivenPiles_ReturnsTrueWhenFirstPlayerWins(int[] piles, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.StoneGame(piles);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}