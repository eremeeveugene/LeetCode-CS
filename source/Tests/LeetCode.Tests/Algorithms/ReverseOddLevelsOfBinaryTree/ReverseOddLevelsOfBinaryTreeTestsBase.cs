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

using LeetCode.Algorithms.ReverseOddLevelsOfBinaryTree;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ReverseOddLevelsOfBinaryTree;

public abstract class ReverseOddLevelsOfBinaryTreeTestsBase<T> where T : IReverseOddLevelsOfBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ReverseOddLevels_GivenTree_ReturnsTreeWithOddLevelsReversed(int?[] rootArray,
        int?[] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.ReverseOddLevels(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int?>()];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 7, 13, 11 }, new int?[] { 7, 11, 13 }];

        yield return [new int?[] { 2, 3, 5, 8, 13, 21, 34 }, new int?[] { 2, 5, 3, 8, 13, 21, 34 }];

        yield return
        [
            new int?[] { 0, 1, 2, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2 },
            new int?[] { 0, 2, 1, 0, 0, 0, 0, 2, 2, 2, 2, 1, 1, 1, 1 }
        ];

        yield return [new int?[] { 1, null, 2 }, new int?[] { 1, null, 2 }];

        yield return
        [
            new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },
            new int?[] { 1, 3, 2, 4, 5, 6, 7, 15, 14, 13, 12, 11, 10, 9, 8 }
        ];

        yield return
            [new int?[] { 1, 2, null, 3, null, 4, null, 5 }, new int?[] { 1, 2, null, 3, null, 4, null, 5 }];

        yield return
        [
            new int?[] { 1, null, 2, null, 3, null, 4, null, 5 },
            new int?[] { 1, null, 2, null, 3, null, 4, null, 5 }
        ];

        yield return
        [
            new int?[] { 1, 2, 3, 4, null, null, 5, 6, null, null, 7 },
            new int?[] { 1, 3, 2, 4, null, null, 5, 7, null, null, 6 }
        ];
    }
}