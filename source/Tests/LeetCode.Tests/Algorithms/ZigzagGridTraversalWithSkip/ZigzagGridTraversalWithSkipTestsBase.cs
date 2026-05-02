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

using LeetCode.Algorithms.ZigzagGridTraversalWithSkip;

namespace LeetCode.Tests.Algorithms.ZigzagGridTraversalWithSkip;

public abstract class ZigzagGridTraversalWithSkipTestsBase<T> where T : IZigzagGridTraversalWithSkip, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ZigzagTraversal_With2DGrid_ReturnsElementsInZigzagOrder(int[][] grid, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ZigzagTraversal(grid).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 2, 0, 2 }, new[] { new[] { 0, 2 }, new[] { 0, 2 }, new[] { 1, 1 } }, 1];

        yield return [new[] { 1, 1, 1, 1 }, new[] { new[] { 1, 3 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 2 } }, 2];

        yield return [new[] { 1, 2, 3, 4 }, new[] { new[] { 0, 3 } }, -1];

        yield return [new[] { 1 }, new[] { new[] { 0, 0 } }, 1];

        yield return [new[] { 5 }, new[] { new[] { 0, 0 } }, -1];

        yield return [new[] { 0, 0, 0 }, new[] { new[] { 0, 2 } }, 3];

        yield return [new[] { 3, 3, 3 }, new[] { new[] { 0, 2 }, new[] { 0, 2 }, new[] { 0, 2 } }, 3];

        yield return [new[] { 2, 2, 2 }, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, -1];

        yield return [new[] { 1, 2, 1 }, new[] { new[] { 0, 2 }, new[] { 1, 1 } }, 2];

        yield return [new[] { 1, 1, 1, 5 }, new[] { new[] { 0, 2 }, new[] { 0, 2 }, new[] { 3, 3 } }, 2];
    }
}