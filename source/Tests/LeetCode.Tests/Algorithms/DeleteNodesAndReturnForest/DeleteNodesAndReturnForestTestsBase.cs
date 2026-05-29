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

using LeetCode.Algorithms.DeleteNodesAndReturnForest;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DeleteNodesAndReturnForest;

public abstract class DeleteNodesAndReturnForestTestsBase<T> where T : IDeleteNodesAndReturnForest, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void DelNodes_WithGivenNodesToDelete_ModifiesTreeCorrectly(int?[] rootArray, int[] toDelete,
        int?[][] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);
        var expectedResult = expectedResultArray.Select(TreeNode.ToTreeNode);

        var solution = new T();

        // Act
        var actualResult = solution.DelNodes(root, toDelete);

        // Assert
        TreeNodeAssert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), new[] { 1 }, Array.Empty<int?[]>()];

        yield return [new int?[] { 1 }, new[] { 1 }, Array.Empty<int?[]>()];

        yield return [new int?[] { 1, 2, 4, null, 3 }, new[] { 3 }, new[] { new int?[] { 1, 2, 4 } }];

        yield return [new int?[] { 1, 2, 3, 4, 5 }, new[] { 1 }, new[] { new int?[] { 2, 4, 5 }, new int?[] { 3 } }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 3, 5 }, new[] { new int?[] { 6 }, new int?[] { 7 }, new int?[] { 1, 2, null, 4 } }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7 }, Array.Empty<int?[]>()];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, new[] { 3, 5, 7, 8, 9, 14 }, new[] { new int?[] { 6, 12, 13 }, new int?[] { 15 }, new int?[] { 10 }, new int?[] { 11 }, new int?[] { 1, 2, null, 4 } }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, null, null, 9, 10, 11, null, 12 }, new[] { 2, 6, 8, 9, 11 }, new[] { new int?[] { 4 }, new int?[] { 5 }, new int?[] { 10 }, new int?[] { 1, null, 3, null, 7, null, 12 } }];
    }
}