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

using LeetCode.Algorithms.StringCompression3;

namespace LeetCode.Tests.Algorithms.StringCompression3;

public abstract class StringCompression3TestsBase<T> where T : IStringCompression3, new()
{
    [TestMethod]
    [DataRow("abcde", "1a1b1c1d1e")]
    [DataRow("aaaaaaaaaaaaaabb", "9a5a2b")]
    [DataRow("a", "1a")]
    [DataRow("aa", "2a")]
    [DataRow("aaaaaaaaa", "9a")]
    [DataRow("aaaaaaaaaa", "9a1a")]
    [DataRow("aaaaaaaaaaaaaaaaaaaa", "9a9a2a")]
    [DataRow("abc", "1a1b1c")]
    [DataRow("aabbcc", "2a2b2c")]
    [DataRow("aaabbbaaa", "3a3b3a")]
    [DataRow("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz", "9z9z9z9z3z")]
    [DataRow("abababab", "1a1b1a1b1a1b1a1b")]
    [DataRow("aaaaaaaaabbbbbbbbbcccccccccd", "9a9b9c1d")]
    [DataRow("xyyyyyyyyyyyyyyyyyyyyz", "1x9y9y2y1z")]
    [DataRow("mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm", "9m9m9m9m9m9m9m9m9m9m9m6m")]
    [DataRow("ab", "1a1b")]
    [DataRow("aab", "2a1b")]
    [DataRow("abb", "1a2b")]
    [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a5a")]
    [DataRow("abcdefghijklmnopqrstuvwxyz", "1a1b1c1d1e1f1g1h1i1j1k1l1m1n1o1p1q1r1s1t1u1v1w1x1y1z")]
    [DataRow("aaaaaaaaaab", "9a1a1b")]
    [DataRow("baaaaaaaaaa", "1b9a1a")]
    public void CompressedString_WithGivenWord_ReturnsCompressedString(string word, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CompressedString(word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}