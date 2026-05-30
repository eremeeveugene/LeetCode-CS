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

using LeetCode.Algorithms.CountOfSubstringsContainingEveryVowelAndKConsonants2;

namespace LeetCode.Tests.Algorithms.CountOfSubstringsContainingEveryVowelAndKConsonants2;

public abstract class CountOfSubstringsContainingEveryVowelAndKConsonants2TestsBase<T> where T : ICountOfSubstringsContainingEveryVowelAndKConsonants2, new()
{
    [TestMethod]
    [DataRow("aeioqq", 1, 0)]
    [DataRow("aeiou", 0, 1)]
    [DataRow("ieaouqqieaouqq", 1, 3)]
    [DataRow("iqeaouqi", 2, 3)]
    public void CountOfSubstrings_WithWordAndK_ReturnsSubstringCount(string word, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountOfSubstrings(word, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}