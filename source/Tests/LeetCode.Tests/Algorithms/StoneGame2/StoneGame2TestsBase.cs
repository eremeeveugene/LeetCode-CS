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

using LeetCode.Algorithms.StoneGame2;

namespace LeetCode.Tests.Algorithms.StoneGame2;

public abstract class StoneGame2TestsBase<T> where T : IStoneGame2, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 2, 7, 9, 4, 4 }, 10)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 100 }, 104)]
    [DataRow(new[] { 100, 10, 100, 100, 100, 100 }, 300)]
    [DataRow(new[] { 5 }, 5)]
    [DataRow(new[] { 1, 2 }, 3)]
    [DataRow(new[] { 7, 3, 1 }, 10)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2)]
    [DataRow(new[] { 10000, 10000 }, 20000)]
    [DataRow(new[] { 1, 100, 1, 100, 1, 100 }, 102)]
    [DataRow(new[] { 3, 9, 1, 2 }, 12)]
    [DataRow(new[] { 4, 4, 4, 4, 4, 4, 4 }, 16)]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60, 70, 80 }, 180)]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 25)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 100 }, 12)]
    [DataRow(new[] { 100, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 107)]
    [DataRow(new[] { 1, 10000, 1, 10000, 1, 10000, 1, 10000 }, 20002)]
    [DataRow(new[] { 1, 7920, 5839, 3758, 1677, 9596, 7515, 5434, 3353, 1272, 9191, 7110, 5029, 2948, 867, 8786, 6705, 4624, 2543, 462, 8381, 6300, 4219, 2138, 57, 7976, 5895, 3814, 1733, 9652, 7571, 5490, 3409, 1328, 9247, 7166, 5085, 3004, 923, 8842, 6761, 4680, 2599, 518, 8437, 6356, 4275, 2194, 113, 8032, 5951, 3870, 1789, 9708, 7627, 5546, 3465, 1384, 9303, 7222, 5141, 3060, 979, 8898, 6817, 4736, 2655, 574, 8493, 6412, 4331, 2250, 169, 8088, 6007, 3926, 1845, 9764, 7683, 5602, 3521, 1440, 9359, 7278, 5197, 3116, 1035, 8954, 6873, 4792, 2711, 630, 8549, 6468, 4387, 2306, 225, 8144, 6063, 3982 }, 246544)]
    [DataRow(new[] { 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000 }, 500000)]
    [DataRow(new[] { 2, 2, 2 }, 4)]
    [DataRow(new[] { 8, 1, 9, 3, 7 }, 18)]
    [DataRow(new[] { 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 50 }, 14)]
    public void StoneGameII_WithGivenPiles_ReturnsMaxPossibleScore(int[] piles, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.StoneGameII(piles);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}