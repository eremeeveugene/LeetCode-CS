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

using LeetCode.Algorithms.StoneGame2;

namespace LeetCode.Tests.Algorithms.StoneGame2;

public abstract class StoneGame2TestsBase<T> where T : IStoneGame2, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 2, 7, 9, 4, 4 }, 10)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 100 }, 104)]
    [DataRow(new[] { 100, 10, 100, 100, 100, 100 }, 300)]
    public void StoneGameII_WithGivenPiles_ReturnsMaxPossibleScore(int[] piles, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.StoneGameII(piles);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}