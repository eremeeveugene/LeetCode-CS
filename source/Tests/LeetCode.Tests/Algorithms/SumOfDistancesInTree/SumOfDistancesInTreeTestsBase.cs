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

using LeetCode.Algorithms.SumOfDistancesInTree;

namespace LeetCode.Tests.Algorithms.SumOfDistancesInTree;

public abstract class SumOfDistancesInTreeTestsBase<T> where T : ISumOfDistancesInTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SumOfDistancesInTree_GivenNumberOfNodesAndEdges_ReturnsDistanceSumsArray(int n, int[][] edges,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumOfDistancesInTree(n, edges);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
            [6, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 2, 5 } }, new[] { 8, 12, 6, 10, 10, 10 }];

        yield return [1, Array.Empty<int[]>(), new[] { 0 }];

        yield return [2, new[] { new[] { 1, 0 } }, new[] { 1, 1 }];
    }
}