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

using LeetCode.Algorithms.FindMostFrequentVowelAndConsonant;

namespace LeetCode.Tests.Algorithms.FindMostFrequentVowelAndConsonant;

public abstract class FindMostFrequentVowelAndConsonantTestsBase<T> where T : IFindMostFrequentVowelAndConsonant, new()
{
    [TestMethod]
    [DataRow("successes", 6)]
    [DataRow("aeiaeia", 3)]
    public void MaxFreqSum_WithMixedVowelsAndConsonants_ReturnsSumOfMostFrequentCounts(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxFreqSum(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}