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

using LeetCode.Algorithms.BinaryTreePreorderTraversal;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BinaryTreePreorderTraversal;

public abstract class BinaryTreePreorderTraversalTestsBase<T> where T : IBinaryTreePreorderTraversal, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void PreorderTraversal_WithSerializedBinaryTree_ReturnsNodeValuesInPreorder(int?[] rootArray, int?[] expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.PreorderTraversal(root);

        // Assert
        Assert.IsNotNull(actualResult);
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int?>()];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 1, null, 2, 3 }, new int?[] { 1, 2, 3 }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int?[] { 1, 2, 4, 8, 9, 5, 3, 6, 7 }];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 1, 2 }, new int?[] { 1, 2 }];

        yield return [new int?[] { 1, null, 2 }, new int?[] { 1, 2 }];

        yield return [new int?[] { 1, 2, 3 }, new int?[] { 1, 2, 3 }];

        yield return [new int?[] { 1, 2, null, 3 }, new int?[] { 1, 2, 3 }];

        yield return [new int?[] { 1, null, 2, null, 3 }, new int?[] { 1, 2, 3 }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new int?[] { 1, 2, 4, 5, 3, 6, 7 }];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 5 }, new int?[] { 1, 2, 4, 3, 5 }];

        yield return [new int?[] { -1, -2, -3 }, new int?[] { -1, -2, -3 }];

        yield return [new int?[] { 0, 1, null, 2, null, 3 }, new int?[] { 0, 1, 2, 3 }];

        yield return [new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 }, new int?[] { 5, 4, 11, 7, 2, 8, 13, 4, 5, 1 }];

        yield return [new int?[] { 10, 5, 15, null, null, 6, 20 }, new int?[] { 10, 5, 15, 6, 20 }];

        yield return [new int?[] { 3, 9, 20, null, null, 15, 7 }, new int?[] { 3, 9, 20, 15, 7 }];

        yield return [new int?[] { -100, 100, -100 }, new int?[] { -100, 100, -100 }];

        yield return [new int?[] { 1, 2, 3, null, 4, 5 }, new int?[] { 1, 2, 4, 3, 5 }];

        yield return [new int?[] { 1, null, 2, 3, 4 }, new int?[] { 1, 2, 3, 4 }];
    }
}