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
    }
}