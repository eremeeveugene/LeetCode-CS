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
    [DataRow(new[] { "daaccccd", "adacbdda", "abddbaba", "bacbcbcb", "bdaaaddc", "cdadacba", "bacbdcda", "bacdaacd" }, new[] { "a" })]
    [DataRow(new[] { "abc" }, new[] { "a", "b", "c" })]
    [DataRow(new[] { "aa", "a" }, new[] { "a" })]
    [DataRow(new[] { "ab", "ba" }, new[] { "a", "b" })]
    [DataRow(new[] { "zzz", "zz", "z" }, new[] { "z" })]
    [DataRow(new[] { "hello", "world" }, new[] { "l", "o" })]
    [DataRow(new[] { "aab", "aba", "baa" }, new[] { "a", "a", "b" })]
    [DataRow(new[] { "xyz", "abc" }, new string[] { })]
    [DataRow(new[] { "daa", "ca", "aadd", "ba" }, new[] { "a" })]
    [DataRow(new[] { "a", "adab", "b", "dbacb", "bc" }, new string[] { })]
    [DataRow(new[] { "ab", "dcddccbb" }, new[] { "b" })]
    [DataRow(new[] { "cd", "dcaadb", "bddaac" }, new[] { "c", "d" })]
    [DataRow(new[] { "ddaacd", "ac", "cdcadcba", "abcbbddd" }, new[] { "a", "c" })]
    public void CommonChars_WithGivenWordsArray_ReturnsCommonCharacters(string[] words, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CommonChars(words);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }
}