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

public abstract class RescheduleMeetingsForMaximumFreeTime1TestsBase<T>
    where T : IRescheduleMeetingsForMaximumFreeTime1, new()
{
    [TestMethod]
    [DataRow(5, 1, new[] { 1, 3 }, new[] { 2, 5 }, 2)]
    [DataRow(10, 1, new[] { 0, 2, 9 }, new[] { 1, 4, 10 }, 6)]
    [DataRow(5, 2, new[] { 0, 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5 }, 0)]
    public void MaxFreeTime_WithVariousMeetingSchedulesAndRescheduleLimit_ReturnsMaximumContinuousFreeTime(
        int eventTime, int k, int[] startTime, int[] endTime, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxFreeTime(eventTime, k, startTime, endTime);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}