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
    public void FindCheapestPrice_GivenNumberOfCitiesAndFlightDetails_ReturnsMinimumCostWithinStops(
        int n,
        int[][] flights,
        int src,
        int dst,
        int k,
        int expectedResult)
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
        yield return
        [
            4, new[] { new[] { 0, 1, 100 }, new[] { 1, 2, 100 }, new[] { 2, 0, 100 }, new[] { 1, 3, 600 }, new[] { 2, 3, 200 } }, 0, 3, 1, 700
        ];

        yield return [3, new[] { new[] { 0, 1, 100 }, new[] { 1, 2, 100 }, new[] { 0, 2, 500 } }, 0, 2, 1, 200];

        yield return [3, new[] { new[] { 0, 1, 100 }, new[] { 1, 2, 100 }, new[] { 0, 2, 500 } }, 0, 2, 0, 500];

        yield return [3, new[] { new[] { 0, 1, 2 }, new[] { 1, 2, 1 }, new[] { 2, 0, 10 } }, 1, 2, 1, 1];

        yield return [3, new[] { new[] { 0, 1, 100 } }, 0, 2, 1, -1];

        yield return [2, new[] { new[] { 0, 1, 50 } }, 0, 1, 0, 50];

        yield return [2, new[] { new[] { 0, 1, 50 } }, 1, 0, 0, -1];

        yield return [2, new[] { new[] { 0, 1, 1 } }, 0, 1, 5, 1];

        yield return [3, new[] { new[] { 0, 1, 100 }, new[] { 1, 2, 100 }, new[] { 0, 2, 500 } }, 0, 2, 2, 200];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 } }, 0, 3, 2, 3];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 } }, 0, 3, 1, -1];

        yield return [5, new[] { new[] { 0, 1, 10 }, new[] { 1, 4, 10 }, new[] { 0, 2, 3 }, new[] { 2, 3, 4 }, new[] { 3, 4, 5 } }, 0, 4, 3, 12];

        yield return [5, new[] { new[] { 0, 1, 10 }, new[] { 1, 4, 10 }, new[] { 0, 2, 3 }, new[] { 2, 3, 4 }, new[] { 3, 4, 5 } }, 0, 4, 1, 20];

        yield return [3, new[] { new[] { 0, 1, 5 }, new[] { 1, 2, 5 } }, 0, 2, 0, -1];

        yield return [3, new[] { new[] { 0, 1, 5 }, new[] { 1, 2, 5 } }, 0, 2, 1, 10];

        yield return [2, new[] { new[] { 0, 1, 100 }, new[] { 0, 1, 50 } }, 0, 1, 0, 50];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 0, 2, 5 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 } }, 0, 3, 2, 3];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 0, 2, 5 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 } }, 0, 3, 1, 6];

        yield return [3, new[] { new[] { 0, 1, 100 }, new[] { 1, 2, 100 } }, 2, 0, 5, -1];

        yield return [4, new[] { new[] { 0, 1, 10 }, new[] { 1, 2, 10 }, new[] { 2, 3, 10 }, new[] { 0, 3, 40 } }, 0, 3, 0, 40];

        yield return [4, new[] { new[] { 0, 1, 10 }, new[] { 1, 2, 10 }, new[] { 2, 3, 10 }, new[] { 0, 3, 40 } }, 0, 3, 3, 30];

        yield return [5, new[] { new[] { 0, 1, 5 }, new[] { 1, 2, 5 }, new[] { 2, 3, 5 }, new[] { 3, 4, 5 } }, 0, 4, 10, 20];
    }
}