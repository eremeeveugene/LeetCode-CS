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

using LeetCode.Algorithms.MostCommonWord;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MostCommonWord;

public abstract class MostCommonWordTestsBase<T> where T : IMostCommonWord, new()
{
    [TestMethod]
    [DataRow("Bob hit a ball, the hit BALL flew far after it was hit.", "[\"hit\"]", "ball")]
    [DataRow("a.", "[]", "a")]
    [DataRow("a, a, a, a, b,b,b,c, c", "[\"a\"]", "b")]
    public void MostCommonWord_WithParagraphAndBannedWords_ReturnsMostFrequentNonBannedWord(string paragraph,
        string bannedJson, string expectedResult)
    {
        // Arrange
        var banned = JsonHelper<string[]>.Parse(bannedJson);

        var solution = new T();

        // Act
        var actualResult = solution.MostCommonWord(paragraph, banned);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}