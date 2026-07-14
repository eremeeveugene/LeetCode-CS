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

using LeetCode.Algorithms.MyCalendar1;

namespace LeetCode.Tests.Algorithms.MyCalendar1;

public abstract class MyCalendar1TestsBase<T> where T : IMyCalendar1, new()
{
    [TestMethod]
    [DataRow(new[] { 10, 15, 20 }, new[] { 20, 25, 30 }, new[] { true, false, true })]
    [DataRow(new[] { 10 }, new[] { 20 }, new[] { true })]
    [DataRow(new[] { 10, 10 }, new[] { 20, 20 }, new[] { true, false })]
    [DataRow(new[] { 10, 20, 30 }, new[] { 20, 30, 40 }, new[] { true, true, true })]
    [DataRow(new[] { 10, 15 }, new[] { 20, 25 }, new[] { true, false })]
    [DataRow(new[] { 10, 12 }, new[] { 20, 15 }, new[] { true, false })]
    [DataRow(new[] { 0, 5, 10 }, new[] { 5, 10, 15 }, new[] { true, true, true })]
    [DataRow(new[] { 5, 0 }, new[] { 10, 6 }, new[] { true, false })]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { true, false, false, false })]
    [DataRow(new[] { 1, 5, 9, 13 }, new[] { 5, 9, 13, 17 }, new[] { true, true, true, true })]
    [DataRow(new[] { 1, 3, 5, 7 }, new[] { 3, 5, 7, 9 }, new[] { true, true, true, true })]
    [DataRow(new[] { 1, 2 }, new[] { 10, 3 }, new[] { true, false })]
    [DataRow(new[] { 47, 33, 39, 15 }, new[] { 50, 48, 44, 20 }, new[] { true, false, true, true })]
    [DataRow(new[] { 20, 50, 35, 5, 25 }, new[] { 30, 60, 45, 15, 55 }, new[] { true, true, true, true, false })]
    [DataRow(new[] { 100, 200, 300 }, new[] { 200, 300, 400 }, new[] { true, true, true })]
    [DataRow(new[] { 100, 150 }, new[] { 200, 160 }, new[] { true, false })]
    [DataRow(new[] { 0, 0 }, new[] { 1000000000, 1 }, new[] { true, false })]
    [DataRow(new[] { 5, 6 }, new[] { 7, 8 }, new[] { true, false })]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, new[] { 2, 2, 2, 2, 2 }, new[] { true, false, false, false, false })]
    public void Book_WithStartAndEndTimes_ReturnsBookingResults(int[] start, int[] end, bool[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = new bool[expectedResult.Length];

        for (var i = 0; i < expectedResult.Length; i++)
        {
            actualResult[i] = solution.Book(start[i], end[i]);
        }

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}