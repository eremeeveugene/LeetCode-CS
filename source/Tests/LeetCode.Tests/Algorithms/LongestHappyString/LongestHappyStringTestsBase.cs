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

using LeetCode.Algorithms.LongestHappyString;

namespace LeetCode.Tests.Algorithms.LongestHappyString;

public abstract class LongestHappyStringTestsBase<T> where T : ILongestHappyString, new()
{
    [TestMethod]
    [DataRow(1, 1, 7, "ccbccacc")]
    [DataRow(7, 1, 0, "aabaa")]
    public void LongestDiverseString_WithCharacterCounts_ReturnsLongestPossibleString(int a, int b, int c,
        string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestDiverseString(a, b, c);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}