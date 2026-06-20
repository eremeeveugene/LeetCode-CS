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

using LeetCode.Algorithms.AngleBetweenHandsOfAClock;

namespace LeetCode.Tests.Algorithms.AngleBetweenHandsOfAClock;

public abstract class AngleBetweenHandsOfAClockTestsBase<T> where T : IAngleBetweenHandsOfAClock, new()
{
    [TestMethod]
    [DataRow(12, 30, 165.0)]
    [DataRow(3, 30, 75.0)]
    [DataRow(3, 15, 7.5)]
    [DataRow(4, 50, 155.0)]
    [DataRow(12, 0, 0.0)]
    [DataRow(6, 0, 180.0)]
    [DataRow(1, 0, 30.0)]
    [DataRow(12, 15, 82.5)]
    [DataRow(9, 0, 90.0)]
    [DataRow(3, 0, 90.0)]
    [DataRow(5, 30, 15.0)]
    [DataRow(2, 20, 50.0)]
    [DataRow(10, 10, 115.0)]
    [DataRow(11, 0, 30.0)]
    [DataRow(7, 30, 45.0)]
    [DataRow(1, 30, 135.0)]
    [DataRow(8, 0, 120.0)]
    [DataRow(2, 0, 60.0)]
    [DataRow(4, 0, 120.0)]
    [DataRow(12, 45, 112.5)]
    [DataRow(6, 30, 15.0)]
    [DataRow(9, 45, 22.5)]
    [DataRow(12, 59, 35.5)]
    [DataRow(1, 57, 76.5)]
    public void AngleClock_WithHourAndMinutes_ReturnsSmallerAngleBetweenHands(int hour, int minutes, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AngleClock(hour, minutes);

        // Assert
        Assert.AreEqual(expectedResult, Math.Round(actualResult, 5));
    }
}