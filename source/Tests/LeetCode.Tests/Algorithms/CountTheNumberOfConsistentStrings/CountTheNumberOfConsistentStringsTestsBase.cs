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

using LeetCode.Algorithms.CountTheNumberOfConsistentStrings;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountTheNumberOfConsistentStrings;

public abstract class CountTheNumberOfConsistentStringsTestsBase<T> where T : ICountTheNumberOfConsistentStrings, new()
{
    [TestMethod]
    [DataRow("ab", "[\"ad\",\"bd\",\"aaab\",\"baa\",\"badab\"]", 2)]
    [DataRow("abc", "[\"a\",\"b\",\"c\",\"ab\",\"ac\",\"bc\",\"abc\"]", 7)]
    [DataRow("cad", "[\"cc\",\"acd\",\"b\",\"ba\",\"bac\",\"bad\",\"ac\",\"d\"]", 4)]
    public void CountConsistentStrings_WithAllowedCharactersAndWords_ReturnsNumberOfConsistentStrings(string allowed,
        string wordsJsonArray, int expectedResult)
    {
        // Arrange
        var words = JsonHelper<string>.DeserializeToArray(wordsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CountConsistentStrings(allowed, words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}