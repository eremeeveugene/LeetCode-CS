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

using LeetCode.Algorithms.WaterBottles;

namespace LeetCode.Tests.Algorithms.WaterBottles;

public abstract class WaterBottlesTestsBase<T> where T : IWaterBottles, new()
{
    [TestMethod]
    [DataRow(1, 2, 1)]
    [DataRow(2, 2, 3)]
    [DataRow(5, 10, 5)]
    [DataRow(8, 4, 10)]
    [DataRow(9, 3, 13)]
    [DataRow(15, 4, 19)]
    [DataRow(100, 99, 101)]
    [DataRow(100, 2, 199)]
    public void NumWaterBottles_WithBottlesAndExchangeRate_ReturnsNumOfWaterBottles(int numBottles, int numExchange,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumWaterBottles(numBottles, numExchange);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}