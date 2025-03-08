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

using LeetCode.Algorithms.MinimumRecolorsToGetKConsecutiveBlackBlocks;

namespace LeetCode.Tests.Algorithms.MinimumRecolorsToGetKConsecutiveBlackBlocks;

public abstract class MinimumRecolorsToGetKConsecutiveBlackBlocksTestsBase<T>
    where T : IMinimumRecolorsToGetKConsecutiveBlackBlocks, new()
{
    [TestMethod]
    [DataRow("WBBWWBBWBW", 7, 3)]
    [DataRow("WBWBBBW", 2, 0)]
    [DataRow("BWWWBB", 6, 3)]
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