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

using LeetCode.Algorithms.CountTheNumberOfConsistentStrings;

namespace LeetCode.Tests.Algorithms.CountTheNumberOfConsistentStrings;

public abstract class CountTheNumberOfConsistentStringsTestsBase<T> where T : ICountTheNumberOfConsistentStrings, new()
{
    [TestMethod]
    [DataRow("ab", new[] { "ad", "bd", "aaab", "baa", "badab" }, 2)]
    [DataRow("abc", new[] { "a", "b", "c", "ab", "ac", "bc", "abc" }, 7)]
    [DataRow("cad", new[] { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" }, 4)]
    [DataRow("a", new[] { "a", "aa", "aaa" }, 3)]
    [DataRow("a", new[] { "b", "ab", "ba" }, 0)]
    [DataRow("abc", new[] { "abc", "cba", "abcd", "d" }, 2)]
    [DataRow("z", new[] { "z", "zz", "y" }, 2)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", new[] { "hello", "world", "leetcode" }, 3)]
    [DataRow("xy", new[] { "x", "y", "xy", "yx", "xyz", "xxyyx" }, 5)]
    [DataRow("ab", new[] { "a" }, 1)]
    [DataRow("ab", new[] { "c" }, 0)]
    [DataRow("cd", new[] { "cdcdcd", "cdc", "dcdd", "cde" }, 3)]
    [DataRow("mnop", new[] { "mop", "mnopq", "pom", "nnn", "qqq" }, 3)]
    [DataRow("qwerty", new[] { "query", "tree", "ret", "type", "wry" }, 3)]
    [DataRow("ba", new[] { "abba", "baab", "bbaa", "abc" }, 3)]
    [DataRow("lt", new[] { "let", "lt", "tl", "tt", "l" }, 4)]
    [DataRow("aeiou", new[] { "audio", "queue", "aei", "eau", "sky" }, 2)]
    [DataRow("fgh", new[] { "fgh", "hgf", "ffff", "hhhg", "fghi" }, 4)]
    [DataRow("d", new[] { "d", "dd", "ddd", "dddd" }, 4)]
    [DataRow("pq", new[] { "p", "q", "pp", "qq", "pq", "qp", "r" }, 6)]
    public void CountConsistentStrings_WithAllowedCharactersAndWords_ReturnsNumberOfConsistentStrings(
        string allowed,
        string[] words,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountConsistentStrings(allowed, words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}