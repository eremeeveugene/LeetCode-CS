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

using LeetCode.Algorithms.FindResultantArrayAfterRemovingAnagrams;

namespace LeetCode.Tests.Algorithms.FindResultantArrayAfterRemovingAnagrams;

public abstract class FindResultantArrayAfterRemovingAnagramsTestsBase<T> where T : IFindResultantArrayAfterRemovingAnagrams, new()
{
    [TestMethod]
    [DataRow(new[] { "abba", "baba", "bbaa", "cd", "cd" }, new[] { "abba", "cd" })]
    [DataRow(new[] { "a", "b", "c", "d", "e" }, new[] { "a", "b", "c", "d", "e" })]
    [DataRow(new[] { "a" }, new[] { "a" })]
    [DataRow(new[] { "a", "a" }, new[] { "a" })]
    [DataRow(new[] { "ab", "ba" }, new[] { "ab" })]
    [DataRow(new[] { "ab", "ba", "ab" }, new[] { "ab" })]
    [DataRow(new[] { "abc", "bca", "cab", "xyz" }, new[] { "abc", "xyz" })]
    [DataRow(new[] { "a", "b", "a" }, new[] { "a", "b", "a" })]
    [DataRow(new[] { "abc", "def", "fed", "cba" }, new[] { "abc", "def", "cba" })]
    [DataRow(new[] { "z", "z", "z", "z" }, new[] { "z" })]
    [DataRow(new[] { "listen", "silent", "enlist", "google", "gogole" }, new[] { "listen", "google" })]
    [DataRow(new[] { "aab", "aba", "baa", "abb" }, new[] { "aab", "abb" })]
    [DataRow(new[] { "a", "b", "ab", "ba", "c" }, new[] { "a", "b", "ab", "c" })]
    [DataRow(new[] { "abc", "abd", "abc" }, new[] { "abc", "abd", "abc" })]
    [DataRow(new[] { "x", "y", "z" }, new[] { "x", "y", "z" })]
    [DataRow(new[] { "aa", "a" }, new[] { "aa", "a" })]
    [DataRow(new[] { "abcd", "dcba", "bacd", "abcd", "abce" }, new[] { "abcd", "abce" })]
    [DataRow(new[] { "ba", "ab", "ba", "ab" }, new[] { "ba" })]
    [DataRow(new[] { "tt", "tt", "t" }, new[] { "tt", "t" })]
    [DataRow(new[] { "ab", "cd", "dc", "ab", "ba" }, new[] { "ab", "cd", "ab" })]
    public void RemoveAnagrams_WithWordsArray_RemovesAllSubsequentAnagramDuplicates(string[] words, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveAnagrams(words);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}