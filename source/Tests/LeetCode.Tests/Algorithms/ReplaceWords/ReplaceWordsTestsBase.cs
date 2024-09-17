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

using LeetCode.Algorithms.ReplaceWords;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ReplaceWords;

public abstract class ReplaceWordsTestsBase<T> where T : IReplaceWords, new()
{
    [TestMethod]
    [DataRow("[\"cat\",\"bat\",\"rat\"]", "the cattle was rattled by the battery", "the cat was rat by the bat")]
    [DataRow("[\"a\",\"b\",\"c\"]", "aadsfasf absbs bbab cadsfafs", "a a b c")]
    [DataRow("[\"a\"]", "aaaaaa aa aaa a", "a a a a")]
    [DataRow("[\"a\",\"ab\",\"abc\"]", "abc ab a abcde", "a a a a")]
    [DataRow("[\"prefix\",\"pre\",\"suff\",\"suffi\"]", "prefixes and suffixes", "pre and suff")]
    [DataRow("[\"longest\",\"longer\",\"long\"]", "this is a long long word", "this is a long long word")]
    public void ReplaceWords_WithDictionaryAndSentence_ReturnsCorrectlyReplacedSentence(string dictionaryJsonArray,
        string sentence, string expectedResult)
    {
        // Arrange
        var dictionaryArray = JsonHelper<string>.DeserializeToArray(dictionaryJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ReplaceWords(dictionaryArray, sentence);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}