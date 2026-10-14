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

using LeetCode.Algorithms.RescheduleMeetingsForMaximumFreeTime1;

namespace LeetCode.Tests.Algorithms.RescheduleMeetingsForMaximumFreeTime1;

public abstract class RescheduleMeetingsForMaximumFreeTime1TestsBase<T> where T : IRescheduleMeetingsForMaximumFreeTime1, new()
{
    [TestMethod]
    [DataRow(5, 1, new[] { 1, 3 }, new[] { 2, 5 }, 2)]
    [DataRow(10, 1, new[] { 0, 2, 9 }, new[] { 1, 4, 10 }, 6)]
    [DataRow(5, 2, new[] { 0, 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5 }, 0)]
    [DataRow(1, 1, new[] { 0 }, new[] { 1 }, 0)]
    [DataRow(2, 1, new[] { 0 }, new[] { 1 }, 1)]
    [DataRow(10, 1, new[] { 3 }, new[] { 5 }, 8)]
    [DataRow(10, 1, new[] { 0 }, new[] { 10 }, 0)]
    [DataRow(10, 2, new[] { 1, 4 }, new[] { 3, 6 }, 6)]
    [DataRow(21, 1, new[] { 7, 14 }, new[] { 10, 18 }, 11)]
    [DataRow(34, 2, new[] { 0, 10, 20 }, new[] { 5, 15, 25 }, 19)]
    [DataRow(1000000000, 1, new[] { 0, 500000000 }, new[] { 500000000, 1000000000 }, 0)]
    [DataRow(1000000000, 2, new[] { 1, 999999999 }, new[] { 2, 1000000000 }, 999999998)]
    [DataRow(10, 3, new[] { 0, 3, 6, 9 }, new[] { 2, 5, 8, 10 }, 3)]
    [DataRow(100, 1, new[] { 10, 20, 30, 40, 50 }, new[] { 20, 30, 40, 50, 60 }, 40)]
    [DataRow(50, 1, new[] { 0, 11, 23, 30 }, new[] { 1, 22, 25, 38 }, 17)]
    [DataRow(50, 3, new[] { 0, 16, 25, 32, 34, 38 }, new[] { 2, 22, 28, 33, 36, 39 }, 22)]
    [DataRow(100, 2, new[] { 2, 14, 37, 45, 56, 70, 76, 93 }, new[] { 5, 33, 41, 49, 58, 74, 79, 100 }, 28)]
    [DataRow(1000, 4, new[] { 48, 134, 176, 290, 421, 487, 538, 628, 723, 845 }, new[] { 85, 149, 200, 398, 445, 519, 550, 674, 830, 965 }, 252)]
    [DataRow(1000000000, 2, new[] { 26289562, 235435237, 289832129, 598695033, 737916289 }, new[] { 193137944, 249800047, 361595008, 683266415, 846589855 }, 445160044)]
    [DataRow(30, 5, new[] { 1, 7, 16, 20, 24 }, new[] { 2, 10, 19, 23, 25 }, 19)]
    public void MaxFreeTime_WithVariousMeetingSchedulesAndRescheduleLimit_ReturnsMaximumContinuousFreeTime(
        int eventTime,
        int k,
        int[] startTime,
        int[] endTime,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxFreeTime(eventTime, k, startTime, endTime);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}