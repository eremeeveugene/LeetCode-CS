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

using LeetCode.Algorithms.MostCommonWord;

namespace LeetCode.Tests.Algorithms.MostCommonWord;

public abstract class MostCommonWordTestsBase<T> where T : IMostCommonWord, new()
{
    [TestMethod]
    [DataRow("Bob hit a ball, the hit BALL flew far after it was hit.", new[] { "hit" }, "ball")]
    [DataRow("a.", new string[] { }, "a")]
    [DataRow("a, a, a, a, b,b,b,c, c", new[] { "a" }, "b")]
    public void MostCommonWord_WithParagraphAndBannedWords_ReturnsMostFrequentNonBannedWord(string paragraph,
        string[] banned, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MostCommonWord(paragraph, banned);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}