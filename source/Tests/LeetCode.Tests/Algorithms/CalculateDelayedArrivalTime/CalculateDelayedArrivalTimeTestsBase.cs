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

using LeetCode.Algorithms.CalculateDelayedArrivalTime;

namespace LeetCode.Tests.Algorithms.CalculateDelayedArrivalTime;

public abstract class CalculateDelayedArrivalTimeTestsBase<T> where T : ICalculateDelayedArrivalTime, new()
{
    [TestMethod]
    [DataRow(15, 5, 20)]
    [DataRow(13, 11, 0)]
    [DataRow(1, 1, 2)]
    [DataRow(23, 1, 0)]
    [DataRow(23, 24, 23)]
    [DataRow(1, 24, 1)]
    [DataRow(12, 12, 0)]
    [DataRow(12, 11, 23)]
    [DataRow(10, 14, 0)]
    [DataRow(5, 19, 0)]
    [DataRow(5, 18, 23)]
    [DataRow(20, 5, 1)]
    [DataRow(22, 3, 1)]
    [DataRow(23, 23, 22)]
    [DataRow(18, 6, 0)]
    [DataRow(8, 8, 16)]
    [DataRow(19, 10, 5)]
    [DataRow(7, 24, 7)]
    [DataRow(14, 10, 0)]
    [DataRow(14, 9, 23)]
    public void FindDelayedArrivalTime_WithArrivalAndDelay_ReturnsTimeAdjustedFor24HourClock(int arrivalTime, int delayedTime, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDelayedArrivalTime(arrivalTime, delayedTime);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}