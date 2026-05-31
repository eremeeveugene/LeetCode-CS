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

using LeetCode.Algorithms.SearchInBinarySearchTree;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.SearchInBinarySearchTree;

public abstract class SearchInBinarySearchTreeTestsBase<T> where T : ISearchInBinarySearchTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SearchBST_WithGivenRootAndValue_ReturnsSubtree(int?[] rootArray, int val, int?[] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.SearchBST(root, val);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 4, 2, 7, 1, 3 }, 2, new int?[] { 2, 1, 3 }];

        yield return [new int?[] { 4, 2, 7, 1, 3 }, 5, Array.Empty<int?>()];

        // Search for root value
        yield return [new int?[] { 4, 2, 7, 1, 3 }, 4, new int?[] { 4, 2, 7, 1, 3 }];

        // Search for a leaf node
        yield return [new int?[] { 4, 2, 7, 1, 3 }, 1, new int?[] { 1 }];

        // Search for right subtree root
        yield return [new int?[] { 4, 2, 7, 1, 3 }, 7, new int?[] { 7 }];

        // Single node - found
        yield return [new int?[] { 5 }, 5, new int?[] { 5 }];

        // Single node - not found
        yield return [new int?[] { 5 }, 3, Array.Empty<int?>()];

        // Empty tree
        yield return [Array.Empty<int?>(), 1, Array.Empty<int?>()];

        // Left-skewed tree - search root
        yield return [new int?[] { 10, 5, null, 2, null }, 10, new int?[] { 10, 5, null, 2 }];

        // Left-skewed tree - search middle
        yield return [new int?[] { 10, 5, null, 2, null }, 5, new int?[] { 5, 2 }];

        // Left-skewed tree - search leaf
        yield return [new int?[] { 10, 5, null, 2, null }, 2, new int?[] { 2 }];

        // Left-skewed tree - not found
        yield return [new int?[] { 10, 5, null, 2, null }, 7, Array.Empty<int?>()];

        // Right-skewed tree - search root
        yield return [new int?[] { 1, null, 3, null, null, null, 5 }, 1, new int?[] { 1, null, 3, null, null, null, 5 }];

        // Right-skewed tree - search middle
        yield return [new int?[] { 1, null, 3, null, null, null, 5 }, 3, new int?[] { 3, null, 5 }];

        // Right-skewed tree - search leaf
        yield return [new int?[] { 1, null, 3, null, null, null, 5 }, 5, new int?[] { 5 }];

        // Right-skewed tree - not found
        yield return [new int?[] { 1, null, 3, null, null, null, 5 }, 4, Array.Empty<int?>()];

        // Larger balanced BST - search for a subtree
        yield return [new int?[] { 8, 3, 10, 1, 6, null, 14, null, null, 4, 7 }, 3, new int?[] { 3, 1, 6, null, null, 4, 7 }];

        // Larger balanced BST - not found (value too large)
        yield return [new int?[] { 8, 3, 10, 1, 6, null, 14, null, null, 4, 7 }, 15, Array.Empty<int?>()];

        // Search for minimum value in BST
        yield return [new int?[] { 8, 3, 10, 1, 6, null, 14, null, null, 4, 7 }, 1, new int?[] { 1 }];

        // Search for maximum value in BST
        yield return [new int?[] { 8, 3, 10, 1, 6, null, 14, null, null, 4, 7 }, 14, new int?[] { 14 }];
    }
}