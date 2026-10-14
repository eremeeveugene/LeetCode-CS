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

using LeetCode.Algorithms.BaseballGame;

namespace LeetCode.Tests.Algorithms.BaseballGame;

public abstract class BaseballGameTestsBase<T> where T : IBaseballGame, new()
{
    [TestMethod]
    [DataRow(new[] { "5", "2", "C", "D", "+" }, 30)]
    [DataRow(new[] { "5", "-2", "4", "C", "D", "9", "+", "+" }, 27)]
    [DataRow(new[] { "1" }, 1)]
    [DataRow(new[] { "1", "C" }, 0)]
    [DataRow(new[] { "1", "D" }, 3)]
    [DataRow(new[] { "1", "2", "+" }, 6)]
    [DataRow(new[] { "1", "2", "3", "+" }, 11)]
    [DataRow(new[] { "10", "D", "D" }, 70)]
    [DataRow(new[] { "-1", "D" }, -3)]
    [DataRow(new[] { "-5", "-3", "+" }, -16)]
    [DataRow(new[] { "1", "2", "C", "C" }, 0)]
    [DataRow(new[] { "3", "C", "4", "D" }, 12)]
    [DataRow(new[] { "1", "1", "+", "+", "+" }, 12)]
    [DataRow(new[] { "2", "D", "C", "D" }, 6)]
    [DataRow(new[] { "5", "10", "+", "C" }, 15)]
    [DataRow(new[] { "0" }, 0)]
    [DataRow(new[] { "0", "D", "+" }, 0)]
    [DataRow(new[] { "30000", "D" }, 90000)]
    [DataRow(new[] { "-30000", "-30000", "+" }, -120000)]
    [DataRow(new[] { "1", "2", "3", "C", "C", "C" }, 0)]
    [DataRow(new[] { "7", "C", "8", "C", "9" }, 9)]
    [DataRow(new[] { "1", "2", "3", "4", "+", "+" }, 28)]
    [DataRow(new[] { "4", "-2", "D", "+" }, -8)]
    [DataRow(new[] { "6", "D", "+", "D" }, 72)]
    public void CalPoints_WithOperationsArray_ReturnsTotalPoints(string[] operations, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CalPoints(operations);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}