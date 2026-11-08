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

using LeetCode.Algorithms.ScoreValidator;

namespace LeetCode.Tests.Algorithms.ScoreValidator;

public abstract class ScoreValidatorTestsBase<T> where T : IScoreValidator, new()
{
    [TestMethod]
    [DataRow(new[] { "1", "4", "W", "6", "WD" }, new[] { 12, 1 })]
    [DataRow(new[] { "WD", "NB", "0", "4", "4" }, new[] { 10, 0 })]
    [DataRow(new[] { "W", "W", "W", "W", "W", "W", "W", "W", "W", "W", "W" }, new[] { 0, 10 })]
    [DataRow(new[] { "0" }, new[] { 0, 0 })]
    [DataRow(new[] { "6" }, new[] { 6, 0 })]
    [DataRow(new[] { "W" }, new[] { 0, 1 })]
    [DataRow(new[] { "WD" }, new[] { 1, 0 })]
    [DataRow(new[] { "NB" }, new[] { 1, 0 })]
    [DataRow(new[] { "1", "2", "3", "4", "6" }, new[] { 16, 0 })]
    [DataRow(new[] { "6", "6", "6", "6", "6", "6" }, new[] { 36, 0 })]
    [DataRow(new[] { "W", "W", "W", "W", "W", "W", "W", "W", "W", "W", "6" }, new[] { 0, 10 })]
    [DataRow(new[] { "W", "W", "W", "W", "W", "W", "W", "W", "W", "6" }, new[] { 6, 9 })]
    [DataRow(new[] { "4", "W", "4", "W", "4", "W", "4", "W", "4", "W", "4", "W", "4", "W", "4", "W", "4", "W", "4", "W", "4" }, new[] { 40, 10 })]
    [DataRow(new[] { "W", "WD", "W", "NB", "W", "0" }, new[] { 2, 3 })]
    [DataRow(new[] { "3", "3", "3" }, new[] { 9, 0 })]
    [DataRow(new[] { "NB", "NB", "NB", "WD", "WD" }, new[] { 5, 0 })]
    [DataRow(new[] { "2", "W", "2", "W", "2" }, new[] { 6, 2 })]
    [DataRow(new[] { "W", "W", "W", "W", "W", "W", "W", "W", "W", "W" }, new[] { 0, 10 })]
    [DataRow(new[] { "6", "W", "W", "W", "W", "W", "W", "W", "W", "W", "W", "6", "6" }, new[] { 6, 10 })]
    [DataRow(new[] { "1", "0", "1", "0", "W" }, new[] { 2, 1 })]
    [DataRow(new[] { "WD", "W", "6", "W", "NB", "W", "4" }, new[] { 12, 3 })]
    [DataRow(new[] { "0", "0", "0", "0" }, new[] { 0, 0 })]
    [DataRow(new[] { "W", "W", "W", "W", "W", "6", "W", "W", "W", "W", "W", "WD" }, new[] { 6, 10 })]
    [DataRow(new[] { "3", "NB", "2", "WD", "1" }, new[] { 8, 0 })]
    public void ScoreValidator_WithEvents_ReturnsScoreAndCounter(string[] events, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ScoreValidator(events);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}