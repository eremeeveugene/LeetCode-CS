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

using LeetCode.Algorithms.BagOfTokens;

namespace LeetCode.Tests.Algorithms.BagOfTokens;

public abstract class BagOfTokensTestsBase<T> where T : IBagOfTokens, new()
{
    [TestMethod]
    [DataRow(new[] { 100 }, 50, 0)]
    [DataRow(new[] { 200, 100 }, 150, 1)]
    [DataRow(new[] { 100, 200, 300, 400 }, 200, 2)]
    [DataRow(new int[] { }, 100, 0)]
    [DataRow(new[] { 50 }, 50, 1)]
    [DataRow(new[] { 50 }, 49, 0)]
    [DataRow(new[] { 100 }, 100, 1)]
    [DataRow(new[] { 100, 200 }, 300, 2)]
    [DataRow(new[] { 71, 55, 82 }, 54, 0)]
    [DataRow(new[] { 26 }, 51, 1)]
    [DataRow(new[] { 25, 50, 75 }, 50, 1)]
    [DataRow(new[] { 100, 200, 300, 400 }, 300, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, 3)]
    [DataRow(new[] { 10, 20 }, 5, 0)]
    [DataRow(new[] { 5, 5, 5 }, 10, 2)]
    [DataRow(new[] { 5, 5, 5 }, 15, 3)]
    [DataRow(new[] { 1000, 2000, 3000 }, 5000, 2)]
    [DataRow(new[] { 100, 200, 300 }, 0, 0)]
    [DataRow(new[] { 10000, 10000 }, 10000, 1)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2, 2)]
    [DataRow(new[] { 3, 9, 5, 2 }, 6, 2)]
    [DataRow(new[] { 2, 4, 6, 8 }, 7, 2)]
    [DataRow(new[] { 50, 100, 150, 200 }, 250, 2)]
    public void BagOfTokensScore_WithTokensAndInitialPower_ReturnsMaximumScore(int[] tokens, int power, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.BagOfTokensScore(tokens, power);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}