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

using LeetCode.Algorithms.MergeStringsAlternately;

namespace LeetCode.Tests.Algorithms.MergeStringsAlternately;

public abstract class MergeStringsAlternatelyTestsBase<T> where T : IMergeStringsAlternately, new()
{
    [TestMethod]
    [DataRow("abc", "pqr", "apbqcr")]
    [DataRow("ab", "pqrs", "apbqrs")]
    [DataRow("abcd", "pq", "apbqcd")]
    [DataRow("a", "b", "ab")]
    [DataRow("a", "bcdef", "abcdef")]
    [DataRow("abcdef", "z", "azbcdef")]
    [DataRow("x", "x", "xx")]
    [DataRow("ab", "ab", "aabb")]
    [DataRow("abc", "d", "adbc")]
    [DataRow("a", "bc", "abc")]
    [DataRow("hello", "world", "hweolrllod")]
    [DataRow("zzzz", "aaaa", "zazazaza")]
    [DataRow("ace", "bdfhij", "abcdefhij")]
    [DataRow("abcdefghij", "kl", "akblcdefghij")]
    [DataRow("q", "wertyuiop", "qwertyuiop")]
    [DataRow("lm", "nopqr", "lnmopqr")]
    [DataRow("aaa", "bbb", "ababab")]
    [DataRow("ab", "cdefgh", "acbdefgh")]
    [DataRow("short", "averyveryverylongword", "sahvoerrtyveryverylongword")]
    [DataRow("xyz", "x", "xxyz")]
    public void MergeAlternately_WithTwoStrings_ReturnsMergedString(string word1, string word2, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MergeAlternately(word1, word2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}