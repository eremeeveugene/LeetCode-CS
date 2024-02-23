// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CheapestFlightsWithinKStops;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CheapestFlightsWithinKStops;

public abstract class CheapestFlightsWithinKStopsTestsBase<T> where T : ICheapestFlightsWithinKStops, new()
{
    [TestMethod]
    [DataRow(4, "[[0,1,100],[1,2,100],[2,0,100],[1,3,600],[2,3,200]]", 0, 3, 1, 700)]
    [DataRow(3, "[[0,1,100],[1,2,100],[0,2,500]]", 0, 2, 1, 200)]
    [DataRow(3, "[[0,1,100],[1,2,100],[0,2,500]]", 0, 2, 0, 500)]
    [DataRow(3, "[[0,1,2],[1,2,1],[2,0,10]]", 1, 2, 1, 1)]
    public void FindCheapestPrice_GivenNumberOfCitiesAndFlightDetails_ReturnsMinimumCostWithinStops(int n,
        string jsonFlights, int src, int dst, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        var flights = JsonConvertHelper<int>.JsonArrayToJaggedArray(jsonFlights);

        // Act
        var actualResult = solution.FindCheapestPrice(n, flights, src, dst, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}