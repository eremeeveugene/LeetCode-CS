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
    }
}