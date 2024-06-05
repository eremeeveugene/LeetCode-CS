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

using LeetCode.Algorithms.FindCommonCharacters;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindCommonCharacters;

public abstract class FindCommonCharactersTestsBase<T> where T : IFindCommonCharacters, new()
{
    [TestMethod]
    [DataRow(new[] { "bella" }, "[\"b\",\"e\",\"l\",\"l\",\"a\"]")]
    [DataRow(new[] { "bella", "label", "roller" }, "[\"e\",\"l\",\"l\"]")]
    [DataRow(new[] { "cool", "lock", "cook" }, "[\"c\",\"o\"]")]
    [DataRow(new[] { "a", "a", "a" }, "[\"a\"]")]
    [DataRow(new[] { "", "", "" }, "[]")]
    [DataRow(new[] { "abc", "def", "ghi" }, "[]")]
    [DataRow(new[] { "a" }, "[\"a\"]")]
    [DataRow(new[] { "abc", "abc", "abc" }, "[\"a\",\"b\",\"c\"]")]
    public void CommonChars_WithGivenWordsArray_ReturnsCommonCharacters(string[] words, string expectedResultJsonArray)
    {
        // Arrange
        var solution = new T();

        var expectedResult = JsonHelper<string>.JsonArrayToList(expectedResultJsonArray);

        // Act
        var actualResult = solution.CommonChars(words);

        // Assert
        CollectionAssert.AreEqual(expectedResult.ToList(), actualResult.ToList());
    }
}