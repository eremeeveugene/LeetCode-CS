// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
    public void MaximumBeauty_WithItemsAndQueries_CalculatesCorrectBeautyValues(string itemsJsonArray,
        string queriesJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var items = JsonHelper<int>.DeserializeToJaggedArray(itemsJsonArray);
        var queries = JsonHelper<int>.DeserializeToArray(queriesJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaximumBeauty(items, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}