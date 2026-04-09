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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindCommonCharacters;

public abstract class FindCommonCharactersTestsBase<T> where T : IFindCommonCharacters, new()
{
    [TestMethod]
    [DataRow("[\"bella\"]", "[\"b\",\"e\",\"l\",\"l\",\"a\"]")]
    [DataRow("[\"bella\", \"label\", \"roller\"]", "[\"e\",\"l\",\"l\"]")]
    [DataRow("[\"cool\", \"lock\", \"cook\"]", "[\"c\",\"o\"]")]
    [DataRow("[\"a\", \"a\", \"a\"]", "[\"a\"]")]
    [DataRow("[\"\", \"\", \"\"]", "[]")]
    [DataRow("[\"abc\", \"def\", \"ghi\"]", "[]")]
    [DataRow("[\"a\"]", "[\"a\"]")]
    [DataRow("[\"abc\", \"abc\", \"abc\"]", "[\"a\",\"b\",\"c\"]")]
    [DataRow(
        "[\"daaccccd\", \"adacbdda\", \"abddbaba\", \"bacbcbcb\", \"bdaaaddc\", \"cdadacba\", \"bacbdcda\", \"bacdaacd\"]",
        "[\"a\"]")]
    public void CommonChars_WithGivenWordsArray_ReturnsCommonCharacters(string wordsJson,
        string expectedResultJson)
    {
        // Arrange
        var words = JsonHelper.Parse<string[]>(wordsJson);

        var solution = new T();

        var expectedResult = JsonHelper.Parse<string[]>(expectedResultJson);

        // Act
        var actualResult = solution.CommonChars(words);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult.ToList(), actualResult.ToList());
    }
}