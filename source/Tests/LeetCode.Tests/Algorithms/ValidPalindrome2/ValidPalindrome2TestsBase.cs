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

using LeetCode.Algorithms.ValidPalindrome2;

namespace LeetCode.Tests.Algorithms.ValidPalindrome2;

public abstract class ValidPalindrome2TestsBase<T> where T : IValidPalindrome2, new()
{
    [TestMethod]
    [DataRow("aba", true)]
    [DataRow("abca", true)]
    [DataRow("abc", false)]
    [DataRow("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga", true)]
    [DataRow("a", true)]
    [DataRow("aa", true)]
    [DataRow("ab", true)]
    [DataRow("aab", true)]
    [DataRow("abb", true)]
    [DataRow("abcba", true)]
    [DataRow("abcca", true)]
    [DataRow("abcdba", true)]
    [DataRow("abcdefdba", false)]
    [DataRow("acbca", true)]
    [DataRow("abcdcbea", true)]
    [DataRow("aabaa", true)]
    [DataRow("abbbbbba", true)]
    [DataRow("deeee", true)]
    [DataRow("eeeed", true)]
    [DataRow("ebcbbececabbacecbbcbe", true)]
    public void ValidPalindrome_WithStringInput_ReturnsBoolean(string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ValidPalindrome(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}