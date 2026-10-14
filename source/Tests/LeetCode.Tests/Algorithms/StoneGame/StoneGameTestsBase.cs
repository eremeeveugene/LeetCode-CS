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

using LeetCode.Algorithms.StoneGame;

namespace LeetCode.Tests.Algorithms.StoneGame;

public abstract class StoneGameTestsBase<T> where T : IStoneGame, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 3, 4, 5 }, true)]
    [DataRow(new[] { 3, 7, 2, 3 }, true)]
    [DataRow(new[] { 1, 2 }, true)]
    [DataRow(new[] { 2, 1 }, true)]
    [DataRow(new[] { 1, 100 }, true)]
    [DataRow(new[] { 500, 499 }, true)]
    [DataRow(new[] { 3, 2, 10, 4 }, true)]
    [DataRow(new[] { 7, 7, 7, 8 }, true)]
    [DataRow(new[] { 1, 1, 1, 2 }, true)]
    [DataRow(new[] { 5, 4, 3, 2, 1, 2 }, true)]
    [DataRow(new[] { 10, 20, 30, 40, 50, 61 }, true)]
    [DataRow(new[] { 9, 1, 1, 1, 1, 2, 3, 5 }, true)]
    [DataRow(new[] { 6, 6, 6, 6, 6, 7 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 21 }, true)]
    [DataRow(new[] { 100, 1, 100, 1, 100, 1, 100, 2 }, true)]
    [DataRow(new[] { 8, 15, 3, 7 }, true)]
    [DataRow(new[] { 250, 250, 250, 251 }, true)]
    [DataRow(new[] { 4, 5 }, true)]
    [DataRow(new[] { 2, 2, 2, 3, 3, 3 }, true)]
    [DataRow(new[] { 2, 1, 2, 2 }, true)]
    [DataRow(new[] { 11, 3, 4, 8, 7, 2 }, true)]
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