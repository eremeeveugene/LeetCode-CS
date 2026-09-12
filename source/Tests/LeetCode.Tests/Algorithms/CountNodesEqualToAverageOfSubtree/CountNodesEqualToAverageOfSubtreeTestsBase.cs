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

using LeetCode.Algorithms.CountNodesEqualToAverageOfSubtree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.CountNodesEqualToAverageOfSubtree;

public abstract class CountNodesEqualToAverageOfSubtreeTestsBase<T> where T : ICountNodesEqualToAverageOfSubtree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void AverageOfSubtree_WithGivenTree_ReturnsNumberOfNodesEqualToSubtreeAverage(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.AverageOfSubtree(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 4, 8, 5, 0, 1, null, 6 }, 5];

        yield return [new int?[] { 1 }, 1];

        yield return [new int?[] { 0 }, 1];

        yield return [new int?[] { 1000 }, 1];

        yield return [new int?[] { 1, 1, 1 }, 3];

        yield return [new int?[] { 0, 0, 0 }, 3];

        yield return [new int?[] { 1000, 1000, 1000 }, 3];

        yield return [new int?[] { 2, 1, 3 }, 3];

        yield return [new int?[] { 1, 2, 3 }, 2];

        yield return [new int?[] { 3, 1, 2 }, 2];

        yield return [new int?[] { 1, 2 }, 2];

        yield return [new int?[] { 2, 1 }, 1];

        yield return [new int?[] { 1, null, 2 }, 2];

        yield return [new int?[] { 2, null, 1 }, 1];

        yield return [new int?[] { 0, 1 }, 2];

        yield return [new int?[] { 1, 0 }, 1];

        yield return [new int?[] { 1, 1 }, 2];

        yield return [new int?[] { 1, null, 1 }, 2];

        yield return [new int?[] { 2, 1, 4 }, 3];

        yield return [new int?[] { 2, 1, 5 }, 3];

        yield return [new int?[] { 2, 1, 6 }, 2];

        yield return [new int?[] { 0, 0, 0, 0, 0, 0, 0 }, 7];

        yield return [new int?[] { 5, 5, 5, 5, 5, 5, 5 }, 7];

        yield return [new int?[] { 3, 2, null, 1 }, 1];

        yield return [new int?[] { 1, null, 2, null, 3 }, 2];
    }
}