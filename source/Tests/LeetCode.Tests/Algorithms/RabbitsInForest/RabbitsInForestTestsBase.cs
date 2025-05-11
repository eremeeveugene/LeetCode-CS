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

using LeetCode.Algorithms.RabbitsInForest;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RabbitsInForest;

public abstract class RabbitsInForestTestsBase<T> where T : IRabbitsInForest, new()
{
    [TestMethod]
    [DataRow("[1,1,2]", 5)]
    [DataRow("[10,10,10]", 11)]
    public void NumRabbits_WithAnswersArray_ReturnsMinimumPossibleCount(string answersJson, int expectedResult)
    {
        // Arrange
        var answers = JsonHelper<int[]>.Parse(answersJson);

        var solution = new T();

        // Act
        var actualResult = solution.NumRabbits(answers);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}