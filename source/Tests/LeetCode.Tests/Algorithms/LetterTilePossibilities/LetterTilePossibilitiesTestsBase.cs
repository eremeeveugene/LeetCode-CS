// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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