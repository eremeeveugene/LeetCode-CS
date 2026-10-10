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

using LeetCode.Algorithms.RabbitsInForest;

namespace LeetCode.Tests.Algorithms.RabbitsInForest;

public abstract class RabbitsInForestTestsBase<T> where T : IRabbitsInForest, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 2 }, 5)]
    [DataRow(new[] { 10, 10, 10 }, 11)]
    [DataRow(new[] { 0 }, 1)]
    [DataRow(new[] { 1 }, 2)]
    [DataRow(new[] { 0, 0, 0 }, 3)]
    [DataRow(new[] { 1, 1 }, 2)]
    [DataRow(new[] { 1, 1, 1 }, 4)]
    [DataRow(new[] { 2, 2, 2, 2 }, 6)]
    [DataRow(new[] { 999 }, 1000)]
    [DataRow(new[] { 0, 1 }, 3)]
    [DataRow(new[] { 3, 3, 3, 3, 3 }, 8)]
    [DataRow(new[] { 1, 0, 1, 0, 0 }, 5)]
    [DataRow(new[] { 5, 5, 5, 5, 5, 5, 5 }, 12)]
    [DataRow(new[] { 2, 2, 2, 3, 3, 3, 3 }, 7)]
    [DataRow(new[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 }, 15)]
    [DataRow(new[] { 1, 2, 3 }, 9)]
    [DataRow(new[] { 0, 0, 1, 1, 1, 2, 2, 2, 2 }, 12)]
    [DataRow(new[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, 22)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2, 2 }, 9)]
    public void NumRabbits_WithAnswersArray_ReturnsMinimumPossibleCount(int[] answers, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumRabbits(answers);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void NumRabbits_WithMaxLengthAnswersArray_ReturnsMinimumPossibleCount()
    {
        // Arrange
        var solution = new T();

        var answers = new int[1000];

        for (var i = 0; i < answers.Length; i++)
        {
            answers[i] = 999;
        }

        // Act
        var actualResult = solution.NumRabbits(answers);

        // Assert
        Assert.AreEqual(1000, actualResult);
    }
}