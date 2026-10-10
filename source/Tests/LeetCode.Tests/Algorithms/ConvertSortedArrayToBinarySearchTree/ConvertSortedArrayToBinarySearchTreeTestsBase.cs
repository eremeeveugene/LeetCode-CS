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

using LeetCode.Algorithms.ConvertSortedArrayToBinarySearchTree;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ConvertSortedArrayToBinarySearchTree;

public abstract class ConvertSortedArrayToBinarySearchTreeTestsBase<T> where T : IConvertSortedArrayToBinarySearchTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SortedArrayToBST_WithArrayInput_ReturnsBalancedBST(int[] nums, int?[] expectedResultArray)
    {
        // Arrange
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.SortedArrayToBST(nums);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { -10, -3, 0, 5, 9 }, new int?[] { 0, -10, 5, null, -3, null, 9 }];

        yield return [new[] { 1, 3 }, new int?[] { 1, null, 3 }];

        yield return [new[] { 1 }, new int?[] { 1 }];

        yield return [new[] { 1, 2 }, new int?[] { 1, null, 2 }];

        yield return [new[] { 1, 2, 3 }, new int?[] { 2, 1, 3 }];

        yield return [new[] { 1, 2, 3, 4 }, new int?[] { 2, 1, 3, null, null, null, 4 }];

        yield return [new[] { 1, 2, 3, 4, 5 }, new int?[] { 3, 1, 4, null, 2, null, 5 }];

        yield return [new[] { 1, 2, 3, 4, 5, 6 }, new int?[] { 3, 1, 5, null, 2, 4, 6 }];

        yield return [new[] { 1, 2, 3, 4, 5, 6, 7 }, new int?[] { 4, 2, 6, 1, 3, 5, 7 }];

        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int?[] { 4, 2, 6, 1, 3, 5, 7, null, null, null, null, null, null, null, 8 }];

        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int?[] { 5, 2, 7, 1, 3, 6, 8, null, null, null, 4, null, null, null, 9 }];

        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new int?[] { 5, 2, 8, 1, 3, 6, 9, null, null, null, 4, null, 7, null, 10 }];

        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, new int?[] { 6, 3, 9, 1, 4, 7, 10, null, 2, null, 5, null, 8, null, 11 }];

        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, new int?[] { 6, 3, 9, 1, 4, 7, 11, null, 2, null, 5, null, 8, 10, 12 }];

        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, new int?[] { 8, 4, 12, 2, 6, 10, 14, 1, 3, 5, 7, 9, 11, 13, 15 }];

        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, new int?[] { 8, 4, 12, 2, 6, 10, 14, 1, 3, 5, 7, 9, 11, 13, 15, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 16 }];

        yield return [new[] { -10000, 10000 }, new int?[] { -10000, null, 10000 }];

        yield return [new[] { -3, -2, -1 }, new int?[] { -2, -3, -1 }];

        yield return [new[] { -10000, -5000, 0, 5000, 10000 }, new int?[] { 0, -10000, 5000, null, -5000, null, 10000 }];

        yield return [new[] { -9, -7, -4, 0, 3, 8, 15, 22, 40, 41 }, new int?[] { 3, -7, 22, -9, -4, 8, 40, null, null, null, 0, null, 15, null, 41 }];
    }
}