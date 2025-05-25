// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.LongestPalindromeByConcatenatingTwoLetterWords;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LongestPalindromeByConcatenatingTwoLetterWords;

public abstract class LongestPalindromeByConcatenatingTwoLetterWordsTestsBase<T>
    where T : ILongestPalindromeByConcatenatingTwoLetterWords, new()
{
    [TestMethod]
    [DataRow("[\"lc\",\"cl\",\"gg\"]", 6)]
    [DataRow("[\"ab\",\"ty\",\"yt\",\"lc\",\"cl\",\"ab\"]", 8)]
    [DataRow("[\"cc\",\"ll\",\"xx\"]", 2)]
    public void LongestPalindrome_WithArrayOfTwoLetterWords_ReturnsMaximumPalindromeLength(string wordsJson,
        int expectedResult)
    {
        // Arrange
        var words = JsonHelper<string[]>.Parse(wordsJson);

        var solution = new T();

        // Act
        var actualResult = solution.LongestPalindrome(words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}