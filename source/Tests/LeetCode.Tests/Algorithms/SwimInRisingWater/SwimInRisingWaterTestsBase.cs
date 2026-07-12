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

namespace LeetCode.Tests.Algorithms.SwimInRisingWater;

public abstract class SwimInRisingWaterTestsBase<T> where T : ISwimInRisingWater, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SwimInWater_WithElevatedGrid_ReturnsMinimumTimeToReachBottomRight(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SwimInWater(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 2 }, new[] { 1, 3 } }, 3];

        yield return
        [
            new[]
            {
                new[] { 0, 1, 2, 3, 4 },
                new[] { 24, 23, 22, 21, 5 },
                new[] { 12, 13, 14, 15, 16 },
                new[] { 11, 17, 18, 19, 20 },
                new[] { 10, 9, 8, 7, 6 }
            },
            16
        ];
    }
}