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

using LeetCode.Algorithms.SwimInRisingWater;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SwimInRisingWater;

public abstract class SwimInRisingWaterTestsBase<T> where T : ISwimInRisingWater, new()
{
    [TestMethod]
    [DataRow("[[0,2],[1,3]]", 3)]
    [DataRow("[[0,1,2,3,4],[24,23,22,21,5],[12,13,14,15,16],[11,17,18,19,20],[10,9,8,7,6]]", 16)]
    public void SwimInWater_WithElevatedGrid_ReturnsMinimumTimeToReachBottomRight(string gridArray, int expectedResult)
    {
        // Arrange
        var grid = JsonHelper.Parse<int[][]>(gridArray);

        var solution = new T();

        // Act
        var actualResult = solution.SwimInWater(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}