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

using LeetCode.Algorithms.LongestPalindromeByConcatenatingTwoLetterWords;

namespace LeetCode.Tests.Algorithms.LongestPalindromeByConcatenatingTwoLetterWords;

public abstract class LongestPalindromeByConcatenatingTwoLetterWordsTestsBase<T> where T : ILongestPalindromeByConcatenatingTwoLetterWords, new()
{
    [TestMethod]
    [DataRow(new[] { "lc", "cl", "gg" }, 6)]
    [DataRow(new[] { "ab", "ty", "yt", "lc", "cl", "ab" }, 8)]
    [DataRow(new[] { "cc", "ll", "xx" }, 2)]
    [DataRow(new[] { "aa" }, 2)]
    [DataRow(new[] { "ab" }, 0)]
    [DataRow(new[] { "ab", "ba" }, 4)]
    [DataRow(new[] { "aa", "aa" }, 4)]
    [DataRow(new[] { "aa", "aa", "aa" }, 6)]
    [DataRow(new[] { "ab", "ba", "ab" }, 4)]
    [DataRow(new[] { "ab", "ab", "ba", "ba" }, 8)]
    [DataRow(new[] { "zz", "zy", "yz" }, 6)]
    [DataRow(new[] { "aa", "bb", "cc", "aa" }, 6)]
    [DataRow(new[] { "ab", "cd", "ef" }, 0)]
    [DataRow(new[] { "dd", "aa", "bb", "dd", "aa", "dd", "bb", "dd", "aa", "cc", "bb", "cc", "dd", "cc" }, 22)]
    [DataRow(new[] { "cb", "bc", "ca", "ac", "bc", "ca" }, 8)]
    [DataRow(new[] { "bb", "aa", "cc" }, 2)]
    [DataRow(new[] { "cb", "bc", "cc" }, 6)]
    [DataRow(new[] { "ca", "ca", "aa", "aa" }, 4)]
    [DataRow(new[] { "bb", "bc", "ac" }, 2)]
    [DataRow(new[] { "cb", "ba", "ca", "bc" }, 4)]
    [DataRow(new[] { "bc", "ac", "bb", "ac", "ba" }, 2)]
    public void LongestPalindrome_WithArrayOfTwoLetterWords_ReturnsMaximumPalindromeLength(string[] words, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestPalindrome(words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}