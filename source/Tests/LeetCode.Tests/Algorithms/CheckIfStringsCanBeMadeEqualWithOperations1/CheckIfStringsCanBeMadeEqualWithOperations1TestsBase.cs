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

using LeetCode.Algorithms.CheckIfStringsCanBeMadeEqualWithOperations1;

namespace LeetCode.Tests.Algorithms.CheckIfStringsCanBeMadeEqualWithOperations1;

public abstract class CheckIfStringsCanBeMadeEqualWithOperations1TestsBase<T> where T : ICheckIfStringsCanBeMadeEqualWithOperations1, new()
{
    [TestMethod]
    [DataRow("abcd", "abdc", false)]
    [DataRow("aabb", "bbaa", true)]
    [DataRow("abab", "baba", false)]
    [DataRow("aaaa", "aaaa", true)]
    [DataRow("aabb", "abab", false)]
    [DataRow("abcd", "ebad", false)]
    [DataRow("abcd", "acbd", false)]
    [DataRow("abcd", "wxyz", false)]
    [DataRow("abca", "caab", true)]
    [DataRow("abba", "baab", true)]
    [DataRow("abba", "abab", false)]
    [DataRow("abcd", "dcba", false)]
    public void CanBeEqual_WithGivenStrings_ReturnsTrueIfStringsCanBeMadeEqual(string s1, string s2, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanBeEqual(s1, s2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}