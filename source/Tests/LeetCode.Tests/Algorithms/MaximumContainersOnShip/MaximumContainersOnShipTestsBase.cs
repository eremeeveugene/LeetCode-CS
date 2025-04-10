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

using LeetCode.Algorithms.MaximumContainersOnShip;

namespace LeetCode.Tests.Algorithms.MaximumContainersOnShip;

public abstract class MaximumContainersOnShipTestsBase<T>
    where T : IMaximumContainersOnShip, new()
{
    [TestMethod]
    [DataRow(2, 3, 15, 4)]
    [DataRow(3, 5, 20, 4)]
    public void MaxContainers_WithNumberOfContainersWeightAndMaxCapacity_ReturnsMaxStackableCount(int n, int w,
        int maxWeight, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxContainers(n, w, maxWeight);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}