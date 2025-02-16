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

using LeetCode.Algorithms.CircularSentence;

namespace LeetCode.Tests.Algorithms.CircularSentence;

public abstract class CircularSentenceTestsBase<T> where T : ICircularSentence, new()
{
    [TestMethod]
    [DataRow("leetcode exercises sound delightful", true)]
    [DataRow("eetcode", true)]
    [DataRow("Leetcode is cool", false)]
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