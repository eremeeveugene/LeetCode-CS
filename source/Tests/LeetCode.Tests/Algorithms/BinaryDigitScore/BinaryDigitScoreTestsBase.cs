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

using LeetCode.Algorithms.BinaryDigitScore;

namespace LeetCode.Tests.Algorithms.BinaryDigitScore;

public abstract class BinaryDigitScoreTestsBase<T> where T : IBinaryDigitScore, new()
{
    [TestMethod]
    [DataRow(14, 6, 6)]
    [DataRow(5, 15, 2)]
    [DataRow(10, 12, 4)]
    [DataRow(1, 1, 1)]
    [DataRow(1, 100, 3)]
    [DataRow(100, 1, 3)]
    [DataRow(7, 7, 9)]
    [DataRow(63, 63, 36)]
    [DataRow(63, 1, 6)]
    [DataRow(1, 63, 6)]
    [DataRow(3, 7, 1)]
    [DataRow(7, 3, 6)]
    [DataRow(64, 95, 6)]
    [DataRow(95, 64, 6)]
    [DataRow(2, 3, 2)]
    [DataRow(3, 2, 2)]
    [DataRow(31, 3, 10)]
    [DataRow(3, 31, 2)]
    [DataRow(15, 7, 12)]
    [DataRow(7, 15, 1)]
    [DataRow(85, 42, 12)]
    [DataRow(42, 85, 1)]
    [DataRow(99, 8, 4)]
    [DataRow(8, 99, 4)]
    [DataRow(6, 9, 4)]
    [DataRow(63, 31, 30)]
    [DataRow(31, 63, 1)]
    public void CalculateScore_WithAAndB_ReturnsScore(int a, int b, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CalculateScore(a, b);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}