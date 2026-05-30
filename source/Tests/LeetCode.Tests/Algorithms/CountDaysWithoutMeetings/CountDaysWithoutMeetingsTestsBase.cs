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

namespace LeetCode.Tests.Algorithms.CountDaysWithoutMeetings;

public abstract class CountDaysWithoutMeetingsTestsBase<T> where T : ICountDaysWithoutMeetings, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CountDays_WithTotalDaysAndMeetingRanges_ReturnsNumberOfFreeDays(int days, int[][] meetings, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountDays(days, meetings);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [10, new[] { new[] { 5, 7 }, new[] { 1, 3 }, new[] { 9, 10 } }, 2];

        yield return [5, new[] { new[] { 2, 4 }, new[] { 1, 3 } }, 1];

        yield return [6, new[] { new[] { 1, 6 } }, 0];
    }
}