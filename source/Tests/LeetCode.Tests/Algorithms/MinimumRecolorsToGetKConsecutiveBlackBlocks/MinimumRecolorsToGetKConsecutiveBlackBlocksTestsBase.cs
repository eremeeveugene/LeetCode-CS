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

using LeetCode.Algorithms.MinimumRecolorsToGetKConsecutiveBlackBlocks;

namespace LeetCode.Tests.Algorithms.MinimumRecolorsToGetKConsecutiveBlackBlocks;

public abstract class MinimumRecolorsToGetKConsecutiveBlackBlocksTestsBase<T> where T : IMinimumRecolorsToGetKConsecutiveBlackBlocks, new()
{
    [TestMethod]
    [DataRow("WBBWWBBWBW", 7, 3)]
    [DataRow("WBWBBBW", 2, 0)]
    [DataRow("BWWWBB", 6, 3)]
    [DataRow("B", 1, 0)]
    [DataRow("W", 1, 1)]
    [DataRow("BW", 1, 0)]
    [DataRow("WB", 2, 1)]
    [DataRow("BB", 2, 0)]
    [DataRow("WW", 1, 1)]
    [DataRow("WWWW", 4, 4)]
    [DataRow("BBBB", 2, 0)]
    [DataRow("BWBWBW", 3, 1)]
    [DataRow("WBBBW", 3, 0)]
    [DataRow("WWBWW", 2, 1)]
    [DataRow("BWWWWWB", 4, 3)]
    [DataRow("WWWWWWWW", 3, 3)]
    [DataRow("BBWBB", 5, 1)]
    [DataRow("BWBWBWBWBW", 5, 2)]
    [DataRow("WBWBWBWBWB", 9, 4)]
    [DataRow("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", 50, 0)]
    [DataRow("WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW", 100, 100)]
    [DataRow("WBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWBWB", 100, 50)]
    [DataRow("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", 60, 20)]
    [DataRow("WBBW", 2, 0)]
    [DataRow("BWBBBBWBW", 6, 1)]
    public void MinimumRecolors_WithBlocksAndK_ReturnsMinimumRecolorCount(string blocks, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumRecolors(blocks, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}