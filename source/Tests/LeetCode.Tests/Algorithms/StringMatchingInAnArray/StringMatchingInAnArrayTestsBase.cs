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

using LeetCode.Algorithms.StringMatchingInAnArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.StringMatchingInAnArray;

public abstract class StringMatchingInAnArrayTestsBase<T> where T : IStringMatchingInAnArray, new()
{
    [TestMethod]
    [DataRow("[\"mass\",\"as\",\"hero\",\"superhero\"]", "[\"as\",\"hero\"]")]
    [DataRow("[\"leetcode\",\"et\",\"code\"]", "[\"et\",\"code\"]")]
    [DataRow("[\"blue\",\"green\",\"bu\"]", "[]")]
    public void StringMatching_WithArrayOfWords_ReturnsMatchingSubstrings(string wordsJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var words = JsonHelper<string>.DeserializeToArray(wordsJsonArray);
        var expectedResult = JsonHelper<string>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.StringMatching(words);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}