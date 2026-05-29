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

using LeetCode.Algorithms.FindCommonCharacters;

namespace LeetCode.Tests.Algorithms.FindCommonCharacters;

public abstract class FindCommonCharactersTestsBase<T> where T : IFindCommonCharacters, new()
{
    [TestMethod]
    [DataRow(new[] { "bella" }, new[] { "b", "e", "l", "l", "a" })]
    [DataRow(new[] { "bella", "label", "roller" }, new[] { "e", "l", "l" })]
    [DataRow(new[] { "cool", "lock", "cook" }, new[] { "c", "o" })]
    [DataRow(new[] { "a", "a", "a" }, new[] { "a" })]
    [DataRow(new[] { "", "", "" }, new string[] { })]
    [DataRow(new[] { "abc", "def", "ghi" }, new string[] { })]
    [DataRow(new[] { "a" }, new[] { "a" })]
    [DataRow(new[] { "abc", "abc", "abc" }, new[] { "a", "b", "c" })]
    [DataRow(
        new[] { "daaccccd", "adacbdda", "abddbaba", "bacbcbcb", "bdaaaddc", "cdadacba", "bacbdcda", "bacdaacd" },
        new[] { "a" })]
    public void CommonChars_WithGivenWordsArray_ReturnsCommonCharacters(string[] words,
        string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CommonChars(words);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult.ToList(), actualResult.ToList());
    }
}