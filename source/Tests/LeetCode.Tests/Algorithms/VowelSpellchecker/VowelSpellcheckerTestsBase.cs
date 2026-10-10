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
    [DataRow(
        new[] { "KiTe", "kite", "hare", "Hare" },
        new[] { "kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto" },
        new[] { "kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe" })]
    [DataRow(new[] { "a" }, new[] { "a" }, new[] { "a" })]
    [DataRow(new[] { "a" }, new[] { "A" }, new[] { "a" })]
    [DataRow(new[] { "a" }, new[] { "e" }, new[] { "a" })]
    [DataRow(new[] { "b" }, new[] { "B", "c" }, new[] { "b", "" })]
    [DataRow(new[] { "abc" }, new[] { "ABC", "abc", "Abc", "ebc", "ebd" }, new[] { "abc", "abc", "abc", "abc", "" })]
    [DataRow(new[] { "Hello", "hello" }, new[] { "hello", "HELLO", "hallo", "HOLLO", "hillu" }, new[] { "hello", "Hello", "Hello", "Hello", "Hello" })]
    [DataRow(new[] { "hello", "Hello" }, new[] { "HELLO", "hallo", "Hallo" }, new[] { "hello", "hello", "hello" })]
    [DataRow(new[] { "ae", "ea" }, new[] { "AE", "EA", "ie", "oo", "uu" }, new[] { "ae", "ea", "ae", "ae", "ae" })]
    [DataRow(new[] { "xyz" }, new[] { "xyz", "XYZ", "xyZ", "xyy" }, new[] { "xyz", "xyz", "xyz", "" })]
    [DataRow(new[] { "Yellow", "yollow" }, new[] { "yellow", "YELLOW", "yallaw", "yillow" }, new[] { "Yellow", "Yellow", "Yellow", "Yellow" })]
    [DataRow(new[] { "bcd" }, new[] { "bcd", "BCD", "bce", "acd" }, new[] { "bcd", "bcd", "", "" })]
    [DataRow(new[] { "apple", "Apple", "APPLE" }, new[] { "apple", "Apple", "APPLE", "ApPlE", "epplo", "aqple" }, new[] { "apple", "Apple", "APPLE", "apple", "apple", "" })]
    [DataRow(new[] { "tree", "Tree" }, new[] { "TREE", "tras", "trae", "trea" }, new[] { "tree", "", "tree", "tree" })]
    [DataRow(new[] { "queen", "Queen" }, new[] { "QUEEN", "qaaen", "qeeun", "quuuuen" }, new[] { "queen", "queen", "queen", "" })]
    [DataRow(new[] { "zebra", "Zebra" }, new[] { "ZEBRA", "zibro", "zobra", "zebr" }, new[] { "zebra", "zebra", "zebra", "" })]
    [DataRow(new[] { "sun" }, new[] { "SUN", "san", "sin", "son", "sen", "sunn" }, new[] { "sun", "sun", "sun", "sun", "sun", "" })]
    [DataRow(new[] { "code", "Code", "coda" }, new[] { "CODE", "cude", "CUDA", "codu", "cedo" }, new[] { "code", "code", "code", "code", "code" })]
    [DataRow(new[] { "rhythm" }, new[] { "RHYTHM", "rhythm", "rhythn" }, new[] { "rhythm", "rhythm", "" })]
    [DataRow(new[] { "aaaaaaa", "bbbbbbb" }, new[] { "AAAAAAA", "eeeeeee", "BBBBBBB", "bbbbbbb", "bbbbbbc" }, new[] { "aaaaaaa", "aaaaaaa", "bbbbbbb", "bbbbbbb", "" })]
    public void Spellchecker_WithExactMatchCapitalization_ReturnsCorrectWordFromWordlist(string[] wordlist, string[] queries, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Spellchecker(wordlist, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}