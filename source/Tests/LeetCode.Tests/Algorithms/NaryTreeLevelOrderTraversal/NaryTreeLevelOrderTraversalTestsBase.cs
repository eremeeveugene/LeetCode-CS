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

using LeetCode.Algorithms.NaryTreeLevelOrderTraversal;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.NaryTreeLevelOrderTraversal;

public abstract class NaryTreeLevelOrderTraversalTestsBase<T> where T : INaryTreeLevelOrderTraversal, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void LevelOrder_WithNaryTree_ReturnsNodeValuesByLevel(int?[] rootArray, int[][] expectedResult)
    {
        // Arrange
        var root = Node.ToNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.LevelOrder(root);

        // Assert
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int[]>()];

        yield return [new int?[] { 1, null, 3, 2, 4, null, 5, 6 }, new[] { new[] { 1 }, new[] { 3, 2, 4 }, new[] { 5, 6 } }];

        yield return
        [
            new int?[] { 1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null, null, 14 },
            new[] { new[] { 1 }, new[] { 2, 3, 4, 5 }, new[] { 6, 7, 8, 9, 10 }, new[] { 11, 12, 13 }, new[] { 14 } }
        ];
    }
}