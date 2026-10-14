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

using LeetCode.Algorithms.MaximumContainersOnShip;

namespace LeetCode.Tests.Algorithms.MaximumContainersOnShip;

public abstract class MaximumContainersOnShipTestsBase<T> where T : IMaximumContainersOnShip, new()
{
    [TestMethod]
    [DataRow(2, 3, 15, 4)]
    [DataRow(3, 5, 20, 4)]
    [DataRow(1, 1, 1, 1)]
    [DataRow(1, 1, 5, 1)]
    [DataRow(1, 5, 1, 0)]
    [DataRow(2, 3, 1, 0)]
    [DataRow(10, 2, 100, 50)]
    [DataRow(10, 2, 10, 5)]
    [DataRow(3, 4, 35, 8)]
    [DataRow(4, 7, 100, 14)]
    [DataRow(1000, 1000, 1000000000, 1000000)]
    [DataRow(1000, 1, 1000000000, 1000000)]
    [DataRow(1000, 1000, 1, 0)]
    [DataRow(1000, 1000, 999999, 999)]
    [DataRow(5, 5, 25, 5)]
    [DataRow(5, 5, 24, 4)]
    [DataRow(7, 3, 200, 49)]
    [DataRow(6, 10, 359, 35)]
    [DataRow(100, 10, 1000, 100)]
    [DataRow(8, 9, 600, 64)]
    public void MaxContainers_WithNumberOfContainersWeightAndMaxCapacity_ReturnsMaxStackableCount(int n, int w, int maxWeight, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxContainers(n, w, maxWeight);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}