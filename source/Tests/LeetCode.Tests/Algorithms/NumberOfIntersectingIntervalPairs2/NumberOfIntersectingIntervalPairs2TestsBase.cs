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

using LeetCode.Algorithms.NumberOfIntersectingIntervalPairs2;

namespace LeetCode.Tests.Algorithms.NumberOfIntersectingIntervalPairs2;

public abstract class NumberOfIntersectingIntervalPairs2TestsBase<T> where T : INumberOfIntersectingIntervalPairs2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CountIntersectingIntervals_GivenIntervals_ReturnsNumberOfPairsSharingAtLeastOnePoint(int[][] intervals, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountIntersectingIntervals(intervals);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }, 2L];

        yield return [new[] { new[] { 1, 5 }, new[] { 2, 4 }, new[] { 3, 6 } }, 3L];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } }, 0L];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 1L];

        yield return [new[] { new[] { 0, 1000000000 }, new[] { 1000000000, 1000000000 } }, 1L];

        yield return [new[] { new[] { 0, 0 }, new[] { 1, 1 } }, 0L];

        yield return [new[] { new[] { 0, 1000000000 }, new[] { 0, 1000000000 }, new[] { 0, 1000000000 } }, 3L];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 } }, 6L];

        yield return [new[] { new[] { 0, 1 }, new[] { 2, 3 } }, 0L];

        yield return [new[] { new[] { 0, 2 }, new[] { 2, 4 }, new[] { 4, 6 } }, 2L];

        yield return [new[] { new[] { 0, 10 }, new[] { 2, 3 }, new[] { 5, 6 }, new[] { 8, 9 } }, 3L];

        yield return [new[] { new[] { 5, 6 }, new[] { 1, 2 }, new[] { 3, 4 } }, 0L];

        yield return [new[] { new[] { 1, 3 }, new[] { 2, 4 } }, 1L];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }, 3L];

        yield return [new[] { new[] { 1, 10 }, new[] { 2, 9 }, new[] { 3, 8 }, new[] { 4, 7 } }, 6L];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 4, 5 } }, 4L];

        yield return [new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }, 4L];

        yield return [new[] { new[] { 10, 20 }, new[] { 1, 5 }, new[] { 15, 25 }, new[] { 3, 12 } }, 3L];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 1 } }, 2L];

        yield return [new[] { new[] { 1, 3 }, new[] { 1, 5 }, new[] { 2, 4 }, new[] { 2, 2 }, new[] { 2, 6 }, new[] { 4, 7 } }, 13L];

        yield return [new[] { new[] { 0, 5 }, new[] { 6, 10 }, new[] { 11, 15 }, new[] { 16, 20 } }, 0L];

        yield return [new[] { new[] { 3, 5 }, new[] { 1, 3 }, new[] { 5, 7 } }, 2L];

        yield return [new[] { new[] { 0, 4 }, new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 } }, 3L];

        yield return [new[] { new[] { 1, 4 }, new[] { 4, 4 }, new[] { 4, 9 }, new[] { 9, 9 } }, 4L];

        yield return [new[] { new[] { 999999999, 1000000000 }, new[] { 0, 1 }, new[] { 1, 999999999 } }, 2L];

        yield return [CreateRepeatedIntervals(100000, 0, 1000000000), 4999950000L];
    }

    private static int[][] CreateRepeatedIntervals(int count, int start, int end)
    {
        var intervals = new int[count][];

        for (var i = 0; i < count; i++)
        {
            intervals[i] = [start, end];
        }

        return intervals;
    }
}