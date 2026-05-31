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

using LeetCode.Algorithms.SymmetricTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SymmetricTree;

public abstract class SymmetricTreeTestsBase<T> where T : ISymmetricTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void IsSymmetric_WithBinaryTreeInput_ReturnsTrueIfTreeIsMirrorOfItself(int?[] rootArray, bool expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.IsSymmetric(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), true];

        yield return [new int?[] { 1, 2, 2, 3, 4, 4, 3 }, true];

        yield return [new int?[] { 1, 2, 2, null, 3, null, 3 }, false];

        yield return [new int?[] { 1 }, true];

        yield return [new int?[] { 1, 2, 2 }, true];

        yield return [new int?[] { 1, 2, 3 }, false];

        yield return [new int?[] { 1, 2, 2, 3, 4, 4, 3 }, true];

        yield return [new int?[] { 1, 2, 2, null, 3, 3, null }, true];

        yield return [new int?[] { 1, 2, 2, 2, null, 2, null }, false];

        yield return [new int?[] { 5, 4, 4, null, null, null, null }, true];

        yield return [new int?[] { 1, 0, 1, 0, null, null, 0 }, false];

        yield return [new int?[] { 1, 1, 1, 1, 1, 1, 1 }, true];

        yield return [new int?[] { 2, 3, 3, 4, 5, 5, 4, null, null, 8, 8, null, null, null, null }, true];

        yield return [new int?[] { 2, 3, 3, 4, 5, 5, 4, null, null, 8, 9, null, null, null, null }, false];

        yield return [new int?[] { 1, null, 2 }, false];

        yield return [new int?[] { 1, 2, null }, false];

        yield return [new int?[] { 3, 2, 2, null, 1, 1, null }, true];

        yield return [new int?[] { 0, -1, -1, null, null, null, null }, true];

        yield return [new int?[] { 0, -1, 1 }, false];
    }
}