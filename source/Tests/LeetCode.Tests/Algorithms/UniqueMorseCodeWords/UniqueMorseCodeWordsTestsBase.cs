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

using LeetCode.Algorithms.UniqueMorseCodeWords;

namespace LeetCode.Tests.Algorithms.UniqueMorseCodeWords;

public abstract class UniqueMorseCodeWordsTestsBase<T> where T : IUniqueMorseCodeWords, new()
{
    [TestMethod]
    [DataRow(new[] { "gin", "zen", "gig", "msg" }, 2)]
    [DataRow(new[] { "a" }, 1)]
    [DataRow(new[] { "a", "a" }, 1)]
    [DataRow(new[] { "a", "b" }, 2)]
    [DataRow(new[] { "e", "t" }, 2)]
    [DataRow(new[] { "a", "et" }, 1)]
    [DataRow(new[] { "i", "ee" }, 1)]
    [DataRow(new[] { "ee", "i", "eee", "ie", "ei", "s" }, 2)]
    [DataRow(new[] { "abcdefghijkl" }, 1)]
    [DataRow(new[] { "abcdefghijkl", "abcdefghijkl" }, 1)]
    [DataRow(new[] { "z", "zz", "zzz", "zzzz" }, 4)]
    [DataRow(new[] { "tt", "m", "ttt", "mm", "tm", "mt" }, 3)]
    [DataRow(new[] { "gin", "zen", "gig", "msg", "gin" }, 2)]
    [DataRow(new[] { "hello", "world", "hello", "world" }, 2)]
    [DataRow(new[] { "et", "a", "te", "n" }, 2)]
    [DataRow(new[] { "ab", "ba" }, 2)]
    [DataRow(new[] { "q", "gm", "zn" }, 3)]
    [DataRow(new[] { "zzzzzzzzzzzz", "yyyyyyyyyyyy", "zzzzzzzzzzzz" }, 2)]
    [DataRow(new[] { "abcabcabcabc", "cbacbacbacba", "bcabcabcabca", "abcabcabcabc" }, 3)]
    [DataRow(new[] { "eeeeeeeeeeee", "iiiiii", "sssz" }, 2)]
    public void UniqueMorseRepresentations_GivenWordsArray_ReturnsCountOfUniqueRepresentations(string[] words, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.UniqueMorseRepresentations(words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}