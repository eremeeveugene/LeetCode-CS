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

using LeetCode.Algorithms.TrappingRainWater2;

namespace LeetCode.Tests.Algorithms.TrappingRainWater2;

public abstract class TrappingRainWater2TestsBase<T> where T : ITrappingRainWater2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void TrapRainWater_WithHeightMap_ReturnsTrappedWaterVolume(int[][] heightMap, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TrapRainWater(heightMap);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 4, 3, 1, 3, 2 }, new[] { 3, 2, 1, 3, 2, 4 }, new[] { 2, 3, 3, 2, 3, 1 } }, 4];

        yield return
        [
            new[] { new[] { 3, 3, 3, 3, 3 }, new[] { 3, 2, 2, 2, 3 }, new[] { 3, 2, 1, 2, 3 }, new[] { 3, 2, 2, 2, 3 }, new[] { 3, 3, 3, 3, 3 } },
            10
        ];

        yield return [new[] { new[] { 1 } }, 0];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 0];

        yield return [new[] { new[] { 1, 2, 3, 4, 5 } }, 0];

        yield return [new[] { new[] { 3 }, new[] { 1 }, new[] { 3 } }, 0];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, 0];

        yield return [new[] { new[] { 2, 2, 2 }, new[] { 2, 5, 2 }, new[] { 2, 2, 2 } }, 0];

        yield return [new[] { new[] { 5, 5, 5 }, new[] { 5, 1, 5 }, new[] { 5, 5, 5 } }, 4];

        yield return [new[] { new[] { 5, 5, 5 }, new[] { 5, 1, 5 }, new[] { 5, 3, 5 } }, 2];

        yield return [new[] { new[] { 3, 3, 3 }, new[] { 3, 0, 3 }, new[] { 3, 3, 3 } }, 3];

        yield return [new[] { new[] { 2, 3, 4 }, new[] { 5, 1, 6 }, new[] { 7, 8, 9 } }, 2];

        yield return [new[] { new[] { 5, 5, 5, 5 }, new[] { 5, 1, 1, 5 }, new[] { 5, 5, 5, 5 } }, 8];

        yield return [new[] { new[] { 5, 5, 5, 5 }, new[] { 5, 1, 2, 5 }, new[] { 5, 5, 5, 5 } }, 7];

        yield return [new[] { new[] { 5, 5, 5, 5 }, new[] { 5, 1, 1, 5 }, new[] { 5, 1, 1, 5 }, new[] { 5, 5, 5, 5 } }, 16];

        yield return [new[] { new[] { 4, 4, 4, 4 }, new[] { 4, 0, 0, 4 }, new[] { 4, 0, 0, 4 }, new[] { 4, 4, 4, 1 } }, 16];

        yield return [new[] { new[] { 5, 5, 5, 5 }, new[] { 5, 2, 3, 5 }, new[] { 5, 4, 1, 5 }, new[] { 5, 5, 5, 5 } }, 10];

        yield return [new[] { new[] { 5, 5, 5, 5 }, new[] { 5, 2, 3, 5 }, new[] { 5, 4, 1, 5 }, new[] { 5, 5, 2, 5 } }, 2];

        yield return [new[] { new[] { 9, 9, 9, 9, 9 }, new[] { 9, 1, 9, 1, 9 }, new[] { 9, 9, 9, 9, 9 } }, 16];

        yield return [new[] { new[] { 9, 9, 9, 9, 9 }, new[] { 9, 1, 5, 1, 9 }, new[] { 9, 9, 9, 9, 9 } }, 20];

        yield return [new[] { new[] { 5, 5, 5, 5, 5 }, new[] { 5, 1, 5, 1, 5 }, new[] { 5, 5, 5, 0, 5 } }, 4];

        yield return
        [
            new[]
            {
                new[] { 12, 13, 1, 12 }, new[] { 13, 4, 13, 12 }, new[] { 13, 8, 10, 12 }, new[] { 12, 13, 12, 12 }, new[] { 13, 13, 13, 13 }
            },
            14
        ];
    }
}