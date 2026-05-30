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

using LeetCode.Algorithms.MinimumNumberOfOperationsToSortBinaryTreeByLevel;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfOperationsToSortBinaryTreeByLevel;

public abstract class MinimumNumberOfOperationsToSortBinaryTreeByLevelTestsBase<T> where T : IMinimumNumberOfOperationsToSortBinaryTreeByLevel, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumOperations_WithBinaryTreeInput_ReturnsMinOperationsToSortLevelOrders(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumOperations(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, 2, 3, 4, 5, 6 }, 0];

        yield return [new int?[] { 1, 3, 2, 7, 6, 5, 4 }, 3];

        yield return [new int?[] { 1, 4, 3, 7, 6, 8, 5, null, null, null, null, 9, null, 10 }, 3];
    }
}