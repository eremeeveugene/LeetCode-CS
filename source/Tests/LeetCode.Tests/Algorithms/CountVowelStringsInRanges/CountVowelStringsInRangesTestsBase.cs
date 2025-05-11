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

using LeetCode.Algorithms.CountVowelStringsInRanges;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountVowelStringsInRanges;

public abstract class CountVowelStringsInRangesTestsBase<T> where T : ICountVowelStringsInRanges, new()
{
    [TestMethod]
    [DataRow("[\"aba\",\"bcb\",\"ece\",\"aa\",\"e\"]", "[[0,2],[1,4],[1,1]]", "[2,3,0]")]
    [DataRow("[\"a\",\"e\",\"i\"]", "[[0,2],[0,1],[2,2]]", "[3,2,1]")]
    public void VowelStrings_WithWordsAndQueries_ModifiesWordsAccordingToQueries(string wordsJson,
        string queriesJson, string expectedResultJson)
    {
        // Arrange
        var words = JsonHelper<string[]>.Parse(wordsJson);
        var queries = JsonHelper<int>.DeserializeToJaggedArray(queriesJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.VowelStrings(words, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}