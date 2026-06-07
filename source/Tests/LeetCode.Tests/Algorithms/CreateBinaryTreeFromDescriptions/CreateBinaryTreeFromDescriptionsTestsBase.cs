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

using LeetCode.Algorithms.CreateBinaryTreeFromDescriptions;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.CreateBinaryTreeFromDescriptions;

public abstract class CreateBinaryTreeFromDescriptionsTestsBase<T> where T : ICreateBinaryTreeFromDescriptions, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CreateBinaryTree_WithDescriptions_ReturnsBinaryTreeConstructedFromDescriptions(int[][] descriptions, int?[] expectedResultArray)
    {
        // Arrange
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.CreateBinaryTree(descriptions);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        // LeetCode sample 1 - mixed five-node tree.
        yield return [new[] { new[] { 20, 15, 1 }, new[] { 20, 17, 0 }, new[] { 50, 20, 1 }, new[] { 50, 80, 0 }, new[] { 80, 19, 1 } }, new int?[] { 50, 20, 80, 15, 17, 19 }];

        // LeetCode sample 2 - left-then-right zigzag.
        yield return [new[] { new[] { 1, 2, 1 }, new[] { 2, 3, 0 }, new[] { 3, 4, 1 } }, new int?[] { 1, 2, null, null, 3, 4 }];

        // Empty descriptions -> null root.
        yield return [Array.Empty<int[]>(), Array.Empty<int?>()];

        // Single edge - left child only.
        yield return [new[] { new[] { 1, 2, 1 } }, new int?[] { 1, 2 }];

        // Single edge - right child only.
        yield return [new[] { new[] { 1, 2, 0 } }, new int?[] { 1, null, 2 }];

        // Root with both children, left described first.
        yield return [new[] { new[] { 1, 2, 1 }, new[] { 1, 3, 0 } }, new int?[] { 1, 2, 3 }];

        // Root with both children, right described first (order independence).
        yield return [new[] { new[] { 1, 3, 0 }, new[] { 1, 2, 1 } }, new int?[] { 1, 2, 3 }];

        // Fully left-skewed tree of depth 4.
        yield return [new[] { new[] { 1, 2, 1 }, new[] { 2, 3, 1 }, new[] { 3, 4, 1 } }, new int?[] { 1, 2, null, 3, null, 4 }];

        // Fully right-skewed tree of depth 4.
        yield return [new[] { new[] { 1, 2, 0 }, new[] { 2, 3, 0 }, new[] { 3, 4, 0 } }, new int?[] { 1, null, 2, null, 3, null, 4 }];

        // Perfect tree of depth 3 (7 nodes).
        yield return [new[] { new[] { 1, 2, 1 }, new[] { 1, 3, 0 }, new[] { 2, 4, 1 }, new[] { 2, 5, 0 }, new[] { 3, 6, 1 }, new[] { 3, 7, 0 } }, new int?[] { 1, 2, 3, 4, 5, 6, 7 }];

        // Child described before its parent (reverse-topological order).
        yield return [new[] { new[] { 2, 3, 0 }, new[] { 1, 2, 1 } }, new int?[] { 1, 2, null, null, 3 }];

        // Same tree as sample 2 but with descriptions in shuffled order.
        yield return [new[] { new[] { 3, 4, 1 }, new[] { 1, 2, 1 }, new[] { 2, 3, 0 } }, new int?[] { 1, 2, null, null, 3, 4 }];

        // Right-only root with two grandchildren.
        yield return [new[] { new[] { 1, 2, 0 }, new[] { 2, 3, 1 }, new[] { 2, 4, 0 } }, new int?[] { 1, null, 2, 3, 4 }];

        // Left-only root with two grandchildren.
        yield return [new[] { new[] { 1, 2, 1 }, new[] { 2, 3, 1 }, new[] { 2, 4, 0 } }, new int?[] { 1, 2, null, 3, 4 }];

        // Minimum and maximum allowed node values on a single edge.
        yield return [new[] { new[] { 1, 100_000, 1 } }, new int?[] { 1, 100_000 }];

        // Maximum value used as the root.
        yield return [new[] { new[] { 100_000, 1, 0 } }, new int?[] { 100_000, null, 1 }];

        // Boundary values mixed with an interior node.
        yield return [new[] { new[] { 1, 100_000, 1 }, new[] { 100_000, 50_000, 0 } }, new int?[] { 1, 100_000, null, null, 50_000 }];

        // Non-sequential node values forming a balanced sub-tree.
        yield return [new[] { new[] { 5, 10, 1 }, new[] { 10, 3, 1 }, new[] { 10, 8, 0 } }, new int?[] { 5, 10, null, 3, 8 }];

        // Complete tree where the last level is partially filled.
        yield return [new[] { new[] { 1, 2, 1 }, new[] { 1, 3, 0 }, new[] { 2, 4, 1 } }, new int?[] { 1, 2, 3, 4 }];

        // Right-then-left zigzag.
        yield return [new[] { new[] { 1, 2, 0 }, new[] { 2, 3, 1 } }, new int?[] { 1, null, 2, 3 }];

        // Bottom-heavy on the right subtree only.
        yield return [new[] { new[] { 1, 2, 1 }, new[] { 1, 3, 0 }, new[] { 3, 4, 1 }, new[] { 3, 5, 0 } }, new int?[] { 1, 2, 3, null, null, 4, 5 }];

        // Asymmetric tree with gaps on both sides at depth 3.
        yield return [new[] { new[] { 1, 2, 1 }, new[] { 1, 3, 0 }, new[] { 2, 4, 1 }, new[] { 3, 5, 0 } }, new int?[] { 1, 2, 3, 4, null, null, 5 }];
    }
}