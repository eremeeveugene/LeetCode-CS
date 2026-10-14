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
    public void CheckTree_WithThreeNodeTree_ReturnsIfRootValueEqualsSumOfChildren(int?[] rootArray, bool expectedResult)
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

        yield return [new int?[] { 0, 0, 0 }, true];

        yield return [new int?[] { -5, -2, -3 }, true];

        yield return [new int?[] { 100, 50, 50 }, true];

        yield return [new int?[] { -100, -50, -50 }, true];

        yield return [new int?[] { 1, 0, 1 }, true];

        yield return [new int?[] { 1, 1, 0 }, true];

        yield return [new int?[] { 0, -1, 1 }, true];

        yield return [new int?[] { 0, 1, 1 }, false];

        yield return [new int?[] { 100, 100, 100 }, false];

        yield return [new int?[] { -100, -100, -100 }, false];

        yield return [new int?[] { 7, 3, 5 }, false];

        yield return [new int?[] { -7, -3, -4 }, true];

        yield return [new int?[] { 100, -100, 100 }, false];

        yield return [new int?[] { 0, 100, -100 }, true];

        yield return [new int?[] { 50, 25, 25 }, true];

        yield return [new int?[] { 2, 1, 0 }, false];

        yield return [new int?[] { -1, 0, -1 }, true];

        yield return [new int?[] { 99, 49, 50 }, true];
    }
}