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

using LeetCode.Algorithms.MaximumNumberOfWordsYouCanType;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfWordsYouCanType;

public abstract class MaximumNumberOfWordsYouCanTypeTestsBase<T> where T : IMaximumNumberOfWordsYouCanType, new()
{
    [TestMethod]
    [DataRow("hello world", "ad", 1)]
    [DataRow("leet code", "lt", 1)]
    [DataRow("leet code", "e", 0)]
    [DataRow("a", "", 1)]
    [DataRow("a", "a", 0)]
    [DataRow("a b c", "b", 2)]
    [DataRow("abc def ghi", "xyz", 3)]
    [DataRow("abc def ghi", "cfi", 0)]
    [DataRow("hello world", "z", 2)]
    [DataRow("hello world", "lo", 0)]
    [DataRow("aa bb cc", "abc", 0)]
    [DataRow("apple banana cherry", "q", 3)]
    [DataRow("apple banana cherry", "n", 2)]
    [DataRow("the quick brown fox", "aeiou", 0)]
    [DataRow("the quick brown fox", "z", 4)]
    [DataRow("a a a a a", "a", 0)]
    [DataRow("a a a a a", "b", 5)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", "", 1)]
    [DataRow("abcdefghijklmnopqrstuvwxyz abc", "z", 1)]
    [DataRow("x y z", "abcdefghijklmnopqrstuvw", 3)]
    public void CanBeTypedWords_WithTextAndBrokenLetters_ReturnsCountOfWordsWithoutBrokenCharacters(
        string text,
        string brokenLetters,
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