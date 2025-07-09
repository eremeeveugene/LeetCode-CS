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

using LeetCode.Algorithms.RescheduleMeetingsForMaximumFreeTime1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RescheduleMeetingsForMaximumFreeTime1;

public abstract class RescheduleMeetingsForMaximumFreeTime1TestsBase<T>
    where T : IRescheduleMeetingsForMaximumFreeTime1, new()
{
    [TestMethod]
    [DataRow(5, 1, "[1,3]", "[2,5]", 2)]
    [DataRow(10, 1, "[0,2,9]", "[1,4,10]", 6)]
    [DataRow(5, 2, "[0,1,2,3,4]", "[1,2,3,4,5]", 0)]
    public void MaxFreeTime_WithVariousMeetingSchedulesAndRescheduleLimit_ReturnsMaximumContinuousFreeTime(
        int eventTime, int k, string startTimeJson, string endTimeJson, int expectedResult)
    {
        // Arrange
        var startTime = JsonHelper<int[]>.Parse(startTimeJson);
        var endTime = JsonHelper<int[]>.Parse(endTimeJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxFreeTime(eventTime, k, startTime, endTime);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}