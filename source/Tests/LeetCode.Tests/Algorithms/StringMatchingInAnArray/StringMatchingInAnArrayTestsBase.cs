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

namespace LeetCode.Tests.Algorithms.StringMatchingInAnArray;

public abstract class StringMatchingInAnArrayTestsBase<T> where T : IStringMatchingInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { "mass", "as", "hero", "superhero" }, new[] { "as", "hero" })]
    [DataRow(new[] { "leetcode", "et", "code" }, new[] { "et", "code" })]
    [DataRow(new[] { "blue", "green", "bu" }, new string[] { })]
    public void StringMatching_WithArrayOfWords_ReturnsMatchingSubstrings(string[] words, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.StringMatching(words);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}