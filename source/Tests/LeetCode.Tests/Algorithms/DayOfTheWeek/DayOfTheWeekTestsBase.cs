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
    [DataRow(1, 1, 1971, "Friday")]
    [DataRow(31, 12, 2100, "Friday")]
    [DataRow(29, 2, 2016, "Monday")]
    [DataRow(28, 2, 2100, "Sunday")]
    [DataRow(1, 3, 2100, "Monday")]
    [DataRow(31, 1, 1990, "Wednesday")]
    [DataRow(15, 6, 2005, "Wednesday")]
    [DataRow(4, 7, 1976, "Sunday")]
    [DataRow(31, 10, 2023, "Tuesday")]
    [DataRow(1, 1, 2024, "Monday")]
    [DataRow(29, 2, 2096, "Wednesday")]
    public void DayOfTheWeek_WithDateInputs_ReturnsDayNameForGivenDate(int day, int month, int year, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DayOfTheWeek(day, month, year);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}