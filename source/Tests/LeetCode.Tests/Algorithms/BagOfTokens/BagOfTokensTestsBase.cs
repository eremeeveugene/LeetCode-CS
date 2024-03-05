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

using LeetCode.Algorithms.BagOfTokens;

namespace LeetCode.Tests.Algorithms.BagOfTokens;

public abstract class BagOfTokensTestsBase<T> where T : IBagOfTokens, new()
{
    [TestMethod]
    [DataRow(new[] { 100 }, 50, 0)]
    [DataRow(new[] { 200, 100 }, 150, 1)]
    [DataRow(new[] { 100, 200, 300, 400 }, 200, 2)]
    public void BagOfTokensScore_WithTokensAndPower_ReturnsExpectedScore(int[] tokens, int power, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.BagOfTokensScore(tokens, power);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}