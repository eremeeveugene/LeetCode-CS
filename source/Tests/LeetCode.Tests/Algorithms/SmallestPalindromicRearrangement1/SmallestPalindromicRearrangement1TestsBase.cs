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

using LeetCode.Algorithms.SmallestPalindromicRearrangement1;

namespace LeetCode.Tests.Algorithms.SmallestPalindromicRearrangement1;

public abstract class SmallestPalindromicRearrangement1TestsBase<T> where T : ISmallestPalindromicRearrangement1, new()
{
    [TestMethod]
    [DataRow("z", "z")]
    [DataRow("aa", "aa")]
    [DataRow("aba", "aba")]
    [DataRow("babab", "abbba")]
    [DataRow("daccad", "acddca")]
    [DataRow("abba", "abba")]
    [DataRow("abcba", "abcba")]
    [DataRow("aabaa", "aabaa")]
    [DataRow("cbabc", "bcacb")]
    [DataRow("aabbaa", "aabbaa")]
    [DataRow("abccba", "abccba")]
    [DataRow("racecar", "acrerca")]
    [DataRow("noon", "noon")]
    [DataRow("level", "elvle")]
    [DataRow("rotator", "ortatro")]
    [DataRow("aaaaa", "aaaaa")]
    [DataRow("abaaba", "aabbaa")]
    [DataRow("xyzzyx", "xyzzyx")]
    [DataRow("wow", "wow")]
    [DataRow("civic", "civic")]
    [DataRow("deed", "deed")]
    [DataRow("kayak", "akyka")]
    public void SmallestPalindrome_WithPalindromicString_ReturnsSmallestPalindromicPermutation(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestPalindrome(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}