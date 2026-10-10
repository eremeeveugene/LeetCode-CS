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

using LeetCode.Algorithms.FindMinimumLogTransportationCost;

namespace LeetCode.Tests.Algorithms.FindMinimumLogTransportationCost;

public abstract class FindMinimumLogTransportationCostTestsBase<T> where T : IFindMinimumLogTransportationCost, new()
{
    [TestMethod]
    [DataRow(6, 5, 5, 5)]
    [DataRow(4, 4, 6, 0)]
    [DataRow(2, 2, 2, 0)]
    [DataRow(1, 1, 2, 0)]
    [DataRow(4, 4, 2, 8)]
    [DataRow(3, 3, 2, 4)]
    [DataRow(4, 1, 2, 4)]
    [DataRow(1, 4, 2, 4)]
    [DataRow(10, 10, 5, 50)]
    [DataRow(10, 3, 5, 25)]
    [DataRow(7, 9, 5, 30)]
    [DataRow(6, 6, 6, 0)]
    [DataRow(12, 12, 6, 72)]
    [DataRow(100, 100, 50, 5000)]
    [DataRow(99, 51, 50, 2500)]
    [DataRow(1, 200000, 100000, 10000000000L)]
    [DataRow(200000, 200000, 100000, 20000000000L)]
    [DataRow(150000, 120000, 100000, 7000000000L)]
    [DataRow(100000, 100000, 100000, 0)]
    [DataRow(5, 8, 4, 20)]
    public void MinCuttingCost_WithDimensionsAndCuts_ReturnsMinimumTotalCost(int n, int m, int k, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinCuttingCost(n, m, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}