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

using LeetCode.Algorithms.FloodFill;

namespace LeetCode.Tests.Algorithms.FloodFill;

public abstract class FloodFillTestsBase<T> where T : IFloodFill, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FloodFill_WithInitialPositionAndNewColor_ReturnsModifiedImage(int[][] image, int sr, int sc, int color, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FloodFill(image, sr, sc, color);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 0, 0, 0, new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 1, 0, 2, new[] { new[] { 2, 2, 2 }, new[] { 2, 2, 2 } }];

        yield return
        [
            new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 0 }, new[] { 1, 0, 1 } }, 1, 1, 2,
            new[] { new[] { 2, 2, 2 }, new[] { 2, 2, 0 }, new[] { 2, 0, 1 } }
        ];
    }
}