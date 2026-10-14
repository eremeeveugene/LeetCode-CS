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

using LeetCode.Algorithms.MaximumNumberOfEventsThatCanBeAttended;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfEventsThatCanBeAttended;

public abstract class MaximumNumberOfEventsThatCanBeAttendedTestsBase<T> where T : IMaximumNumberOfEventsThatCanBeAttended, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxEvents_WithMultipleIntervals_ReturnsMaximumAttendableEvents(int[][] events, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxEvents(events);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }, 3];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 1, 2 } }, 4];

        yield return [new[] { new[] { 1, 1 } }, 1];

        yield return [new[] { new[] { 1, 5 } }, 1];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, 1];

        yield return [new[] { new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 6 }, new[] { 1, 2 } }, 3];

        yield return [new[] { new[] { 1, 4 }, new[] { 4, 4 }, new[] { 2, 2 }, new[] { 3, 4 }, new[] { 1, 1 } }, 4];

        yield return [new[] { new[] { 1, 3 }, new[] { 1, 3 }, new[] { 1, 3 } }, 3];

        yield return [new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 } }, 3];

        yield return [new[] { new[] { 1, 10 }, new[] { 2, 2 }, new[] { 3, 3 } }, 3];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 2];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 2 }, new[] { 2, 2 } }, 2];

        yield return [new[] { new[] { 1, 5 }, new[] { 1, 5 }, new[] { 1, 5 }, new[] { 2, 3 }, new[] { 2, 3 } }, 5];

        yield return [new[] { new[] { 5, 5 }, new[] { 5, 7 }, new[] { 5, 7 } }, 3];

        yield return [new[] { new[] { 1, 3 }, new[] { 2, 4 }, new[] { 3, 5 } }, 3];

        yield return [new[] { new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 } }, 2];

        yield return [new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 }, new[] { 4, 4 }, new[] { 5, 5 } }, 5];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 2 } }, 2];

        yield return [new[] { new[] { 2, 4 }, new[] { 4, 4 }, new[] { 2, 2 }, new[] { 1, 2 }, new[] { 2, 3 } }, 4];

        yield return [new[] { new[] { 4, 6 }, new[] { 1, 4 }, new[] { 4, 5 }, new[] { 4, 5 }, new[] { 5, 5 }, new[] { 4, 4 }, new[] { 4, 4 }, new[] { 1, 6 } }, 5];

        yield return [new[] { new[] { 5, 9 }, new[] { 7, 10 }, new[] { 7, 7 }, new[] { 5, 5 }, new[] { 2, 8 }, new[] { 10, 10 }, new[] { 2, 2 }, new[] { 6, 7 }, new[] { 2, 9 }, new[] { 9, 9 } }, 9];

        yield return [new[] { new[] { 5, 5 }, new[] { 5, 5 }, new[] { 5, 5 }, new[] { 4, 4 }, new[] { 2, 5 }, new[] { 5, 5 }, new[] { 3, 5 }, new[] { 3, 4 }, new[] { 2, 3 }, new[] { 5, 5 }, new[] { 5, 5 }, new[] { 3, 5 } }, 4];

        yield return [new[] { new[] { 14, 15 }, new[] { 9, 13 }, new[] { 4, 8 }, new[] { 3, 8 }, new[] { 9, 11 }, new[] { 9, 14 }, new[] { 2, 14 }, new[] { 15, 15 }, new[] { 6, 9 }, new[] { 15, 15 }, new[] { 5, 10 }, new[] { 4, 8 }, new[] { 1, 7 }, new[] { 5, 11 }, new[] { 5, 11 }, new[] { 3, 13 }, new[] { 7, 8 }, new[] { 3, 13 }, new[] { 14, 14 }, new[] { 4, 6 } }, 15];

        yield return [new[] { new[] { 1, 100000 } }, 1];

        yield return [new[] { new[] { 100000, 100000 }, new[] { 100000, 100000 } }, 1];

        yield return [new[] { new[] { 1, 3 }, new[] { 2, 2 }, new[] { 2, 3 }, new[] { 3, 3 } }, 3];

        yield return [new[] { new[] { 5, 5 }, new[] { 1, 5 }, new[] { 1, 5 }, new[] { 1, 5 }, new[] { 1, 5 }, new[] { 1, 5 } }, 5];

        yield return [CreateIdenticalEvents(100000, 1, 100000), 100000];

        yield return [CreateSingleDayEvents(100000), 100000];
    }

    private static int[][] CreateIdenticalEvents(int count, int startDay, int endDay)
    {
        var events = new int[count][];

        for (var i = 0; i < count; i++)
        {
            events[i] = [startDay, endDay];
        }

        return events;
    }

    private static int[][] CreateSingleDayEvents(int count)
    {
        var events = new int[count][];

        for (var i = 0; i < count; i++)
        {
            events[i] = [i + 1, i + 1];
        }

        return events;
    }
}