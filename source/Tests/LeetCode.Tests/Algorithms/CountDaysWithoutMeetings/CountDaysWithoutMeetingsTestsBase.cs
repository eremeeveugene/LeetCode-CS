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

        yield return [1, new[] { new[] { 1, 1 } }, 0];

        yield return [1, new[] { new[] { 1, 1 }, new[] { 1, 1 } }, 0];

        yield return [10, new[] { new[] { 1, 10 } }, 0];

        yield return [10, new[] { new[] { 2, 3 } }, 8];

        yield return [10, new[] { new[] { 1, 3 }, new[] { 8, 10 } }, 4];

        yield return [10, new[] { new[] { 4, 6 } }, 7];

        yield return [10, new[] { new[] { 1, 4 }, new[] { 5, 10 } }, 0];

        yield return [10, new[] { new[] { 1, 3 }, new[] { 3, 5 }, new[] { 5, 7 } }, 3];

        yield return [20, new[] { new[] { 2, 4 }, new[] { 6, 8 }, new[] { 10, 12 }, new[] { 14, 16 } }, 8];

        yield return [100, new[] { new[] { 1, 100 } }, 0];

        yield return [100, new[] { new[] { 50, 60 }, new[] { 55, 70 }, new[] { 1, 10 } }, 69];

        yield return [15, new[] { new[] { 1, 2 }, new[] { 4, 5 }, new[] { 7, 8 }, new[] { 10, 11 }, new[] { 13, 14 } }, 5];

        yield return [7, new[] { new[] { 7, 7 } }, 6];

        yield return [7, new[] { new[] { 1, 1 } }, 6];

        yield return [30, new[] { new[] { 5, 25 }, new[] { 10, 15 }, new[] { 26, 28 } }, 6];

        yield return [1000000000, new[] { new[] { 1, 1000000000 } }, 0];

        yield return [1000000000, new[] { new[] { 1, 5 }, new[] { 999999995, 1000000000 } }, 999999989];
    }
}