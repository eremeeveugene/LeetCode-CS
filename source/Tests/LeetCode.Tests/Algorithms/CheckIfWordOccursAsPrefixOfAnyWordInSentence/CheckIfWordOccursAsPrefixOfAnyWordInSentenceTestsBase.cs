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

using LeetCode.Algorithms.CheckIfWordOccursAsPrefixOfAnyWordInSentence;

namespace LeetCode.Tests.Algorithms.CheckIfWordOccursAsPrefixOfAnyWordInSentence;

public abstract class CheckIfWordOccursAsPrefixOfAnyWordInSentenceTestsBase<T> where T : ICheckIfWordOccursAsPrefixOfAnyWordInSentence, new()
{
    [TestMethod]
    [DataRow("i love eating burger", "burg", 4)]
    [DataRow("this problem is an easy problem", "pro", 2)]
    [DataRow("i am tired", "you", -1)]
    [DataRow("hello world", "he", 1)]
    [DataRow("hello world", "wor", 2)]
    [DataRow("hello world", "world", 2)]
    [DataRow("hello world", "worlds", -1)]
    [DataRow("a", "a", 1)]
    [DataRow("a", "b", -1)]
    [DataRow("a b c d e", "e", 5)]
    [DataRow("a b c d e", "c", 3)]
    [DataRow("apple app application", "app", 1)]
    [DataRow("banana apple app", "app", 2)]
    [DataRow("dog cat dog", "dog", 1)]
    [DataRow("dog cat dog", "do", 1)]
    [DataRow("i love eating burger", "i", 1)]
    [DataRow("i love eating burger", "lo", 2)]
    [DataRow("i love eating burger", "eat", 3)]
    [DataRow("i love eating burger", "burgers", -1)]
    [DataRow("abc abcd abcde", "abcd", 2)]
    public void IsPrefixOfWord_WithSentenceAndSearchWord_ReturnsFirstMatchingWordIndexOrMinusOne(
        string sentence,
        string searchWord,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsPrefixOfWord(sentence, searchWord);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}