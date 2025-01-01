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

using LeetCode.Algorithms.MaximumScoreAfterSplittingString;

namespace LeetCode.Tests.Algorithms.MaximumScoreAfterSplittingString;

public abstract class MaximumScoreAfterSplittingStringTestsBase<T> where T : IMaximumScoreAfterSplittingString, new()
{
    [TestMethod]
    [DataRow("1111", 3)]
    [DataRow("011101", 5)]
    [DataRow("00111", 5)]
    public void MaxScore_WithBinaryString_ReturnsMaximumScore(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxScore(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}