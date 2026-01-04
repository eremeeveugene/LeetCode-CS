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

using LeetCode.Algorithms.VowelSpellchecker;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.VowelSpellchecker;

public abstract class VowelSpellcheckerTestsBase<T> where T : IVowelSpellchecker, new()
{
    [TestMethod]
    [DataRow("[\"yellow\"]", "[\"YellOw\"]", "[\"yellow\"]")]
    [DataRow("[\"KiTe\",\"kite\",\"hare\",\"Hare\"]",
        "[\"kite\",\"Kite\",\"KiTe\",\"Hare\",\"HARE\",\"Hear\",\"hear\",\"keti\",\"keet\",\"keto\"]",
        "[\"kite\",\"KiTe\",\"KiTe\",\"Hare\",\"hare\",\"\",\"\",\"KiTe\",\"\",\"KiTe\"]")]
    public void Spellchecker_WithExactMatchCapitalization_ReturnsCorrectWordFromWordlist(
        string wordlistJson, string queriesJson, string expectedResultJson)
    {
        // Arrange
        var wordlist = JsonHelper<string[]>.Parse(wordlistJson);
        var queries = JsonHelper<string[]>.Parse(queriesJson);
        var expectedResult = JsonHelper<string[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.Spellchecker(wordlist, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}