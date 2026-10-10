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

using LeetCode.Algorithms.FindWordsContainingCharacter;

namespace LeetCode.Tests.Algorithms.FindWordsContainingCharacter;

public abstract class FindWordsContainingCharacterTestsBase<T> where T : IFindWordsContainingCharacter, new()
{
    [TestMethod]
    [DataRow(new[] { "leet", "code" }, 'e', new[] { 0, 1 })]
    [DataRow(new[] { "abc", "bcd", "aaaa", "cbc" }, 'a', new[] { 0, 2 })]
    [DataRow(new[] { "abc", "bcd", "aaaa", "cbc" }, 'z', new int[] { })]
    [DataRow(new[] { "a" }, 'a', new[] { 0 })]
    [DataRow(new[] { "a" }, 'b', new int[] { })]
    [DataRow(new[] { "abc" }, 'c', new[] { 0 })]
    [DataRow(new[] { "abc", "def" }, 'f', new[] { 1 })]
    [DataRow(new[] { "abc", "def" }, 'x', new int[] { })]
    [DataRow(new[] { "hello", "world", "leetcode" }, 'o', new[] { 0, 1, 2 })]
    [DataRow(new[] { "hello", "world", "leetcode" }, 'l', new[] { 0, 1, 2 })]
    [DataRow(new[] { "aaa", "aa", "a" }, 'a', new[] { 0, 1, 2 })]
    [DataRow(new[] { "abc", "bcd", "cde" }, 'c', new[] { 0, 1, 2 })]
    [DataRow(new[] { "abc", "bcd", "cde" }, 'e', new[] { 2 })]
    [DataRow(new[] { "z", "y", "x", "w" }, 'y', new[] { 1 })]
    [DataRow(new[] { "apple", "banana", "cherry", "date" }, 'a', new[] { 0, 1, 3 })]
    [DataRow(new[] { "apple", "banana", "cherry", "date" }, 'e', new[] { 0, 2, 3 })]
    [DataRow(new[] { "apple", "banana", "cherry", "date" }, 'r', new[] { 2 })]
    [DataRow(new[] { "abcdefghijklmnopqrstuvwxyz", "zyx", "abc" }, 'z', new[] { 0, 1 })]
    [DataRow(new[] { "qwerty", "asdf", "zxcv" }, 's', new[] { 1 })]
    [DataRow(new[] { "same", "same", "same" }, 'm', new[] { 0, 1, 2 })]
    public void FindWordsContaining_WithArrayOfWordsAndChar_ReturnsIndicesOfWordsContainingChar(string[] words, char x, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualWords = solution.FindWordsContaining(words, x);
        var actualResult = new int[actualWords.Count];

        actualWords.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}