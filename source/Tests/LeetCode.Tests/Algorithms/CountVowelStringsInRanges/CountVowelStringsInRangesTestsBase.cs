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

using LeetCode.Algorithms.CountVowelStringsInRanges;

namespace LeetCode.Tests.Algorithms.CountVowelStringsInRanges;

public abstract class CountVowelStringsInRangesTestsBase<T> where T : ICountVowelStringsInRanges, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void VowelStrings_WithWordsAndQueries_ModifiesWordsAccordingToQueries(string[] words, int[][] queries, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.VowelStrings(words, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { "aba", "bcb", "ece", "aa", "e" }, new[] { new[] { 0, 2 }, new[] { 1, 4 }, new[] { 1, 1 } }, new[] { 2, 3, 0 }];

        yield return [new[] { "a", "e", "i" }, new[] { new[] { 0, 2 }, new[] { 0, 1 }, new[] { 2, 2 } }, new[] { 3, 2, 1 }];
    }
}