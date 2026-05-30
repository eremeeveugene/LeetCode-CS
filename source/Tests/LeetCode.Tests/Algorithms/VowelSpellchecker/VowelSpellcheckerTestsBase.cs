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

namespace LeetCode.Tests.Algorithms.VowelSpellchecker;

public abstract class VowelSpellcheckerTestsBase<T> where T : IVowelSpellchecker, new()
{
    [TestMethod]
    [DataRow(new[] { "yellow" }, new[] { "YellOw" }, new[] { "yellow" })]
    [DataRow(new[] { "KiTe", "kite", "hare", "Hare" }, new[] { "kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto" }, new[] { "kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe" })]
    public void Spellchecker_WithExactMatchCapitalization_ReturnsCorrectWordFromWordlist(string[] wordlist, string[] queries, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Spellchecker(wordlist, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}