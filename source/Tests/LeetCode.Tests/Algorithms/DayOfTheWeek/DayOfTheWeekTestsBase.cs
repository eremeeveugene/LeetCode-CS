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

using LeetCode.Algorithms.DayOfTheWeek;

namespace LeetCode.Tests.Algorithms.DayOfTheWeek;

public abstract class DayOfTheWeekTestsBase<T> where T : IDayOfTheWeek, new()
{
    [TestMethod]
    [DataRow(31, 8, 2019, "Saturday")]
    [DataRow(18, 7, 1999, "Sunday")]
    [DataRow(15, 8, 1993, "Sunday")]
    [DataRow(1, 1, 2000, "Saturday")]
    [DataRow(29, 2, 2000, "Tuesday")]
    [DataRow(1, 3, 2000, "Wednesday")]
    [DataRow(31, 12, 1999, "Friday")]
    [DataRow(1, 1, 1900, "Monday")]
    [DataRow(28, 2, 1900, "Wednesday")]
    [DataRow(25, 12, 2021, "Saturday")]
    [DataRow(4, 7, 1776, "Thursday")]
    [DataRow(1, 1, 2100, "Friday")]
    public void DayOfTheWeek_GivenDate_ReturnsCorrectDay(int day, int month, int year, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DayOfTheWeek(day, month, year);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}