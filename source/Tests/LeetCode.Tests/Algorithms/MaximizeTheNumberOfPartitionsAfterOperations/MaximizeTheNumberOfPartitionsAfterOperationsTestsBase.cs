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

using LeetCode.Algorithms.MaximizeTheNumberOfPartitionsAfterOperations;

namespace LeetCode.Tests.Algorithms.MaximizeTheNumberOfPartitionsAfterOperations;

public abstract class MaximizeTheNumberOfPartitionsAfterOperationsTestsBase<T> where T : IMaximizeTheNumberOfPartitionsAfterOperations, new()
{
    [TestMethod]
    [DataRow("accca", 2, 3)]
    [DataRow("aabaab", 3, 1)]
    [DataRow("xxyz", 1, 4)]
    [DataRow("a", 1, 1)]
    [DataRow("a", 26, 1)]
    [DataRow("aa", 1, 2)]
    [DataRow("ab", 1, 2)]
    [DataRow("ab", 2, 1)]
    [DataRow("aaaa", 1, 3)]
    [DataRow("abcd", 4, 1)]
    [DataRow("abcd", 2, 2)]
    [DataRow("abab", 1, 4)]
    [DataRow("abab", 2, 2)]
    [DataRow("abcabc", 2, 3)]
    [DataRow("abcabc", 3, 2)]
    [DataRow("aaaaab", 2, 2)]
    [DataRow("zzzz", 1, 3)]
    [DataRow("abacaba", 2, 3)]
    [DataRow("baac", 2, 2)]
    [DataRow("aabbccdd", 2, 3)]
    [DataRow("abcdcba", 3, 3)]
    [DataRow("leetcode", 3, 3)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 1, 26)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 13, 2)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 26, 1)]
    [DataRow("abcdefghijklmanopqrstuvwxyz", 13, 3)]
    [DataRow("abcdefghijklmxnopqrstuvwxyz", 13, 3)]
    [DataRow("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz", 26, 1)]
    public void MaxPartitionsAfterOperations_WithStringAndK_ReturnsMaxPartitionsCount(string s, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxPartitionsAfterOperations(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}