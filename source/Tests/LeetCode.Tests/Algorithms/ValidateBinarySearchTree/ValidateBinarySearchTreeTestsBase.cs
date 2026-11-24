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

using LeetCode.Algorithms.ValidateBinarySearchTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.ValidateBinarySearchTree;

public abstract class ValidateBinarySearchTreeTestsBase<T> where T : IValidateBinarySearchTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void IsValidBST_WithBinaryTree_ReturnsTrueIfTreeIsValidBinarySearchTree(int?[] rootArray, bool expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.IsValidBST(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 2, 1, 3 }, true];

        yield return [new int?[] { 5, 1, 4, null, null, 3, 6 }, false];

        yield return [new int?[] { 1 }, true];

        yield return [new int?[] { 0 }, true];

        yield return [new int?[] { 2147483647 }, true];

        yield return [new int?[] { -2147483648 }, true];

        yield return [new int?[] { -2147483648, null, 2147483647 }, true];

        yield return [new int?[] { 2147483647, -2147483648 }, true];

        yield return [new int?[] { 2147483647, 2147483647 }, false];

        yield return [new int?[] { -2147483648, -2147483648 }, false];

        yield return [new int?[] { -2147483648, null, -2147483648 }, false];

        yield return [new int?[] { 2, 2, 2 }, false];

        yield return [new int?[] { 1, 1 }, false];

        yield return [new int?[] { 1, null, 1 }, false];

        yield return [new int?[] { 2, 1 }, true];

        yield return [new int?[] { 1, null, 2 }, true];

        yield return [new int?[] { 2, 3 }, false];

        yield return [new int?[] { 2, null, 1 }, false];

        yield return [new int?[] { 5, 4, 6, null, null, 3, 7 }, false];

        yield return [new int?[] { 10, 5, 15, null, null, 6, 20 }, false];

        yield return [new int?[] { 3, 1, 5, 0, 2, 4, 6 }, true];

        yield return [new int?[] { 3, 1, 5, 0, 4 }, false];

        yield return [new int?[] { 8, 4, 12, 2, 6, 10, 14, 1, 3, 5, 7, 9, 11, 13, 15 }, true];

        yield return [new int?[] { 8, 4, 12, 2, 6, 10, 14, 1, 3, 5, 9, 7, 11, 13, 15 }, false];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4, null, 5 }, true];

        yield return [new int?[] { 5, 4, null, 3, null, 2, null, 1 }, true];

        yield return [new int?[] { 1, null, 2, null, 3, null, 2 }, false];

        yield return [new int?[] { 5, 4, null, 3, null, 2, null, 6 }, false];

        yield return [new int?[] { 32, 26, 47, 19, null, null, 56, null, 27 }, false];

        yield return [new int?[] { 3, null, 30, 10, null, null, 15, null, 45 }, false];

        yield return [new int?[] { 0, -1 }, true];

        yield return [new int?[] { -5, -10, 0, -15, -7, -3, 5 }, true];

        yield return [new int?[] { -5, -10, 0, -15, -4, -3, 5 }, false];

        yield return [new int?[] { 50, 30, 70, 20, 40, 60, 80, null, 25, 35, 45, 55, 65, 75, 85 }, true];

        yield return [new int?[] { 50, 30, 70, 20, 40, 60, 80, null, 25, 35, 45, 50, 65, 75, 85 }, false];
    }
}