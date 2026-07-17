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

using LeetCode.Algorithms.NumberOfElapsedSecondsBetweenTwoTimes;

namespace LeetCode.Tests.Algorithms.NumberOfElapsedSecondsBetweenTwoTimes;

public abstract class NumberOfElapsedSecondsBetweenTwoTimesTestsBase<T> where T : INumberOfElapsedSecondsBetweenTwoTimes, new()
{
    [TestMethod]
    [DataRow("01:00:00", "01:00:25", 25)]
    [DataRow("12:34:56", "13:00:00", 1504)]
    [DataRow("00:00:00", "00:00:00", 0)]
    [DataRow("00:00:00", "23:59:59", 86399)]
    [DataRow("23:59:59", "23:59:59", 0)]
    [DataRow("00:00:01", "00:00:02", 1)]
    [DataRow("00:59:59", "01:00:00", 1)]
    [DataRow("11:59:59", "12:00:00", 1)]
    [DataRow("00:00:00", "01:00:00", 3600)]
    [DataRow("00:00:00", "00:01:00", 60)]
    [DataRow("10:30:00", "10:30:30", 30)]
    [DataRow("05:15:20", "06:20:25", 3905)]
    [DataRow("09:00:00", "17:00:00", 28800)]
    [DataRow("06:06:06", "06:06:06", 0)]
    [DataRow("13:45:30", "14:45:30", 3600)]
    [DataRow("22:00:00", "23:59:59", 7199)]
    [DataRow("00:00:59", "00:01:01", 2)]
    [DataRow("18:30:45", "20:15:10", 6265)]
    [DataRow("03:04:05", "04:05:06", 3661)]
    [DataRow("07:07:07", "07:08:08", 61)]
    [DataRow("20:20:20", "20:21:19", 59)]
    [DataRow("16:00:00", "16:59:00", 3540)]
    public void SecondsBetweenTimes_WithStartAndEndTimes_ReturnsElapsedSeconds(string startTime, string endTime, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SecondsBetweenTimes(startTime, endTime);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}