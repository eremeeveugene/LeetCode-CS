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

using LeetCode.Algorithms.CountDaysWithoutMeetings;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountDaysWithoutMeetings;

public abstract class CountDaysWithoutMeetingsTestsBase<T> where T : ICountDaysWithoutMeetings, new()
{
    [TestMethod]
    [DataRow(10, "[[5,7],[1,3],[9,10]]", 2)]
    [DataRow(5, "[[2,4],[1,3]]", 1)]
    [DataRow(6, "[[1,6]]", 0)]
    public void CountDays_WithTotalDaysAndMeetingRanges_ReturnsNumberOfFreeDays(int days, string meetingsJson,
        int expectedResult)
    {
        // Arrange
        var meetings = JsonHelper<int[][]>.Parse(meetingsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountDays(days, meetings);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}