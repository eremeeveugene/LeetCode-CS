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

using LeetCode.Algorithms.MaximumNumberOfWordsYouCanType;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfWordsYouCanType;

public abstract class MaximumNumberOfWordsYouCanTypeTestsBase<T> where T : IMaximumNumberOfWordsYouCanType, new()
{
    [TestMethod]
    [DataRow("hello world", "ad", 1)]
    [DataRow("leet code", "lt", 1)]
    [DataRow("leet code", "e", 0)]
    public void CanBeTypedWords_WithGivenTextAndBrokenLetters_ReturnsExpectedCount(string text, string brokenLetters,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanBeTypedWords(text, brokenLetters);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}