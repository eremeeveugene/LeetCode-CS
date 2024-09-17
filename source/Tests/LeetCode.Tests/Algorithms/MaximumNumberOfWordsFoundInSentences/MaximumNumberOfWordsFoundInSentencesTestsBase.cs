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

using LeetCode.Algorithms.MaximumNumberOfWordsFoundInSentences;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfWordsFoundInSentences;

public abstract class MaximumNumberOfWordsFoundInSentencesTestsBase<T>
    where T : IMaximumNumberOfWordsFoundInSentences, new()
{
    [TestMethod]
    [DataRow("[\"alice and bob love leetcode\",\"i think so too\",\"this is great thanks very much\"]", 6)]
    [DataRow("[\"please wait\",\"continue to fight\",\"continue to win\"]", 3)]
    public void MostWordsFound_GivenArrayOfSentences_ReturnsMaxWordCount(string sentencesJsonArray, int expectedResult)
    {
        // Arrange
        var sentences = JsonHelper<string>.DeserializeToArray(sentencesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MostWordsFound(sentences);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}