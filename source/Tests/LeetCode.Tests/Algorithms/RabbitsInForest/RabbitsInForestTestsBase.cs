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
    public void NumRabbits_WithAnswersArray_ReturnsMinimumPossibleCount(int[] answers, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumRabbits(answers);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}