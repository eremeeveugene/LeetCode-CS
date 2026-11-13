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

using LeetCode.Algorithms.CountValidSubstringsI;

namespace LeetCode.Tests.Algorithms.CountValidSubstringsI;

public abstract class CountValidSubstringsITestsBase<T> where T : ICountValidSubstringsI, new()
{
    [TestMethod]
    [DataRow("abac", 10L)]
    [DataRow("abc", 5L)]
    [DataRow("ac", 3L)]
    [DataRow("a", 1L)]
    [DataRow("b", 1L)]
    [DataRow("c", 1L)]
    [DataRow("aa", 3L)]
    [DataRow("cba", 6L)]
    [DataRow("abcabc", 14L)]
    [DataRow("ababc", 12L)]
    [DataRow("aabbcc", 21L)]
    [DataRow("abcc", 8L)]
    [DataRow("aabc", 8L)]
    [DataRow("abcbc", 12L)]
    [DataRow("cabca", 11L)]
    [DataRow("abcabcabc", 23L)]
    [DataRow("bcabca", 15L)]
    [DataRow("aaaaa", 15L)]
    [DataRow("acbacb", 21L)]
    [DataRow("abababab", 36L)]
    [DataRow("ccccbbbbaaaa", 78L)]
    [DataRow("abcaabc", 19L)]
    [DataRow("cabcab", 15L)]
    [DataRow("bbabcaa", 19L)]
    public void CountValidSubstrings_WithInputString_ReturnsValidSubstringsCount(string s, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountValidSubstrings(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}