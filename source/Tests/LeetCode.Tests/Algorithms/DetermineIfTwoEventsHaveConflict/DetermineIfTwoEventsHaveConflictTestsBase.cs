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

using LeetCode.Algorithms.DetermineIfTwoEventsHaveConflict;

namespace LeetCode.Tests.Algorithms.DetermineIfTwoEventsHaveConflict;

public abstract class DetermineIfTwoEventsHaveConflictTestsBase<T> where T : IDetermineIfTwoEventsHaveConflict, new()
{
    [TestMethod]
    [DataRow(new[] { "01:15", "02:00" }, new[] { "02:00", "03:00" }, true)]
    [DataRow(new[] { "01:00", "02:00" }, new[] { "01:20", "03:00" }, true)]
    [DataRow(new[] { "10:00", "11:00" }, new[] { "14:00", "15:00" }, false)]
    [DataRow(new[] { "14:00", "15:00" }, new[] { "10:00", "11:00" }, false)]
    [DataRow(new[] { "00:00", "23:59" }, new[] { "12:00", "12:30" }, true)]
    [DataRow(new[] { "12:00", "12:30" }, new[] { "00:00", "23:59" }, true)]
    [DataRow(new[] { "09:00", "10:00" }, new[] { "10:00", "11:00" }, true)]
    [DataRow(new[] { "10:00", "11:00" }, new[] { "09:00", "10:00" }, true)]
    [DataRow(new[] { "08:00", "09:00" }, new[] { "09:01", "10:00" }, false)]
    [DataRow(new[] { "09:01", "10:00" }, new[] { "08:00", "09:00" }, false)]
    [DataRow(new[] { "00:00", "00:00" }, new[] { "00:00", "00:00" }, true)]
    [DataRow(new[] { "23:59", "23:59" }, new[] { "23:59", "23:59" }, true)]
    [DataRow(new[] { "05:30", "07:45" }, new[] { "06:00", "07:00" }, true)]
    [DataRow(new[] { "13:15", "14:45" }, new[] { "14:44", "16:00" }, true)]
    [DataRow(new[] { "13:15", "14:45" }, new[] { "14:46", "16:00" }, false)]
    [DataRow(new[] { "00:00", "01:00" }, new[] { "23:00", "23:59" }, false)]
    [DataRow(new[] { "23:00", "23:59" }, new[] { "00:00", "01:00" }, false)]
    [DataRow(new[] { "06:00", "06:00" }, new[] { "05:00", "07:00" }, true)]
    [DataRow(new[] { "05:00", "07:00" }, new[] { "06:00", "06:00" }, true)]
    [DataRow(new[] { "12:00", "13:00" }, new[] { "12:00", "13:00" }, true)]
    [DataRow(new[] { "00:01", "00:02" }, new[] { "00:03", "00:04" }, false)]
    public void HaveConflict_GivenTwoEventTimeRanges_ReturnsIfConflictExists(string[] event1, string[] event2, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HaveConflict(event1, event2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}