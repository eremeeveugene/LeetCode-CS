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

using LeetCode.Algorithms.FindLargestValueInEachTreeRow;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FindLargestValueInEachTreeRow;

public abstract class FindLargestValueInEachTreeRowTestsBase<T> where T : IFindLargestValueInEachTreeRow, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void LargestValues_WithTreeRoot_ReturnsListOfRowMaxima(int?[] rootArray, int[] expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.LargestValues(root).ToArray();

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int>()];

        yield return [new int?[] { 1, 2, 3 }, new[] { 1, 3 }];

        yield return [new int?[] { 1, 3, 2, 5, 3, null, 9 }, new[] { 1, 3, 9 }];
    }
}