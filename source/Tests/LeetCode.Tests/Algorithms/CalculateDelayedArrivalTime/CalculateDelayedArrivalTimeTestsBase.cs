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

using LeetCode.Algorithms.CalculateDelayedArrivalTime;

namespace LeetCode.Tests.Algorithms.CalculateDelayedArrivalTime;

public abstract class CalculateDelayedArrivalTimeTestsBase<T> where T : ICalculateDelayedArrivalTime, new()
{
    [TestMethod]
    [DataRow(15, 5, 20)]
    [DataRow(13, 11, 0)]
    public void FindDelayedArrivalTime_WithArrivalAndDelayedTime_ReturnsExpectedArrivalTime(int arrivalTime,
        int delayedTime, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDelayedArrivalTime(arrivalTime, delayedTime);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}