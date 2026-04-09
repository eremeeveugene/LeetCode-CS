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

using LeetCode.Algorithms.FindTheNumberOfDistinctColorsAmongTheBalls;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindTheNumberOfDistinctColorsAmongTheBalls;

public abstract class FindTheNumberOfDistinctColorsAmongTheBallsTestsBase<T>
    where T : IFindTheNumberOfDistinctColorsAmongTheBalls, new()
{
    [TestMethod]
    [DataRow(4, "[[1,4],[2,5],[1,3],[3,4]]", "[1,2,2,3]")]
    [DataRow(4, "[[0,1],[1,2],[2,2],[3,4],[4,5]]", "[1,2,2,3,4]")]
    public void QueryResults_WithLimitAndQueries_ReturnsQueryResults(int limit, string queriesJson,
        string expectedResultJson)
    {
        // Arrange
        var queries = JsonHelper.Parse<int[][]>(queriesJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.QueryResults(limit, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}