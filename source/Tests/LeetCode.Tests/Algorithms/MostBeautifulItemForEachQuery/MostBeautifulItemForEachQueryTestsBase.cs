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

using LeetCode.Algorithms.MostBeautifulItemForEachQuery;

namespace LeetCode.Tests.Algorithms.MostBeautifulItemForEachQuery;

public abstract class MostBeautifulItemForEachQueryTestsBase<T> where T : IMostBeautifulItemForEachQuery, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaximumBeauty_WithItemsAndQueries_CalculatesCorrectBeautyValues(int[][] items,
        int[] queries, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumBeauty(items, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 3, 2 }, new[] { 2, 4 }, new[] { 5, 6 }, new[] { 3, 5 } }, new[] { 1, 2, 3, 4, 5, 6 }, new[] { 2, 4, 5, 5, 6, 6 }];

        yield return [new[] { new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 1, 4 } }, new[] { 1 }, new[] { 4 }];

        yield return [new[] { new[] { 10, 1000 } }, new[] { 5 }, new[] { 0 }];
    }
}