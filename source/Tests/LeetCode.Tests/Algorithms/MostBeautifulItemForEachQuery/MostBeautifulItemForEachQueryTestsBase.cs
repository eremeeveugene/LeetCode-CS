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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MostBeautifulItemForEachQuery;

public abstract class MostBeautifulItemForEachQueryTestsBase<T> where T : IMostBeautifulItemForEachQuery, new()
{
    [TestMethod]
    [DataRow("[[1,2],[3,2],[2,4],[5,6],[3,5]]", "[1,2,3,4,5,6]", "[2,4,5,5,6,6]")]
    [DataRow("[[1,2],[1,2],[1,3],[1,4]]", "[1]", "[4]")]
    [DataRow("[[10,1000]]", "[5]", "[0]")]
    public void MaximumBeauty_WithItemsAndQueries_CalculatesCorrectBeautyValues(string itemsJson,
        string queriesJson, string expectedResultJson)
    {
        // Arrange
        var items = JsonHelper<int[][]>.Parse(itemsJson);
        var queries = JsonHelper<int[]>.Parse(queriesJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaximumBeauty(items, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}