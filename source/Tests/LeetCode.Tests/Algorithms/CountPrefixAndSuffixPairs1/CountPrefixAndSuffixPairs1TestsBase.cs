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

using LeetCode.Algorithms.CountPrefixAndSuffixPairs1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountPrefixAndSuffixPairs1;

public abstract class CountPrefixAndSuffixPairs1TestsBase<T> where T : ICountPrefixAndSuffixPairs1, new()
{
    [TestMethod]
    [DataRow("[\"a\",\"aba\",\"ababa\",\"aa\"]", 4)]
    [DataRow("[\"pa\",\"papa\",\"ma\",\"mama\"]", 2)]
    [DataRow("[\"abab\",\"ab\"]", 0)]
    public void CountPrefixSuffixPairs_WithWordsArray_ReturnsCorrectCount(string wordsJsonArray, int expectedResult)
    {
        // Arrange
        var words = JsonHelper<string>.DeserializeToArray(wordsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CountPrefixSuffixPairs(words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}