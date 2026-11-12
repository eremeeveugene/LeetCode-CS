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

using LeetCode.Algorithms.MinimumCostToAcquireRequiredItems;

namespace LeetCode.Tests.Algorithms.MinimumCostToAcquireRequiredItems;

public abstract class MinimumCostToAcquireRequiredItemsTestsBase<T> where T : IMinimumCostToAcquireRequiredItems, new()
{
    [TestMethod]
    [DataRow(3, 2, 1, 3, 2, 3L)]
    [DataRow(5, 4, 15, 2, 3, 22L)]
    [DataRow(5, 4, 15, 0, 0, 0L)]
    [DataRow(1, 1, 1, 0, 0, 0L)]
    [DataRow(1, 1, 1, 1, 0, 1L)]
    [DataRow(1, 1, 1, 0, 1, 1L)]
    [DataRow(1, 1, 1, 1, 1, 1L)]
    [DataRow(1, 1, 3, 5, 5, 10L)]
    [DataRow(1, 1, 2, 5, 5, 10L)]
    [DataRow(2, 3, 4, 10, 1, 22L)]
    [DataRow(2, 3, 4, 1, 10, 31L)]
    [DataRow(10, 10, 1, 7, 3, 7L)]
    [DataRow(10, 1, 5, 4, 9, 25L)]
    [DataRow(1, 10, 5, 9, 4, 25L)]
    [DataRow(7, 8, 10, 6, 6, 60L)]
    [DataRow(7, 8, 20, 6, 6, 90L)]
    [DataRow(3, 3, 5, 1000, 0, 3000L)]
    [DataRow(3, 3, 2, 0, 1000, 2000L)]
    [DataRow(4, 6, 7, 123, 456, 2859L)]
    [DataRow(1000000, 1000000, 1000000, 1000000000, 1000000000, 1000000000000000L)]
    [DataRow(1, 1, 1000000, 1000000000, 1000000000, 2000000000L)]
    [DataRow(1000000, 1000000, 1, 1000000000, 0, 1000000000L)]
    [DataRow(1000000, 999999, 1999998, 1000000000, 999999999, 1999997999000002L)]
    [DataRow(5, 9, 12, 250, 250, 3000L)]
    [DataRow(9, 5, 6, 13, 42, 223L)]
    public void MinimumCost_WithCostsAndNeeds_ReturnsMinimumTotalCost(int cost1, int cost2, int costBoth, int need1, int need2, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumCost(cost1, cost2, costBoth, need1, need2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}