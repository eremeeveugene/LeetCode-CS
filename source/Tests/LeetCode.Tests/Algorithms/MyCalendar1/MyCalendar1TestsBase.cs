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
    public void Book_WithStartAndEndTimes_ReturnsBookingResults(int[] start, int[] end,
        bool[] expectedResult)
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
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}