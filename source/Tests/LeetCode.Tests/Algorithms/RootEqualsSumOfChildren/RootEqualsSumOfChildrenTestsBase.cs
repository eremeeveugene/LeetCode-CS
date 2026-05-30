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

using LeetCode.Algorithms.RootEqualsSumOfChildren;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.RootEqualsSumOfChildren;

public abstract class RootEqualsSumOfChildrenTestsBase<T> where T : IRootEqualsSumOfChildren, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CheckTree_WithThreeNodeTree_ReturnsIfRootValueEqualsSumOfChildren(int?[] rootArray,
        bool expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.CheckTree(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 10, 4, 6 }, true];

        yield return [new int?[] { 5, 3, 1 }, false];
    }
}