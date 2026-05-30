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