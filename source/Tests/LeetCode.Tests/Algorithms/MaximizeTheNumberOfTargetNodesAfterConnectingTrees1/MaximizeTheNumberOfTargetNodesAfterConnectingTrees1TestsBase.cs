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

using LeetCode.Algorithms.MaximizeTheNumberOfTargetNodesAfterConnectingTrees1;

namespace LeetCode.Tests.Algorithms.MaximizeTheNumberOfTargetNodesAfterConnectingTrees1;

public abstract class MaximizeTheNumberOfTargetNodesAfterConnectingTrees1TestsBase<T> where T : IMaximizeTheNumberOfTargetNodesAfterConnectingTrees1, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxTargetNodes_WithTwoTreesAndDistanceLimit_ReturnsMaxTargetsPerNode(int[][] edges1, int[][] edges2, int k, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxTargetNodes(edges1, edges2, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 2, 3 }, new[] { 2, 4 } }, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 2, 7 }, new[] { 1, 4 }, new[] { 4, 5 }, new[] { 4, 6 } }, 2, new[] { 9, 7, 9, 8, 8 }];

        yield return [new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 0, 4 } }, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 } }, 1, new[] { 6, 3, 3, 3, 3 }];
    }
}