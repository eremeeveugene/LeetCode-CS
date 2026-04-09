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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ShortestDistanceAfterRoadAdditionQueries1;

public abstract class ShortestDistanceAfterRoadAdditionQueries1TestsBase<T>
    where T : IShortestDistanceAfterRoadAdditionQueries1, new()
{
    [TestMethod]
    [DataRow(5, "[[2,4],[0,2],[0,4]]", "[3,2,1]")]
    [DataRow(4, "[[0,3],[0,2]]", "[1,1]")]
    public void ShortestDistanceAfterQueries_WithNumberOfNodesAndQueryRanges_ReturnsShortestDistances(int n,
        string queriesJson, string expectedResultJson)
    {
        // Arrange
        var queries = JsonHelper.Parse<int[][]>(queriesJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.ShortestDistanceAfterQueries(n, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}