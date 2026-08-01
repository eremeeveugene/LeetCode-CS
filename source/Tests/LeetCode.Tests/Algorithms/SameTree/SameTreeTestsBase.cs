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

using LeetCode.Algorithms.SameTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SameTree;

public abstract class SameTreeTestsBase<T> where T : ISameTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void IsSameTree_WithTwoBinaryTrees_ReturnsTrueIfIdenticalOtherwiseFalse(int?[] pArray, int?[] qArray, bool expectedResult)
    {
        // Arrange
        var p = TreeNode.ToTreeNode(pArray);
        var q = TreeNode.ToTreeNode(qArray);

        var solution = new T();

        // Act
        var actualResult = solution.IsSameTree(p, q);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, 2, 3 }, new int?[] { 1, 2, 3 }, true];

        yield return [new int?[] { 1, 2 }, new int?[] { 1, null, 2 }, false];

        yield return [new int?[] { 1, 2, 1 }, new int?[] { 1, 1, 2 }, false];

        yield return [new int?[] { 1 }, new int?[] { 1, 2 }, false];

        yield return [new int?[] { 1 }, new int?[] { 1 }, true];

        yield return [new int?[] { 1 }, new int?[] { 2 }, false];

        yield return [Array.Empty<int?>(), Array.Empty<int?>(), true];

        yield return [Array.Empty<int?>(), new int?[] { 1 }, false];

        yield return [new int?[] { 1, 2, 3 }, new int?[] { 1, 2, 4 }, false];

        yield return [new int?[] { 1, 2, 3 }, new int?[] { 4, 2, 3 }, false];

        yield return [new int?[] { 5, 4, 8, 11, null, 13, 4 }, new int?[] { 5, 4, 8, 11, null, 13, 4 }, true];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new int?[] { 1, 2, 3, 4, 5, 6, 7 }, true];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new int?[] { 1, 2, 3, 4, 5, 6, 8 }, false];

        yield return [new int?[] { 1, 2 }, new int?[] { 1, 2 }, true];

        yield return [new int?[] { 1, null, 2 }, new int?[] { 1, null, 2 }, true];

        yield return [new int?[] { 1, 2, null }, new int?[] { 1, null, 2 }, false];

        yield return [new int?[] { 2, 3, null, 4, 5 }, new int?[] { 2, 3, null, 4, 5 }, true];

        yield return [new int?[] { 3, 4, 5, 1, 2 }, new int?[] { 3, 4, 5, 1, 2 }, true];

        yield return [new int?[] { 10, 5, 15 }, new int?[] { 10, 5, 15, null, null, 6 }, false];

        yield return [new int?[] { 10, 5, 15, null, null, 6 }, new int?[] { 10, 5, 15 }, false];

        yield return [new int?[] { 0 }, new int?[] { 0 }, true];

        yield return [new int?[] { -1, -2, -3 }, new int?[] { -1, -2, -3 }, true];

        yield return [new int?[] { -1, -2, -3 }, new int?[] { -1, -3, -2 }, false];

        yield return [new int?[] { 1, 2, 3, 4 }, new int?[] { 1, 2, 3, null, 4 }, false];
    }
}