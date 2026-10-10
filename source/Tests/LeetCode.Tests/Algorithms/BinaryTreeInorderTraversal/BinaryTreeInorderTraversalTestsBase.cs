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

using LeetCode.Algorithms.BinaryTreeInorderTraversal;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BinaryTreeInorderTraversal;

public abstract class BinaryTreeInorderTraversalTestsBase<T> where T : IBinaryTreeInorderTraversal, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void InorderTraversal_WithBinaryTreeFromJson_ReturnsInorderTraversalList(int?[] inputArray, int?[] expectedResult)
    {
        // Arrange
        var inputNode = TreeNode.ToTreeNode(inputArray);

        var solution = new T();

        // Act
        var actualResult = solution.InorderTraversal(inputNode);

        // Assert
        Assert.IsNotNull(actualResult);
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, null, 2, 3 }, new int?[] { 1, 3, 2 }];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [Array.Empty<int?>(), new int?[] { 0 }];

        yield return [new int?[] { 1, 2 }, new int?[] { 2, 1 }];

        yield return [new int?[] { 1, null, 2 }, new int?[] { 1, 2 }];

        yield return [new int?[] { 1, 2, 3 }, new int?[] { 2, 1, 3 }];

        yield return [new int?[] { 2, 1, 3 }, new int?[] { 1, 2, 3 }];

        yield return [new int?[] { 3, 2, null, 1 }, new int?[] { 1, 2, 3 }];

        yield return [new int?[] { 1, null, 2, null, 3 }, new int?[] { 1, 2, 3 }];

        yield return [new int?[] { 4, 2, 6, 1, 3, 5, 7 }, new int?[] { 1, 2, 3, 4, 5, 6, 7 }];

        yield return [new int?[] { 5, 3, 8, 2, 4, 7, 9 }, new int?[] { 2, 3, 4, 5, 7, 8, 9 }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new int?[] { 4, 2, 5, 1, 6, 3, 7 }];

        yield return [new int?[] { 0 }, new int?[] { 0 }];

        yield return [new int?[] { -1 }, new int?[] { -1 }];

        yield return [new int?[] { 1, 2, null, 3 }, new int?[] { 3, 2, 1 }];

        yield return [new int?[] { 1, null, 2, 3, 4 }, new int?[] { 1, 3, 2, 4 }];

        yield return [new int?[] { 10, 5, 15, null, 6, 12 }, new int?[] { 5, 6, 10, 12, 15 }];

        yield return [new int?[] { 1, 2, 3, null, 4, 5 }, new int?[] { 2, 4, 1, 5, 3 }];

        yield return [new int?[] { 100, -100 }, new int?[] { -100, 100 }];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4 }, new int?[] { 1, 2, 3, 4 }];

        yield return [new int?[] { 8, 4, 12, 2, 6, 10, 14, 1 }, new int?[] { 1, 2, 4, 6, 8, 10, 12, 14 }];
    }
}