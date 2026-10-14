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

        yield return [new int?[] { 16 }, 16];

        yield return [new int?[] { 38, 35 }, 35];

        yield return [new int?[] { 24, 39, null, null, 31 }, 31];

        yield return [new int?[] { 1, 31, 17, null, null, null, 36 }, 36];

        yield return [new int?[] { 35, 36, 31, null, 26, null, null, null, 41 }, 41];

        yield return [new int?[] { 25, 48, 43, 5, 1, null, null, null, null, null, 50 }, 50];

        yield return [new int?[] { 18, 28, 31, null, null, 25, 39, null, null, null, 47, 46 }, 46];

        yield return [new int?[] { 3, null, 9, 32, null, 44, 14, null, null, null, 17, null, 28, 50 }, 50];

        yield return [new int?[] { 38, 15, null, 43, 22, null, null, 44, null, null, 2, 18, 39, 45 }, 45];

        yield return [new int?[] { 41, 18, 37, null, 19, 5, 8, 6, 31, null, null, null, null, null, null, 41, 31 }, 41];

        yield return [new int?[] { 3, 39, 40, 3, 25, 49, 46, null, null, 22, null, 38, null, 18, null, null, null, 36 }, 36];

        yield return [new int?[] { 40, 45, 17, null, 3, null, 10, 22, 9, null, 21, null, 25, null, null, 24, 30, null, null, null, 25 }, 25];

        yield return [new int?[] { 34, 20, 36, 40, 41, 22, 27, null, null, null, null, 1, null, 38, 21, null, 2, null, null, null, 25, null, null, null, 38 }, 38];

        yield return [new int?[] { 44, 20, 2, 21, null, 38, 24, null, null, 49, null, 17, 41, null, null, null, 30, null, 39, null, 24, null, 12, null, null, null, 12, 21 }, 21];

        yield return [new int?[] { 16, 21, 7, 42, 12, 39, null, 21, 45, 28, 44, null, null, 6, null, null, null, null, 48, 7, null, null, null, null, 42, 22, 11, null, null, null, 44, null, null, 22, 15, null, null, 29 }, 29];
    }
}