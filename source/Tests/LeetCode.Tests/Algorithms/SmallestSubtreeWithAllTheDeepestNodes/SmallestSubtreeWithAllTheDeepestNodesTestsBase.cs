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

using LeetCode.Algorithms.SmallestSubtreeWithAllTheDeepestNodes;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.SmallestSubtreeWithAllTheDeepestNodes;

public abstract class SmallestSubtreeWithAllTheDeepestNodesTestsBase<T>
    where T : ISmallestSubtreeWithAllTheDeepestNodes, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SubtreeWithAllDeepest_WithBinaryTree_ReturnsSmallestSubtreeWithAllTheDeepestNodes(int?[] rootArray,
        int?[] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);
        var expectedResult = TreeNode.ToTreeNodeOrThrow(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.SubtreeWithAllDeepest(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 }, new int?[] { 2, 7, 4 }];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 0, 1, 3, null, 2 }, new int?[] { 2 }];
    }
}
