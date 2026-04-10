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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RangeProductQueriesOfPowers;

public abstract class RangeProductQueriesOfPowersTestsBase<T> where T : IRangeProductQueriesOfPowers, new()
{
    [TestMethod]
    [DataRow(2, "[[0,0]]", "[2]")]
    [DataRow(15, "[[0,1],[2,2],[0,3]]", "[2,4,64]")]
    public void ProductQueries_WithPowersOfTwoDecompositionAndRangeQueries_ReturnsModuloProductArray(int n,
        string queriesJson, string expectedResultJson)
    {
        // Arrange
        var queries = JsonHelper.Parse<int[][]>(queriesJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.ProductQueries(n, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}