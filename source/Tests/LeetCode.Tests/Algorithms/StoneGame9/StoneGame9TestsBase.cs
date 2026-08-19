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

using LeetCode.Algorithms.StoneGame9;

namespace LeetCode.Tests.Algorithms.StoneGame9;

public abstract class StoneGame9TestsBase<T> where T : IStoneGame9, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1 }, true)]
    [DataRow(new[] { 2 }, false)]
    [DataRow(new[] { 5, 1, 2, 4, 3 }, false)]
    [DataRow(new[] { 3 }, false)]
    [DataRow(new[] { 3, 3, 1, 2 }, true)]
    [DataRow(new[] { 3, 1, 1 }, false)]
    [DataRow(new[] { 3, 1, 1, 1 }, true)]
    [DataRow(new[] { 6, 2, 5, 8 }, true)]
    [DataRow(new[] { 1 }, false)]
    [DataRow(new[] { 1, 1 }, false)]
    [DataRow(new[] { 1, 1, 1 }, false)]
    [DataRow(new[] { 1, 2, 3 }, false)]
    [DataRow(new[] { 1, 2, 3, 6 }, true)]
    [DataRow(new[] { 1, 4, 7, 2 }, true)]
    [DataRow(new[] { 2, 5, 8, 1 }, true)]
    [DataRow(new[] { 3, 6, 9, 1, 1, 1 }, true)]
    [DataRow(new[] { 3, 6, 9, 1, 1 }, false)]
    [DataRow(new[] { 3, 6, 9, 2, 2, 2 }, true)]
    [DataRow(new[] { 3, 6, 9, 2, 2 }, false)]
    [DataRow(new[] { 3, 6, 1, 1, 1, 1 }, false)]
    [DataRow(new[] { 3, 6, 1, 2 }, true)]
    [DataRow(new[] { 10_000, 9_999, 2 }, false)]
    [DataRow(new[] { 10_000, 9_998 }, true)]
    [DataRow(new[] { 3, 1, 1, 1, 2 }, false)]
    [DataRow(new[] { 3, 2, 2, 2, 2, 1 }, true)]
    public void StoneGameIX_WithGivenStones_ReturnsWhetherAliceWins(int[] stones, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.StoneGameIX(stones);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}