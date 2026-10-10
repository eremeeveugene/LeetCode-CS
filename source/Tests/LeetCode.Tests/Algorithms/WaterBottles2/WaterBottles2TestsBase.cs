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

using LeetCode.Algorithms.WaterBottles2;

namespace LeetCode.Tests.Algorithms.WaterBottles2;

public abstract class WaterBottles2TestsBase<T> where T : IWaterBottles2, new()
{
    [TestMethod]
    [DataRow(13, 6, 15)]
    [DataRow(10, 3, 13)]
    [DataRow(1, 1, 2)]
    [DataRow(1, 2, 1)]
    [DataRow(2, 2, 3)]
    [DataRow(3, 3, 4)]
    [DataRow(5, 5, 6)]
    [DataRow(5, 2, 7)]
    [DataRow(10, 1, 14)]
    [DataRow(100, 1, 114)]
    [DataRow(100, 100, 101)]
    [DataRow(100, 2, 113)]
    [DataRow(100, 3, 112)]
    [DataRow(50, 10, 54)]
    [DataRow(7, 3, 9)]
    [DataRow(20, 4, 24)]
    [DataRow(60, 9, 65)]
    [DataRow(99, 99, 100)]
    [DataRow(99, 50, 100)]
    [DataRow(45, 6, 50)]
    public void MaxBottlesDrunk_WithFullBottlesAndExchangeRate_ReturnsMaximumNumberOfBottlesDrunk(int numBottles, int numExchange, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxBottlesDrunk(numBottles, numExchange);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}