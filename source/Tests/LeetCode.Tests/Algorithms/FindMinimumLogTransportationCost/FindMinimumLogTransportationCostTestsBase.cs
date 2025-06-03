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

using LeetCode.Algorithms.FindMinimumLogTransportationCost;

namespace LeetCode.Tests.Algorithms.FindMinimumLogTransportationCost;

public abstract class FindMinimumLogTransportationCostTestsBase<T> where T : IFindMinimumLogTransportationCost, new()
{
    [TestMethod]
    [DataRow(6, 5, 5, 5)]
    [DataRow(4, 4, 6, 0)]
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