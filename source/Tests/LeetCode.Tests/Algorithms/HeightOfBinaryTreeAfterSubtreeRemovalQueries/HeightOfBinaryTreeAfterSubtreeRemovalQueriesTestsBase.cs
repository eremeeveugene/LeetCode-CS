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

using LeetCode.Algorithms.HeightOfBinaryTreeAfterSubtreeRemovalQueries;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.HeightOfBinaryTreeAfterSubtreeRemovalQueries;

public abstract class HeightOfBinaryTreeAfterSubtreeRemovalQueriesTestsBase<T> where T : IHeightOfBinaryTreeAfterSubtreeRemovalQueries, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void TreeQueries_WithSubtreeRemovedAtGivenNode_ReturnsHeightOfTreeAfterRemoval(int?[] rootArray, int[] queries, int[] expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.TreeQueries(root, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, 3, 4, 2, null, 6, 5, null, null, null, null, null, 7 }, new[] { 4 }, new[] { 2 }];

        yield return [new int?[] { 5, 8, 9, 2, 1, 3, 7, 4, 6 }, new[] { 3, 2, 4, 8 }, new[] { 3, 2, 3, 2 }];

        yield return [new int?[] { 1, null, 5, 3, null, 2, 4 }, new[] { 3, 5, 4, 2, 4 }, new[] { 1, 0, 3, 3, 3 }];
    }
}