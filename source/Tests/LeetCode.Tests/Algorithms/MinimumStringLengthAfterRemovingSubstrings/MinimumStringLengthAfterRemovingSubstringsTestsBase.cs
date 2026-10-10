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

using LeetCode.Algorithms.MinimumStringLengthAfterRemovingSubstrings;

namespace LeetCode.Tests.Algorithms.MinimumStringLengthAfterRemovingSubstrings;

public abstract class MinimumStringLengthAfterRemovingSubstringsTestsBase<T> where T : IMinimumStringLengthAfterRemovingSubstrings, new()
{
    [TestMethod]
    [DataRow("ABFCACDB", 2)]
    [DataRow("ACBBD", 5)]
    [DataRow("A", 1)]
    [DataRow("B", 1)]
    [DataRow("AB", 0)]
    [DataRow("CD", 0)]
    [DataRow("BA", 2)]
    [DataRow("DC", 2)]
    [DataRow("ABCD", 0)]
    [DataRow("ACBD", 4)]
    [DataRow("AABB", 0)]
    [DataRow("CABD", 0)]
    [DataRow("ABAB", 0)]
    [DataRow("CDCD", 0)]
    [DataRow("ACDB", 0)]
    [DataRow("AACDBB", 0)]
    [DataRow("BBAA", 4)]
    [DataRow("ABABAB", 0)]
    [DataRow("CCDD", 0)]
    [DataRow("DCBA", 4)]
    [DataRow("ABCABCD", 1)]
    [DataRow("AAAA", 4)]
    [DataRow("ACBDACBD", 8)]
    [DataRow("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", 0)]
    [DataRow("CDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCD", 0)]
    [DataRow("ACACACACACACACACACACACACACACACACACACACACACACACACACDBDBDBDBDBDBDBDBDBDBDBDBDBDBDBDBDBDBDBDBDBDBDBDBDB", 0)]
    public void MinLength_GivenString_ReturnsMinimumLength(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinLength(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}