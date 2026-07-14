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

using LeetCode.Algorithms.ShortestDistanceAfterRoadAdditionQueries1;

namespace LeetCode.Tests.Algorithms.ShortestDistanceAfterRoadAdditionQueries1;

public abstract class ShortestDistanceAfterRoadAdditionQueries1TestsBase<T> where T : IShortestDistanceAfterRoadAdditionQueries1, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ShortestDistanceAfterQueries_WithNumberOfNodesAndQueryRanges_ReturnsShortestDistances(int n, int[][] queries, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ShortestDistanceAfterQueries(n, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [5, new[] { new[] { 2, 4 }, new[] { 0, 2 }, new[] { 0, 4 } }, new[] { 3, 2, 1 }];

        yield return [4, new[] { new[] { 0, 3 }, new[] { 0, 2 } }, new[] { 1, 1 }];
    }
}