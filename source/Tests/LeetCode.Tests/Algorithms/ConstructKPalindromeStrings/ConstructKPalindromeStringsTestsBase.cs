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

using LeetCode.Algorithms.ConstructKPalindromeStrings;

namespace LeetCode.Tests.Algorithms.ConstructKPalindromeStrings;

public abstract class ConstructKPalindromeStringsTestsBase<T> where T : IConstructKPalindromeStrings, new()
{
    [TestMethod]
    [DataRow("annabelle", 2, true)]
    [DataRow("leetcode", 3, false)]
    [DataRow("true", 4, true)]
    [DataRow("a", 1, true)]
    [DataRow("a", 2, false)]
    [DataRow("aa", 1, true)]
    [DataRow("aa", 2, true)]
    [DataRow("aab", 1, true)]
    [DataRow("aab", 2, true)]
    [DataRow("aab", 3, true)]
    [DataRow("abc", 1, false)]
    [DataRow("abc", 2, false)]
    [DataRow("abc", 3, true)]
    [DataRow("aabb", 2, true)]
    [DataRow("aabbc", 3, true)]
    [DataRow("abcde", 5, true)]
    [DataRow("abcde", 4, false)]
    [DataRow("aaaa", 2, true)]
    public void CanConstruct_GivenStringAndK_ReturnsIfKPalindromesCanBeFormed(string s, int k, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanConstruct(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}