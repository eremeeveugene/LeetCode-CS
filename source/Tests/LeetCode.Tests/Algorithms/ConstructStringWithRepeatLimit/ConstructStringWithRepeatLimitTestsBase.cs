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

using LeetCode.Algorithms.ConstructStringWithRepeatLimit;

namespace LeetCode.Tests.Algorithms.ConstructStringWithRepeatLimit;

public abstract class ConstructStringWithRepeatLimitTestsBase<T> where T : IConstructStringWithRepeatLimit, new()
{
    [TestMethod]
    [DataRow("cczazcc", 3, "zzcccac")]
    [DataRow("aababab", 2, "bbabaa")]
    [DataRow("a", 1, "a")]
    [DataRow("aa", 1, "a")]
    [DataRow("ab", 1, "ba")]
    [DataRow("aaab", 1, "ba")]
    [DataRow("zzzz", 2, "zz")]
    [DataRow("zzzzyy", 2, "zzyzzy")]
    [DataRow("abc", 1, "cba")]
    [DataRow("cba", 3, "cba")]
    [DataRow("aaaaabbbbb", 2, "bbabbabaa")]
    [DataRow("xyz", 1, "zyx")]
    [DataRow("aabbcc", 1, "cbcba")]
    [DataRow("aabbcc", 2, "ccbbaa")]
    [DataRow("zzzaaa", 1, "zazaza")]
    [DataRow("baaaaa", 2, "baa")]
    [DataRow("bbbaaa", 2, "bbabaa")]
    [DataRow("abcdefghij", 1, "jihgfedcba")]
    [DataRow("mmmmnn", 3, "nnmmm")]
    [DataRow("qqqqqq", 3, "qqq")]
    [DataRow("zyzyzyz", 1, "zyzyzyz")]
    [DataRow("ccbbaa", 2, "ccbbaa")]
    public void RepeatLimitedString_WithInputStringAndRepeatLimit_ReturnsLexicographicallyLargestString(
        string s,
        int repeatLimit,
        string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RepeatLimitedString(s, repeatLimit);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}