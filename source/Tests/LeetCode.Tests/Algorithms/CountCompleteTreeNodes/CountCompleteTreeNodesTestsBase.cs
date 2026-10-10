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

using LeetCode.Algorithms.CountCompleteTreeNodes;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.CountCompleteTreeNodes;

public abstract class CountCompleteTreeNodesTestsBase<T> where T : ICountCompleteTreeNodes, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CountNodes_WithCompleteBinaryTree_ReturnsTotalNumberOfNodes(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.CountNodes(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), 0];

        yield return [new int?[] { 1 }, 1];

        yield return [new int?[] { 1, 2, 3, 4 }, 4];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6 }, 6];

        yield return [new int?[] { 1, 2 }, 2];

        yield return [new int?[] { 1, 2, 3 }, 3];

        yield return [new int?[] { 1, 2, 3, 4, 5 }, 5];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, 7];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 11];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 12];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, 13];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 14];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 15];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 16];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }, 17];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, 20];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 }, 31];
    }
}