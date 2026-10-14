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

using LeetCode.Algorithms.DayOfTheYear;

namespace LeetCode.Tests.Algorithms.DayOfTheYear;

public abstract class DayOfTheYearTestsBase<T> where T : IDayOfTheYear, new()
{
    [TestMethod]
    [DataRow("1992-09-14", 258)]
    [DataRow("2019-01-09", 9)]
    [DataRow("2019-02-10", 41)]
    [DataRow("1900-01-01", 1)]
    [DataRow("1900-12-31", 365)]
    [DataRow("1900-03-01", 60)]
    [DataRow("2000-12-31", 366)]
    [DataRow("2000-02-29", 60)]
    [DataRow("2000-03-01", 61)]
    [DataRow("2016-02-29", 60)]
    [DataRow("2016-12-31", 366)]
    [DataRow("2019-12-31", 365)]
    [DataRow("2019-03-01", 60)]
    [DataRow("2019-02-28", 59)]
    [DataRow("2004-03-01", 61)]
    [DataRow("1999-07-04", 185)]
    [DataRow("1987-11-30", 334)]
    [DataRow("1960-02-28", 59)]
    [DataRow("2018-10-10", 283)]
    [DataRow("1950-05-05", 125)]
    [DataRow("2012-08-31", 244)]
    public void DayOfYear_WithValidDateString_ReturnsTheDayNumberOfTheYear(string date, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DayOfYear(date);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}