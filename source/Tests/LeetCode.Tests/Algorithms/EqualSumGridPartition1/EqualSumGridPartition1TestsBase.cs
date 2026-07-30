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

using LeetCode.Algorithms.EqualSumGridPartition1;

namespace LeetCode.Tests.Algorithms.EqualSumGridPartition1;

public abstract class EqualSumGridPartition1TestsBase<T> where T : IEqualSumGridPartition1, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CanPartitionGrid_WithGivenGrid_ReturnsTrueIfEqualSumPartitionExists(int[][] grid, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanPartitionGrid(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 4 }, new[] { 2, 3 } }, true];

        yield return [new[] { new[] { 1, 3 }, new[] { 2, 4 } }, false];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, false];

        yield return [new[] { new[] { 3, 3 }, new[] { 3, 3 } }, true];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 2 } }, false];

        yield return [new[] { new[] { 2, 2 }, new[] { 2, 2 } }, true];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, false];

        yield return [new[] { new[] { 4, 4 }, new[] { 4, 4 } }, true];

        yield return [new[] { new[] { 1, 5, 1 }, new[] { 1, 5, 1 } }, true];

        yield return [new[] { new[] { 10, 5 }, new[] { 5, 10 } }, true];

        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 } }, false];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 3, 2, 1 } }, true];

        yield return [new[] { new[] { 5, 5, 5 }, new[] { 5, 5, 5 } }, true];

        yield return [new[] { new[] { 6, 3, 3 }, new[] { 1, 4, 7 } }, true];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }, false];

        yield return [new[] { new[] { 3, 2, 1 }, new[] { 1, 2, 3 }, new[] { 2, 2, 2 } }, false];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, true];

        yield return [new[] { new[] { 9, 1 }, new[] { 1, 9 } }, true];

        yield return [new[] { new[] { 1, 1 }, new[] { 3, 3 } }, true];
    }
}