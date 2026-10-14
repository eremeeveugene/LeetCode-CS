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

using LeetCode.Algorithms.FindTheEncryptedString;

namespace LeetCode.Tests.Algorithms.FindTheEncryptedString;

public abstract class FindTheEncryptedStringTestsBase<T> where T : IFindTheEncryptedString, new()
{
    [TestMethod]
    [DataRow("dart", 3, "tdar")]
    [DataRow("aaa", 1, "aaa")]
    [DataRow("a", 1, "a")]
    [DataRow("a", 10000, "a")]
    [DataRow("ab", 1, "ba")]
    [DataRow("ab", 2, "ab")]
    [DataRow("abc", 1, "bca")]
    [DataRow("abc", 3, "abc")]
    [DataRow("abc", 4, "bca")]
    [DataRow("abcdef", 2, "cdefab")]
    [DataRow("abcdef", 6, "abcdef")]
    [DataRow("abcdef", 13, "bcdefa")]
    [DataRow("hello", 2, "llohe")]
    [DataRow("zyx", 5, "xzy")]
    [DataRow("leetcode", 3, "tcodelee")]
    [DataRow("aabbcc", 4, "ccaabb")]
    [DataRow("xyzxyz", 10000, "yzxyzx")]
    [DataRow("programming", 7, "mingprogram")]
    [DataRow("qwertyuiop", 9, "pqwertyuio")]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 25, "zabcdefghijklmnopqrstuvwxy")]
    public void GetEncryptedString_WithStringAndShiftValue_ReturnsEncryptedString(string s, int k, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetEncryptedString(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}