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

using LeetCode.Algorithms.InvertBinaryTree;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.InvertBinaryTree;

public abstract class InvertBinaryTreeTestsBase<T> where T : IInvertBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void InvertTree_GivenBinaryTree_ReturnsInvertedTree(int?[] rootArray, int?[] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.InvertTree(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int?>()];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 1, 2 }, new int?[] { 1, null, 2 }];

        yield return [new int?[] { 1, null, 2 }, new int?[] { 1, 2 }];

        yield return [new int?[] { 4, 2, 7, 1, 3, 6, 9 }, new int?[] { 4, 7, 2, 9, 6, 3, 1 }];

        yield return [new int?[] { 4, 2, 7, 1, 3, null, 9 }, new int?[] { 4, 7, 2, 9, null, 3, 1 }];

        yield return [new int?[] { 4, 2, 7, 1, 3, 6 }, new int?[] { 4, 7, 2, null, 6, 3, 1 }];

        yield return [new int?[] { 2, 1, 3 }, new int?[] { 2, 3, 1 }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new int?[] { 1, 3, 2, 7, 6, 5, 4 }];

        yield return [new int?[] { 1, null, 2, null, 3 }, new int?[] { 1, 2, null, 3 }];

        yield return [new int?[] { 5, 3, 7, 2, 4, 6, 8 }, new int?[] { 5, 7, 3, 8, 6, 4, 2 }];

        yield return [new int?[] { 1, 2, null, 3, null }, new int?[] { 1, null, 2, null, 3 }];

        yield return [new int?[] { 3, 1, 2 }, new int?[] { 3, 2, 1 }];

        yield return [new int?[] { 10, 5, 15, 3, 7, null, 18 }, new int?[] { 10, 15, 5, 18, null, 7, 3 }];

        yield return [new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 }, new int?[] { 6, 8, 2, 9, 7, 4, 0, null, null, 5, 3 }];

        yield return [new int?[] { 1, 2, 3, null, null, null, 4 }, new int?[] { 1, 3, 2, 4 }];

        yield return [new int?[] { 100 }, new int?[] { 100 }];

        yield return [new int?[] { 0, 0, 0 }, new int?[] { 0, 0, 0 }];

        yield return [new int?[] { -1, -2, -3 }, new int?[] { -1, -3, -2 }];
    }
}