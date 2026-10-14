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

using LeetCode.Algorithms.LexicographicallySmallestEquivalentString;

namespace LeetCode.Tests.Algorithms.LexicographicallySmallestEquivalentString;

public abstract class LexicographicallySmallestEquivalentStringTestsBase<T> where T : ILexicographicallySmallestEquivalentString, new()
{
    [TestMethod]
    [DataRow("parker", "morris", "parser", "makkek")]
    [DataRow("hello", "world", "hold", "hdld")]
    [DataRow("leetcode", "programs", "sourcecode", "aauaaaaada")]
    [DataRow("a", "b", "b", "a")]
    [DataRow("a", "a", "a", "a")]
    [DataRow("ab", "ba", "abc", "aac")]
    [DataRow("abc", "bcd", "dcba", "aaaa")]
    [DataRow("zy", "yx", "xyz", "xxx")]
    [DataRow("abc", "cde", "edcba", "ababa")]
    [DataRow("aaa", "bbb", "bbbaaa", "aaaaaa")]
    [DataRow("qwe", "rty", "qwertyuiop", "qteqteuiop")]
    [DataRow("mn", "op", "ponm", "nmnm")]
    [DataRow("abcdefghijklm", "nopqrstuvwxyz", "zyxwvutsrqponmlkjihgfedcba", "mlkjihgfedcbamlkjihgfedcba")]
    [DataRow("az", "za", "zazaz", "aaaaa")]
    [DataRow("bc", "cd", "abcd", "abbb")]
    [DataRow("xy", "yz", "zzzz", "xxxx")]
    [DataRow("hello", "world", "helloworld", "hdlldhdlld")]
    [DataRow("abcd", "dcba", "dcba", "abba")]
    [DataRow("pq", "rs", "sqrp", "qqpp")]
    [DataRow("leet", "code", "leetcode", "cdddcddd")]
    public void SmallestEquivalentString_WithCharacterEquivalencyMappings_ReturnsLexicographicallySmallestString(
        string s1,
        string s2,
        string baseStr,
        string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestEquivalentString(s1, s2, baseStr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}