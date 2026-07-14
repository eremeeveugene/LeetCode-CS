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

using LeetCode.Algorithms.WordsWithinTwoEditsOfDictionary;

namespace LeetCode.Tests.Algorithms.WordsWithinTwoEditsOfDictionary;

public abstract class WordsWithinTwoEditsOfDictionaryTestsBase<T> where T : IWordsWithinTwoEditsOfDictionary, new()
{
    [TestMethod]
    [DataRow(new[] { "word", "note", "ants", "wood" }, new[] { "wood", "joke", "moat" }, new[] { "word", "note", "wood" })]
    [DataRow(new[] { "yes" }, new[] { "not" }, new string[] { })]
    [DataRow(new[] { "abc", "def", "ghi" }, new[] { "abc", "def", "ghi" }, new[] { "abc", "def", "ghi" })]
    [DataRow(new[] { "abcd" }, new[] { "abcd" }, new[] { "abcd" })]
    [DataRow(new[] { "abcd" }, new[] { "xbcd" }, new[] { "abcd" })]
    [DataRow(new[] { "abcd" }, new[] { "xycd" }, new[] { "abcd" })]
    [DataRow(new[] { "abcd" }, new[] { "xyzd" }, new string[] { })]
    [DataRow(new[] { "abcd" }, new[] { "xyzw" }, new string[] { })]
    [DataRow(new[] { "a" }, new[] { "a" }, new[] { "a" })]
    [DataRow(new[] { "a" }, new[] { "b" }, new[] { "a" })]
    [DataRow(new[] { "ab" }, new[] { "cd" }, new[] { "ab" })]
    [DataRow(new[] { "abc" }, new[] { "xyz" }, new string[] { })]
    [DataRow(new[] { "hello", "world", "xelpo" }, new[] { "hello" }, new[] { "hello", "xelpo" })]
    [DataRow(new[] { "aaaa", "bbbb", "cccc" }, new[] { "aabb" }, new[] { "aaaa", "bbbb" })]
    [DataRow(new[] { "query", "tests", "abcde" }, new[] { "zzzzz" }, new string[] { })]
    [DataRow(new[] { "abcdef" }, new[] { "abcxyz", "xycdef" }, new[] { "abcdef" })]
    [DataRow(new[] { "abcdef" }, new[] { "xyzdef", "abcxyz" }, new string[] { })]
    [DataRow(new[] { "first", "secnd", "third" }, new[] { "first", "xxxxx", "third" }, new[] { "first", "third" })]
    public void TwoEditWords_WithQueriesAndDictionary_ReturnsQueriesMatchingDictionaryWithinTwoEdits(
        string[] queries,
        string[] words,
        string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TwoEditWords(queries, words).ToArray();

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}