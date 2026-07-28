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

using LeetCode.Algorithms.SuccessfulPairsOfSpellsAndPotions;

namespace LeetCode.Tests.Algorithms.SuccessfulPairsOfSpellsAndPotions;

public abstract class SuccessfulPairsOfSpellsAndPotionsTestsBase<T> where T : ISuccessfulPairsOfSpellsAndPotions, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 1, 3 }, new[] { 1, 2, 3, 4, 5 }, 7L, new[] { 4, 0, 3 })]
    [DataRow(new[] { 3, 1, 2 }, new[] { 8, 5, 8 }, 16L, new[] { 2, 0, 2 })]
    [DataRow(new[] { 15, 8, 19 }, new[] { 38, 36, 23 }, 328L, new[] { 3, 0, 3 })]
    [DataRow(new[] { 1 }, new[] { 1 }, 1L, new[] { 1 })]
    [DataRow(new[] { 1 }, new[] { 1 }, 2L, new[] { 0 })]
    [DataRow(new[] { 10 }, new[] { 10 }, 100L, new[] { 1 })]
    [DataRow(new[] { 10 }, new[] { 9 }, 100L, new[] { 0 })]
    [DataRow(new[] { 2, 4, 6 }, new[] { 2, 2, 2 }, 8L, new[] { 0, 3, 3 })]
    [DataRow(new[] { 5, 5, 5 }, new[] { 5, 5, 5 }, 25L, new[] { 3, 3, 3 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1 }, 3L, new[] { 0, 0, 1, 1, 1 })]
    [DataRow(new[] { 3 }, new[] { 1, 2, 3, 4, 5 }, 10L, new[] { 2 })]
    [DataRow(new[] { 100000 }, new[] { 100000 }, 10000000000L, new[] { 1 })]
    [DataRow(new[] { 100000 }, new[] { 99999 }, 10000000000L, new[] { 0 })]
    [DataRow(new[] { 2, 2 }, new[] { 3, 3 }, 6L, new[] { 2, 2 })]
    [DataRow(new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, 1L, new[] { 3, 3, 3 })]
    [DataRow(new[] { 4 }, new[] { 1, 2, 3 }, 100L, new[] { 0 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 }, 7L, new[] { 0, 2, 3, 4, 4 })]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5 }, 7L, new[] { 4, 4, 4, 3, 2, 0 })]
    [DataRow(new[] { 7 }, new[] { 1, 2, 3, 4, 5, 6, 7 }, 7L, new[] { 7 })]
    [DataRow(new[] { 7 }, new[] { 1, 2, 3, 4, 5, 6, 7 }, 8L, new[] { 6 })]
    [DataRow(new[] { 2, 3 }, new[] { 10, 10 }, 20L, new[] { 2, 2 })]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, new[] { 2, 4, 6, 8, 10 }, 30L, new[] { 0, 1, 3, 3, 4 })]
    public void SuccessfulPairs_WithSpellsPotionsAndSuccess_ReturnsSuccessfulPairCounts(
        int[] spells,
        int[] potions,
        long success,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SuccessfulPairs(spells, potions, success);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}