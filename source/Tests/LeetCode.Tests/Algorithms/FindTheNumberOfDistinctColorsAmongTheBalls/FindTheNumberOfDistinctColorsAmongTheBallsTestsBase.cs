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

namespace LeetCode.Tests.Algorithms.FindTheNumberOfDistinctColorsAmongTheBalls;

public abstract class FindTheNumberOfDistinctColorsAmongTheBallsTestsBase<T> where T : IFindTheNumberOfDistinctColorsAmongTheBalls, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void QueryResults_WithLimitAndQueries_ReturnsQueryResults(int limit, int[][] queries, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.QueryResults(limit, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [4, new[] { new[] { 1, 4 }, new[] { 2, 5 }, new[] { 1, 3 }, new[] { 3, 4 } }, new[] { 1, 2, 2, 3 }];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 2 }, new[] { 3, 4 }, new[] { 4, 5 } }, new[] { 1, 2, 2, 3, 4 }];
    }
}