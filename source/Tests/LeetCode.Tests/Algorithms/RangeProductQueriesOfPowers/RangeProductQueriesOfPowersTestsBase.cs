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

using LeetCode.Algorithms.RangeProductQueriesOfPowers;

namespace LeetCode.Tests.Algorithms.RangeProductQueriesOfPowers;

public abstract class RangeProductQueriesOfPowersTestsBase<T> where T : IRangeProductQueriesOfPowers, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ProductQueries_WithPowersOfTwoDecompositionAndRangeQueries_ReturnsModuloProductArray(int n, int[][] queries, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ProductQueries(n, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [2, new[] { new[] { 0, 0 } }, new[] { 2 }];

        yield return [15, new[] { new[] { 0, 1 }, new[] { 2, 2 }, new[] { 0, 3 } }, new[] { 2, 4, 64 }];
    }
}