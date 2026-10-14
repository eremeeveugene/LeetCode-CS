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
    [DynamicData(nameof(GetLargeTestData))]
    public void RemoveOccurrences_GivenStringAndSubstring_RemovesAllOccurrences(string s, string part, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveOccurrences(s, part);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        var nested = new char[1000];

        for (var i = 0; i < nested.Length; i++)
        {
            nested[i] = i < 500 ? 'a' : 'b';
        }

        yield return [new string(nested), "ab", string.Empty];

        var s = new string('a', 1000);
        var part = new char[1000];

        for (var i = 0; i < part.Length; i++)
        {
            part[i] = 'a';
        }

        part[999] = 'b';

        yield return [s, new string(part), s];
    }
}