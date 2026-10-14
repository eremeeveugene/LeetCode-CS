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

using LeetCode.Algorithms.CountingWordsWithGivenPrefix;

namespace LeetCode.Tests.Algorithms.CountingWordsWithGivenPrefix;

public abstract class CountingWordsWithGivenPrefixTestsBase<T> where T : ICountingWordsWithGivenPrefix, new()
{
    [TestMethod]
    [DataRow(new[] { "pay", "attention", "practice", "attend" }, "at", 2)]
    [DataRow(new[] { "leetcode", "win", "loops", "success" }, "code", 0)]
    [DataRow(new[] { "a" }, "a", 1)]
    [DataRow(new[] { "a" }, "b", 0)]
    [DataRow(new[] { "abc" }, "abc", 1)]
    [DataRow(new[] { "abc" }, "abcd", 0)]
    [DataRow(new[] { "abc", "abd", "abe" }, "ab", 3)]
    [DataRow(new[] { "abc", "abd", "abe" }, "abd", 1)]
    [DataRow(new[] { "apple", "app", "apply", "ap", "a" }, "app", 3)]
    [DataRow(new[] { "apple", "app", "apply", "ap", "a" }, "a", 5)]
    [DataRow(new[] { "banana", "bandana", "bandit" }, "ban", 3)]
    [DataRow(new[] { "banana", "bandana", "bandit" }, "band", 2)]
    [DataRow(new[] { "xyz", "xy", "x" }, "xyz", 1)]
    [DataRow(new[] { "cat", "dog", "bird" }, "z", 0)]
    [DataRow(new[] { "aaa", "aa", "a", "aaaa" }, "aa", 3)]
    [DataRow(new[] { "prefix", "pre", "prelude", "present", "repre" }, "pre", 4)]
    [DataRow(new[] { "leetcode", "leet", "code" }, "leet", 2)]
    [DataRow(new[] { "same", "same", "same" }, "same", 3)]
    [DataRow(new[] { "tester", "test", "testing", "attest" }, "test", 3)]
    [DataRow(new[] { "ba", "bab", "bb" }, "bab", 1)]
    public void PrefixCount_WithWordsArrayAndPrefix_ReturnsCountOfMatchingWords(string[] words, string pref, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PrefixCount(words, pref);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}