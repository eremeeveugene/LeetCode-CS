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

using LeetCode.Algorithms.MinimumLengthOfStringAfterOperations;

namespace LeetCode.Tests.Algorithms.MinimumLengthOfStringAfterOperations;

public abstract class MinimumLengthOfStringAfterOperationsTestsBase<T> where T : IMinimumLengthOfStringAfterOperations, new()
{
    [TestMethod]
    [DataRow("aa", 2)]
    [DataRow("abaacbcbb", 5)]
    [DataRow("a", 1)]
    [DataRow("ab", 2)]
    [DataRow("aaa", 1)]
    [DataRow("aaaa", 2)]
    [DataRow("aaaaa", 1)]
    [DataRow("abc", 3)]
    [DataRow("abab", 4)]
    [DataRow("ababab", 2)]
    [DataRow("aabb", 4)]
    [DataRow("aabbb", 3)]
    [DataRow("aaabbb", 2)]
    [DataRow("abcabc", 6)]
    [DataRow("abcabcabc", 3)]
    [DataRow("aaaaaaa", 1)]
    [DataRow("abacaba", 5)]
    [DataRow("zzzyyyxxx", 3)]
    [DataRow("aabbccaabbcc", 6)]
    [DataRow("abcdabcdab", 6)]
    public void MinimumLength_WithInputString_ReturnsMinimumLengthOfStringAfterOperations(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumLength(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}