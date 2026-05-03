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

using LeetCode.Algorithms.RotateString;

namespace LeetCode.Tests.Algorithms.RotateString;

public abstract class RotateStringTestsBase<T> where T : IRotateString, new()
{
    [TestMethod]
    [DataRow("abcde", "abcde", true)]
    [DataRow("abcde", "cdeab", true)]
    [DataRow("abcde", "bcdea", true)]
    [DataRow("abcde", "eabcd", true)]
    [DataRow("abcde", "abced", false)]
    [DataRow("abcde", "acbde", false)]
    [DataRow("a", "a", true)]
    [DataRow("a", "b", false)]
    [DataRow("ab", "ba", true)]
    [DataRow("ab", "ab", true)]
    [DataRow("ab", "aa", false)]
    [DataRow("aa", "aa", true)]
    [DataRow("aaa", "aaa", true)]
    [DataRow("aaaaab", "baaaaa", true)]
    [DataRow("aaaaab", "abaaaa", true)]
    [DataRow("aaaaab", "aabaaa", true)]
    [DataRow("aaaaab", "aaaaba", true)]
    [DataRow("aaaaab", "aaabaa", true)]
    [DataRow("abab", "baba", true)]
    [DataRow("abab", "abba", false)]
    [DataRow("abcabc", "bcabca", true)]
    [DataRow("abcabc", "cabcab", true)]
    [DataRow("abcabc", "acbabc", false)]
    [DataRow("abc", "abcd", false)]
    [DataRow("abcd", "abc", false)]
    [DataRow("zzzzzy", "yzzzzz", true)]
    [DataRow("xyzxyz", "zxyzxy", true)]
    [DataRow("xyzxyz", "yzxxyz", false)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", "mnopqrstuvwxyzabcdefghijkl", true)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxzy", false)]
    public void RotateString_WithOriginalAndGoalStrings_ReturnsTrueIfRotationExists(string s, string goal, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RotateString(s, goal);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}