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

using LeetCode.Algorithms.WordPattern;

namespace LeetCode.Tests.Algorithms.WordPattern;

public abstract class WordPatternTestsBase<T> where T : IWordPattern, new()
{
    [TestMethod]
    [DataRow("aaa", "aa aa aa aa", false)]
    [DataRow("abba", "dog cat cat dog", true)]
    [DataRow("abba", "dog cat cat fish", false)]
    [DataRow("aaaa", "dog cat cat dog", false)]
    [DataRow("abba", "dog dog dog dog", false)]
    public void WordPattern_GivenPatternAndString_MatchesExpectedResult(string pattern, string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.WordPattern(pattern, s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}