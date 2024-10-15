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

using LeetCode.Algorithms.SeparateBlackAndWhiteBalls;

namespace LeetCode.Tests.Algorithms.SeparateBlackAndWhiteBalls;

public abstract class SeparateBlackAndWhiteBallsTestsBase<T> where T : ISeparateBlackAndWhiteBalls, new()
{
    [TestMethod]
    [DataRow("101", 1)]
    [DataRow("100", 2)]
    [DataRow("0111", 0)]
    public void MinimumSteps_WithBinaryString_ReturnsStepCount(string s, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumSteps(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}