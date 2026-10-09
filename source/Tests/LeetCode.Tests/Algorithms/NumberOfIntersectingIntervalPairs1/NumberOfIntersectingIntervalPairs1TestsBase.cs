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

using LeetCode.Algorithms.NumberOfIntersectingIntervalPairs1;

namespace LeetCode.Tests.Algorithms.NumberOfIntersectingIntervalPairs1;

public abstract class NumberOfIntersectingIntervalPairs1TestsBase<T> where T : INumberOfIntersectingIntervalPairs1, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CountIntersectingPairs_GivenIntervals_ReturnsNumberOfPairsSharingAtLeastOnePoint(int[][] intervals, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountIntersectingPairs(intervals);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }, 2];

        yield return [new[] { new[] { 1, 5 }, new[] { 2, 4 }, new[] { 3, 6 } }, 3];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } }, 0];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 1];

        yield return [new[] { new[] { 0, 100 }, new[] { 100, 100 } }, 1];

        yield return [new[] { new[] { 0, 0 }, new[] { 1, 1 } }, 0];

        yield return [new[] { new[] { 0, 100 }, new[] { 0, 100 }, new[] { 0, 100 } }, 3];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 } }, 6];

        yield return [new[] { new[] { 0, 1 }, new[] { 2, 3 } }, 0];

        yield return [new[] { new[] { 0, 2 }, new[] { 2, 4 }, new[] { 4, 6 } }, 2];

        yield return [new[] { new[] { 0, 10 }, new[] { 2, 3 }, new[] { 5, 6 }, new[] { 8, 9 } }, 3];

        yield return [new[] { new[] { 5, 6 }, new[] { 1, 2 }, new[] { 3, 4 } }, 0];

        yield return [new[] { new[] { 1, 3 }, new[] { 2, 4 } }, 1];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }, 3];

        yield return [new[] { new[] { 1, 10 }, new[] { 2, 9 }, new[] { 3, 8 }, new[] { 4, 7 } }, 6];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 4, 5 } }, 4];

        yield return [new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }, 4];

        yield return [new[] { new[] { 10, 20 }, new[] { 1, 5 }, new[] { 15, 25 }, new[] { 3, 12 } }, 3];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 1 } }, 2];

        yield return [new[] { new[] { 50, 50 }, new[] { 50, 50 } }, 1];

        yield return [new[] { new[] { 0, 5 }, new[] { 6, 10 }, new[] { 11, 15 }, new[] { 16, 20 } }, 0];

        yield return [new[] { new[] { 0, 100 }, new[] { 1, 99 }, new[] { 2, 98 } }, 3];

        yield return [new[] { new[] { 3, 5 }, new[] { 1, 3 }, new[] { 5, 7 } }, 2];

        yield return [new[] { new[] { 0, 4 }, new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 } }, 3];

        yield return [new[] { new[] { 1, 4 }, new[] { 4, 4 }, new[] { 4, 9 }, new[] { 9, 9 } }, 4];
    }
}