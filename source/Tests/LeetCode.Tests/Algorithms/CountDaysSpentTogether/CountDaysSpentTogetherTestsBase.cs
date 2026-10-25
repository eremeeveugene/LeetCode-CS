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

using LeetCode.Algorithms.CountDaysSpentTogether;

namespace LeetCode.Tests.Algorithms.CountDaysSpentTogether;

public abstract class CountDaysSpentTogetherTestsBase<T> where T : ICountDaysSpentTogether, new()
{
    [TestMethod]
    [DataRow("08-15", "08-18", "08-16", "08-19", 3)]
    [DataRow("10-01", "10-31", "11-01", "12-31", 0)]
    [DataRow("01-01", "12-31", "01-01", "12-31", 365)]
    [DataRow("01-01", "01-01", "01-01", "01-01", 1)]
    [DataRow("12-31", "12-31", "12-31", "12-31", 1)]
    [DataRow("01-01", "01-01", "01-02", "01-02", 0)]
    [DataRow("01-01", "01-31", "01-31", "02-28", 1)]
    [DataRow("02-28", "03-01", "02-01", "03-31", 2)]
    [DataRow("01-01", "12-31", "06-15", "06-20", 6)]
    [DataRow("06-15", "06-20", "01-01", "12-31", 6)]
    [DataRow("03-01", "03-10", "03-05", "03-15", 6)]
    [DataRow("03-05", "03-15", "03-01", "03-10", 6)]
    [DataRow("01-15", "03-15", "02-01", "04-30", 43)]
    [DataRow("01-01", "06-30", "07-01", "12-31", 0)]
    [DataRow("01-01", "07-01", "07-01", "12-31", 1)]
    [DataRow("04-30", "05-01", "05-01", "05-02", 1)]
    [DataRow("09-10", "10-05", "09-01", "09-30", 21)]
    [DataRow("11-11", "11-11", "11-01", "11-30", 1)]
    [DataRow("02-01", "02-28", "02-01", "02-28", 28)]
    [DataRow("07-01", "08-31", "07-15", "09-15", 48)]
    [DataRow("12-01", "12-31", "01-01", "11-30", 0)]
    [DataRow("05-20", "05-25", "05-26", "05-30", 0)]
    public void CountDaysTogether_WithAliceAndBobDates_ReturnsDaysTogether(
        string arriveAlice,
        string leaveAlice,
        string arriveBob,
        string leaveBob,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountDaysTogether(arriveAlice, leaveAlice, arriveBob, leaveBob);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}