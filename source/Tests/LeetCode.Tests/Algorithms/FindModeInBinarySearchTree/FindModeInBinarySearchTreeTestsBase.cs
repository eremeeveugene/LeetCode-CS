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

using LeetCode.Algorithms.FindModeInBinarySearchTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FindModeInBinarySearchTree;

public abstract class FindModeInBinarySearchTreeTestsBase<T> where T : IFindModeInBinarySearchTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindMode_WithBinaryTree_ReturnsModeValues(int?[] rootArray, int[] expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindMode(root);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int>()];

        yield return [new int?[] { 0 }, new[] { 0 }];

        yield return [new int?[] { 1, null, 2, 2 }, new[] { 2 }];

        yield return [new int?[] { 5 }, new[] { 5 }];

        yield return [new int?[] { 1, null, 3 }, new[] { 1, 3 }];

        yield return [new int?[] { 5, 5, null, 3 }, new[] { 5 }];

        yield return [new int?[] { 1, null, 5, 3 }, new[] { 1, 3, 5 }];

        yield return [new int?[] { 4, 4, null, 1, null, 1 }, new[] { 1, 4 }];

        yield return [new int?[] { 1, null, 4, 2, 6, null, 3 }, new[] { 1, 2, 3, 4, 6 }];

        yield return [new int?[] { 1, null, 4, 3, 5, null, null, 5 }, new[] { 5 }];

        yield return [new int?[] { 4, 2, 6, 2, 4, null, null, 2 }, new[] { 2 }];

        yield return [new int?[] { 4, 4, 6, 2, null, 6, null, null, null, 5, null, 5 }, new[] { 4, 5, 6 }];

        yield return [new int?[] { 5, 4, 6, 3, 5, null, null, 3, 4, null, null, 2 }, new[] { 3, 4, 5 }];

        yield return [new int?[] { 4, 2, 5, null, 3, 5, 6, 3, 4, null, null, 6 }, new[] { 3, 4, 5, 6 }];

        yield return [new int?[] { 4, 1, 5, null, 3, null, 6, 2, null, 6, null, 2, 3, null, null, null, null, 3 }, new[] { 3 }];

        yield return [new int?[] { 1, null, 5, 4, 6, 2, 5, 6, null, null, 4, null, null, 6, null, 4, null, null, null, 4, null, 3 }, new[] { 4 }];

        yield return [new int?[] { 2, 2, 3, 1, null, 3, 6, 1, null, null, null, 6, null, null, null, 6, null, 6, null, 6, null, 6, null, 6, null, 4 }, new[] { 6 }];

        yield return [new int?[] { 4, 2, 5, 2, 4, 5, 6, 1, null, 3, null, null, null, 6, null, 1, null, 3, null, 6, null, 1, null, null, null, null, null, 1, null, 1 }, new[] { 1 }];

        yield return [new int?[] { 1, 1, 5, 1, null, 2, 6, 1, null, 2, 4, 6, null, 1, null, 2, null, 3, null, null, null, 1, null, 2, null, 3, 4, null, null, 2 }, new[] { 1 }];

        yield return [new int?[] { 2, 1, 6, 1, 2, 6, null, 1, null, 2, null, 4, null, 1, null, 2, null, 3, 6, null, null, 2, null, null, null, 5, null, 2, null, 5, 6, 2, null, 5 }, new[] { 2 }];
    }
}