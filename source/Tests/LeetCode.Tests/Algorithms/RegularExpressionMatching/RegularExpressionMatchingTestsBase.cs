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

using LeetCode.Algorithms.RegularExpressionMatching;

namespace LeetCode.Tests.Algorithms.RegularExpressionMatching;

public abstract class RegularExpressionMatchingTestsBase<T> where T : IRegularExpressionMatching, new()
{
    [TestMethod]
    [DataRow("aa", "a", false)]
    [DataRow("aa", "a*", true)]
    [DataRow("ab", ".*", true)]
    [DataRow("aab", "c*a*b", true)]
    [DataRow("mississippi", "mis*is*p*.", false)]
    [DataRow("mississippi", "mis*is*ip*.", true)]
    [DataRow("a", ".", true)]
    [DataRow("a", "ab*", true)]
    [DataRow("a", "b*", false)]
    [DataRow("a", "a*a*a*", true)]
    [DataRow("a", ".*..a*", false)]
    [DataRow("ab", "a", false)]
    [DataRow("ab", ".*c", false)]
    [DataRow("ab", ".*..", true)]
    [DataRow("abc", "abc", true)]
    [DataRow("abc", "a.c", true)]
    [DataRow("abc", "a.d", false)]
    [DataRow("aaa", "a*a", true)]
    [DataRow("aaa", "aaaa", false)]
    [DataRow("aaa", "ab*a*c*a", true)]
    [DataRow("aaa", "a.a", true)]
    [DataRow("aaab", "a*b", true)]
    [DataRow("b", "a*b", true)]
    [DataRow("ac", "ab*c", true)]
    [DataRow("abbbbc", "ab*c", true)]
    [DataRow("abcd", "d*", false)]
    [DataRow("bbbba", ".*a*a", true)]
    [DataRow("aasdfasdfasdfasdfas", "aasdf.*asdf.*asdf.*asdf.*s", true)]
    public void IsMatch_WithStringSAndPatternP_ReturnsWhetherPatternMatchesEntireString(string s, string p, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsMatch(s, p);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}