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

using LeetCode.Algorithms.FindTheMinimumAreaToCoverAllOnes1;

namespace LeetCode.Tests.Algorithms.FindTheMinimumAreaToCoverAllOnes1;

public abstract class FindTheMinimumAreaToCoverAllOnes1TestsBase<T> where T : IFindTheMinimumAreaToCoverAllOnes1, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumArea_WithBinaryGrid_ReturnsMinimumBoundingAreaOfOnes(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumArea(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1, 0 }, new[] { 1, 0, 1 } }, 6];

        yield return [new[] { new[] { 1, 0 }, new[] { 0, 0 } }, 1];

        yield return [new[] { new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 1, 0 } }, 1];

        yield return [new[] { new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 1, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 1, 0, 1, 0 }, new[] { 0, 0, 0, 0, 0 } }, 9];

        yield return [new[] { new[] { 0, 0, 0, 1 }, new[] { 0, 0, 0, 0 }, new[] { 0, 1, 0, 0 }, new[] { 0, 0, 0, 1 } }, 12];

        yield return [new[] { new[] { 1 } }, 1];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, 4];

        yield return [new[] { new[] { 1, 0 }, new[] { 1, 0 } }, 2];

        yield return [new[] { new[] { 0, 1 }, new[] { 0, 1 } }, 2];

        yield return [new[] { new[] { 1, 1, 1 } }, 3];

        yield return [new[] { new[] { 1 }, new[] { 1 }, new[] { 1 } }, 3];

        yield return [new[] { new[] { 1, 0, 1 } }, 3];

        yield return [new[] { new[] { 1 }, new[] { 0 }, new[] { 1 } }, 3];

        yield return [new[] { new[] { 1, 1, 0, 0 }, new[] { 1, 1, 0, 0 }, new[] { 0, 0, 0, 0 } }, 4];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 0 } }, 1];

        yield return [new[] { new[] { 1, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 1 } }, 9];

        yield return [new[] { new[] { 1, 0, 1 }, new[] { 0, 0, 0 }, new[] { 1, 0, 1 } }, 9];

        yield return [new[] { new[] { 0, 1, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 1, 0, 0 } }, 3];

        yield return [new[] { new[] { 1, 1, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 1 } }, 9];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 1 } }, 1];
    }
}