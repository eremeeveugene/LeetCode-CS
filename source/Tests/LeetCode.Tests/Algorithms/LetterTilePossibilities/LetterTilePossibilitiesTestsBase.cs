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

using LeetCode.Algorithms.LetterTilePossibilities;

namespace LeetCode.Tests.Algorithms.LetterTilePossibilities;

public abstract class LetterTilePossibilitiesTestsBase<T> where T : ILetterTilePossibilities, new()
{
    [TestMethod]
    [DataRow("AAB", 8)]
    [DataRow("AAABBC", 188)]
    [DataRow("V", 1)]
    [DataRow("A", 1)]
    [DataRow("AA", 2)]
    [DataRow("AB", 4)]
    [DataRow("ABC", 15)]
    [DataRow("AAA", 3)]
    [DataRow("AAAA", 4)]
    [DataRow("AABB", 18)]
    [DataRow("ABCD", 64)]
    [DataRow("AAAB", 13)]
    [DataRow("ABAB", 18)]
    [DataRow("ZZZZZZ", 6)]
    [DataRow("ABCDEFG", 13699)]
    [DataRow("AABBCC", 270)]
    [DataRow("AAABBBC", 447)]
    [DataRow("ZYXW", 64)]
    [DataRow("MMMMNN", 54)]
    [DataRow("QWERTY", 1956)]
    public void NumTilePossibilities_WithGivenTiles_ReturnsNumberOfUniqueSequences(string tiles, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumTilePossibilities(tiles);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}