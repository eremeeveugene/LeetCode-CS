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

using LeetCode.Algorithms.MaximumLengthSubstringWithTwoOccurrences;

namespace LeetCode.Tests.Algorithms.MaximumLengthSubstringWithTwoOccurrences;

public abstract class MaximumLengthSubstringWithTwoOccurrencesTestsBase<T> where T : IMaximumLengthSubstringWithTwoOccurrences, new()
{
    [TestMethod]
    [DataRow("bcbbbcba", 4)]
    [DataRow("aaaa", 2)]
    [DataRow("ab", 2)]
    [DataRow("aa", 2)]
    [DataRow("abcabc", 6)]
    [DataRow("aabbcc", 6)]
    [DataRow("abababab", 4)]
    [DataRow("zzzzzzzzzz", 2)]
    [DataRow("abcdefghij", 10)]
    [DataRow("aaa", 2)]
    [DataRow("aaab", 3)]
    [DataRow("aabb", 4)]
    [DataRow("aaabbb", 4)]
    [DataRow("aabbaabb", 4)]
    [DataRow("xxyyxxyyxx", 4)]
    [DataRow("ba", 2)]
    [DataRow("abcba", 5)]
    [DataRow("abcdeedcba", 10)]
    [DataRow("aaabbbccc", 4)]
    [DataRow("aaaaaaaaaa", 2)]
    public void MaximumLengthSubstring_WithString_ReturnsMaximumLength(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumLengthSubstring(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}