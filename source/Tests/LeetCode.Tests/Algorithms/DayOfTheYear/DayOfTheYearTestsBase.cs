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

using LeetCode.Algorithms.DayOfTheYear;

namespace LeetCode.Tests.Algorithms.DayOfTheYear;

public abstract class DayOfTheYearTestsBase<T> where T : IDayOfTheYear, new()
{
    [TestMethod]
    [DataRow("1992-09-14", 258)]
    [DataRow("2019-01-09", 9)]
    [DataRow("2019-02-10", 41)]
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