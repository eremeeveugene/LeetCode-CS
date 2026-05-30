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

using LeetCode.Algorithms.SumOfLeftLeaves;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SumOfLeftLeaves;

public abstract class SumOfLeftLeavesTestsBase<T> where T : ISumOfLeftLeaves, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SumOfLeftLeaves_GivenTreeRoot_ReturnsSumOfLeftLeafValues(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.SumOfLeftLeaves(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1 }, 0];

        yield return [new int?[] { 3, 9, 20, null, null, 15, 7 }, 24];

        yield return [new int?[] { 0, 2, 4, 1, null, 3, -1, 5, 1, null, 6, null, 8 }, 5];

        yield return [new int?[] { 1, 2, 3, 4, 5 }, 4];

        yield return [new int?[] { -9, -3, 2, null, 4, 4, 0, -6, null, -5 }, -11];
    }
}