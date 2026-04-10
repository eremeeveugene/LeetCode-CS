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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.EqualSumGridPartition1;

public abstract class EqualSumGridPartition1TestsBase<T> where T : IEqualSumGridPartition1, new()
{
    [TestMethod]
    [DataRow("[[1,4],[2,3]]", true)]
    [DataRow("[[1,3],[2,4]]", false)]
    public void CanPartitionGrid_WithGivenGrid_ReturnsTrueIfEqualSumPartitionExists(string gridJson,
        bool expectedResult)
    {
        // Arrange
        var grid = JsonHelper.Parse<int[][]>(gridJson);

        var solution = new T();

        // Act
        var actualResult = solution.CanPartitionGrid(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}