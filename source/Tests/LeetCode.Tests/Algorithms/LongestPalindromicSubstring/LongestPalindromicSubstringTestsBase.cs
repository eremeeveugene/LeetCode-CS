// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.LongestPalindromicSubstring;

namespace LeetCode.Tests.Algorithms.LongestPalindromicSubstring;

public abstract class LongestPalindromicSubstringTestsBase<T> where T : ILongestPalindromicSubstring, new()
{
    [TestMethod]
    [DataRow("babad", "aba")]
    [DataRow("cbbd", "bb")]
    [DataRow("babaddtattarrattatddetartrateedredividerb", "ddtattarrattatdd")]
    [DataRow("a", "a")]
    [DataRow("", "")]
    [DataRow("ac", "c")]
    [DataRow("racecar", "racecar")]
    [DataRow("aa", "aa")]
    [DataRow("abacdfgdcaba", "aba")]
    [DataRow("bananas", "anana")]
    [DataRow("forgeeksskeegfor", "geeksskeeg")]
    [DataRow("aabb", "bb")]
    public void LongestPalindrome_GivenString_ReturnsLongestPalindromicSubstring(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestPalindrome(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}