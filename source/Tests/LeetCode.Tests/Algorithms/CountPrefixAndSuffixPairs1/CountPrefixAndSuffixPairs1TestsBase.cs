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

using LeetCode.Algorithms.CountPrefixAndSuffixPairs1;

namespace LeetCode.Tests.Algorithms.CountPrefixAndSuffixPairs1;

public abstract class CountPrefixAndSuffixPairs1TestsBase<T> where T : ICountPrefixAndSuffixPairs1, new()
{
    [TestMethod]
    [DataRow(new[] { "a", "aba", "ababa", "aa" }, 4)]
    [DataRow(new[] { "pa", "papa", "ma", "mama" }, 2)]
    [DataRow(new[] { "abab", "ab" }, 0)]
    [DataRow(new[] { "a" }, 0)]
    [DataRow(new[] { "a", "a" }, 1)]
    [DataRow(new[] { "ab", "ab" }, 1)]
    [DataRow(new[] { "abc", "abc", "abc" }, 3)]
    [DataRow(new[] { "a", "b", "c" }, 0)]
    [DataRow(new[] { "ab", "cab" }, 0)]
    [DataRow(new[] { "ab", "abab" }, 1)]
    [DataRow(new[] { "x", "x", "x", "x" }, 6)]
    [DataRow(new[] { "ab", "cdab" }, 0)]
    [DataRow(new[] { "a", "aa", "aaa" }, 3)]
    [DataRow(new[] { "ab", "aab", "aaab" }, 0)]
    [DataRow(new[] { "aa", "aaaa" }, 1)]
    [DataRow(new[] { "abc", "abcabc" }, 1)]
    [DataRow(new[] { "ab", "ab", "ab", "ab" }, 6)]
    [DataRow(new[] { "hello", "worldhello" }, 0)]
    [DataRow(new[] { "cat", "catcat" }, 1)]
    [DataRow(new[] { "ab", "cd", "ef" }, 0)]
    public void CountPrefixSuffixPairs_WithStringArray_ReturnsNumberOfValidPrefixAndSuffixPairs(string[] words, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountPrefixSuffixPairs(words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}