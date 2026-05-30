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

using LeetCode.Algorithms.XORQueriesOfSubarray;

namespace LeetCode.Tests.Algorithms.XORQueriesOfSubarray;

public abstract class XORQueriesOfSubarrayTestsBase<T> where T : IXORQueriesOfSubarray, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void XorQueries_WithArrayAndRangeQueries_ReturnsXorOfElementsForEachQuery(int[] arr, int[][] queries, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.XorQueries(arr, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 3, 4, 8 }, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 3 }, new[] { 3, 3 } }, new[] { 2, 7, 14, 8 }];

        yield return [new[] { 4, 8, 2, 10 }, new[] { new[] { 2, 3 }, new[] { 1, 3 }, new[] { 0, 0 }, new[] { 0, 3 } }, new[] { 8, 0, 4, 4 }];

        yield return [new[] { 16 }, new[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 } }, new[] { 16, 16, 16 }];

        yield return [new[] { 15, 8, 8, 8, 15 }, new[] { new[] { 2, 2 }, new[] { 3, 3 } }, new[] { 8, 8 }];
    }
}