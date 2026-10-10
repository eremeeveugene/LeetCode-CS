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

using LeetCode.Algorithms.RemoveAllOccurrencesOfSubstring;

namespace LeetCode.Tests.Algorithms.RemoveAllOccurrencesOfSubstring;

public abstract class RemoveAllOccurrencesOfSubstringTestsBase<T> where T : IRemoveAllOccurrencesOfSubstring, new()
{
    [TestMethod]
    [DataRow("daabcbaabcbc", "abc", "dab")]
    [DataRow("axxxxyyyyb", "xy", "ab")]
    [DataRow("ixcupqoixcupqokevnpokevnpoknqywmlhevgc", "ixcupqokevnpo", "knqywmlhevgc")]
    [DataRow("a", "a", "")]
    [DataRow("a", "b", "a")]
    [DataRow("ab", "abc", "ab")]
    [DataRow("abc", "abc", "")]
    [DataRow("aabb", "ab", "")]
    [DataRow("aaabbb", "ab", "")]
    [DataRow("abab", "ab", "")]
    [DataRow("ababab", "aba", "bab")]
    [DataRow("aaaa", "aa", "")]
    [DataRow("aaa", "aa", "a")]
    [DataRow("abcabc", "abc", "")]
    [DataRow("aabcbc", "abc", "")]
    [DataRow("zzzz", "zz", "")]
    [DataRow("xyzxyz", "yz", "xx")]
    [DataRow("abba", "bb", "aa")]
    [DataRow("abcd", "bc", "ad")]
    [DataRow("cabbd", "ab", "cbd")]
    [DataRow("lleetcodeetcode", "leetcode", "letcode")]
    [DataRow("aabababa", "aba", "ba")]
    [DataRow("zyxzyxzyx", "yxz", "zyx")]
    public void RemoveOccurrences_GivenStringAndSubstring_RemovesAllOccurrences(string s, string part, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveOccurrences(s, part);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void RemoveOccurrences_WithMaxLengthNestedOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        var solution = new T();

        var s = new char[1000];

        for (var i = 0; i < s.Length; i++)
        {
            s[i] = i < 500 ? 'a' : 'b';
        }

        // Act
        var actualResult = solution.RemoveOccurrences(new string(s), "ab");

        // Assert
        Assert.AreEqual(string.Empty, actualResult);
    }

    [TestMethod]
    public void RemoveOccurrences_WithMaxLengthPartLongerThanRemainder_ReturnsOriginalString()
    {
        // Arrange
        var solution = new T();

        var s = new char[1000];
        var part = new char[1000];

        for (var i = 0; i < s.Length; i++)
        {
            s[i] = 'a';
            part[i] = 'a';
        }

        part[999] = 'b';

        // Act
        var actualResult = solution.RemoveOccurrences(new string(s), new string(part));

        // Assert
        Assert.AreEqual(new string(s), actualResult);
    }
}