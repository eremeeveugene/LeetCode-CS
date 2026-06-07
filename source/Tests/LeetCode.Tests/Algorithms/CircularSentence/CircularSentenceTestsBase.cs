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

using LeetCode.Algorithms.CircularSentence;

namespace LeetCode.Tests.Algorithms.CircularSentence;

public abstract class CircularSentenceTestsBase<T> where T : ICircularSentence, new()
{
    [TestMethod]
    [DataRow("leetcode exercises sound delightful", true)]
    [DataRow("eetcode", true)]
    [DataRow("Leetcode is cool", false)]
    [DataRow("a", true)]
    [DataRow("ab ba", true)]
    [DataRow("ab bc", false)]
    [DataRow("hello olleh", true)]
    [DataRow("hello world", false)]
    [DataRow("aa aa aa", true)]
    [DataRow("ab ba ab", false)]
    [DataRow("xyx yxy xyx", false)]
    [DataRow("cat tiger rat", false)]
    [DataRow("dog god", true)]
    [DataRow("abc cba abc", false)]
    [DataRow("noon noon noon", true)]
    [DataRow("abc def", false)]
    [DataRow("zz zz", true)]
    [DataRow("a b c ca", false)]
    public void IsCircularSentence_GivenSentence_ReturnsIfSentenceIsCircular(string sentence, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsCircularSentence(sentence);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}