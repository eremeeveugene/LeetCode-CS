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

using LeetCode.Algorithms.CheapestFlightsWithinKStops;

namespace LeetCode.Tests.Algorithms.CheapestFlightsWithinKStops;

public abstract class CheapestFlightsWithinKStopsTestsBase<T> where T : ICheapestFlightsWithinKStops, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindCheapestPrice_GivenNumberOfCitiesAndFlightDetails_ReturnsMinimumCostWithinStops(int n,
        int[][] flights, int src, int dst, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindCheapestPrice(n, flights, src, dst, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [4, new[] { new[] { 0, 1, 100 }, new[] { 1, 2, 100 }, new[] { 2, 0, 100 }, new[] { 1, 3, 600 }, new[] { 2, 3, 200 } }, 0, 3, 1, 700];

        yield return [3, new[] { new[] { 0, 1, 100 }, new[] { 1, 2, 100 }, new[] { 0, 2, 500 } }, 0, 2, 1, 200];

        yield return [3, new[] { new[] { 0, 1, 100 }, new[] { 1, 2, 100 }, new[] { 0, 2, 500 } }, 0, 2, 0, 500];

        yield return [3, new[] { new[] { 0, 1, 2 }, new[] { 1, 2, 1 }, new[] { 2, 0, 10 } }, 1, 2, 1, 1];
    }
}