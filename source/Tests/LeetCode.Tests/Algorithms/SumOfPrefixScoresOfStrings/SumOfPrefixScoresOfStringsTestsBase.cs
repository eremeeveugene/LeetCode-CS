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

using LeetCode.Algorithms.SumOfPrefixScoresOfStrings;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SumOfPrefixScoresOfStrings;

public abstract class SumOfPrefixScoresOfStringsTestsBase<T> where T : ISumOfPrefixScoresOfStrings, new()
{
    [TestMethod]
    [DataRow("[\"a\"]", "[1]")]
    [DataRow("[\"abcd\"]", "[4]")]
    [DataRow("[\"abc\",\"ab\",\"bc\",\"b\"]", "[5,4,3,2]")]
    [DataRow("[\"a\",\"b\",\"aa\",\"ab\"]", "[3,1,4,4]")]
    [DataRow("[\"abababab\",\"abab\",\"ab\",\"a\",\"babababa\",\"baba\",\"ba\",\"b\"]", "[15,11,7,4,15,11,7,4]")]
    public void SumPrefixScores_WithListOfWords_ReturnsSumOfScoresForAllPrefixesOfEachWord(string wordsJson,
        string expectedResultJson)
    {
        // Arrange
        var words = JsonHelper<string[]>.Parse(wordsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.SumPrefixScores(words);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}