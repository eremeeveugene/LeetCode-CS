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

using LeetCode.Algorithms.WaterBottles2;

namespace LeetCode.Tests.Algorithms.WaterBottles2;

public abstract class WaterBottles2TestsBase<T> where T : IWaterBottles2, new()
{
    [TestMethod]
    [DataRow(13, 6, 15)]
    [DataRow(10, 3, 13)]
    public void MaxBottlesDrunk_WithFullBottlesAndExchangeRate_ReturnsMaximumNumberOfBottlesDrunk(
        int numBottles, int numExchange, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxBottlesDrunk(numBottles, numExchange);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}