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

using LeetCode.Algorithms.RangeSumOfBST;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.RangeSumOfBST;

public abstract class RangeSumOfBSTTestsBase<T> where T : IRangeSumOfBST, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void RangeSumBST_WithTreeAndInclusiveBounds_ReturnsSumOfValuesInRange(int?[] rootArray, int low, int high, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.RangeSumBST(root, low, high);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 10, 5, 15, 3, 7, null, 18 }, 7, 15, 32];

        yield return [new int?[] { 10, 5, 15, 3, 7, 13, 18, 1, null, 6 }, 6, 10, 23];

        yield return [new int?[] { 5 }, 5, 5, 5];

        yield return [new int?[] { 5 }, 1, 10, 5];

        yield return [new int?[] { 5 }, 6, 10, 0];

        yield return [new int?[] { 10, 5, 15 }, 1, 100, 30];

        yield return [new int?[] { 10, 5, 15 }, 11, 14, 0];

        yield return [new int?[] { 10, 5, 15 }, 10, 10, 10];

        yield return [new int?[] { 10, 5, 15 }, 5, 5, 5];

        yield return [new int?[] { 10, 5, 15 }, 15, 15, 15];

        yield return [new int?[] { 20, 10, 30, 5, 15, 25, 35 }, 10, 30, 100];

        yield return [new int?[] { 20, 10, 30, 5, 15, 25, 35 }, 1, 4, 0];

        yield return [new int?[] { 20, 10, 30, 5, 15, 25, 35 }, 36, 100, 0];

        yield return [new int?[] { 1, null, 2 }, 1, 2, 3];

        yield return [new int?[] { 3, 1, 5, null, 2, 4 }, 2, 4, 9];

        yield return [new int?[] { 7, 3, 10, 1, 5, 8, 12 }, 4, 9, 20];

        yield return [new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 }, 3, 7, 25];

        yield return [new int?[] { 50, 25, 75 }, 25, 75, 150];

        yield return [new int?[] { null }, 1, 10, 0];

        yield return [Array.Empty<int?>(), 1, 10, 0];
    }
}