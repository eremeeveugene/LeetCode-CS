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

using LeetCode.Algorithms.FindBottomLeftTreeValue;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FindBottomLeftTreeValue;

public abstract class FindBottomLeftTreeValueTestsBase<T> where T : IFindBottomLeftTreeValue, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindBottomLeftValue_GivenBinaryTreeJson_ReturnsBottomLeftValue(int?[] arrayRoot, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(arrayRoot);

        var solution = new T();

        // Act
        var actualResult = solution.FindBottomLeftValue(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), 0];

        yield return [new int?[] { 2, 1, 3 }, 1];

        yield return [new int?[] { 1, 2, 3, 4, null, 5, 6, null, null, 7 }, 7];

        yield return [new int?[] { 1, null, 1 }, 1];

        yield return [new int?[] { 1, 2, 3, 4, null, 5, 6, null, null, 7, null, 8, 9, null, null, null, null, null, 10 }, 10];
    }
}