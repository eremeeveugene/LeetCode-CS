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

using LeetCode.Algorithms.MinimumTotalDistanceTraveled;

namespace LeetCode.Tests.Algorithms.MinimumTotalDistanceTraveled;

public abstract class MinimumTotalDistanceTraveledTestsBase<T> where T : IMinimumTotalDistanceTraveled, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumTotalDistance_WithRobotsAndFactories_ReturnsMinimumTotalDistance(int[] robot, int[][] factory, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumTotalDistance(robot, factory);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 0, 4, 6 }, new[] { new[] { 2, 2 }, new[] { 6, 2 } }, 4L];

        yield return [new[] { 1, -1 }, new[] { new[] { -2, 1 }, new[] { 2, 1 } }, 2L];

        yield return [new[] { 5 }, new[] { new[] { 5, 1 } }, 0L];

        yield return [new[] { 0 }, new[] { new[] { 10, 1 } }, 10L];

        yield return [new[] { -1000000000 }, new[] { new[] { 1000000000, 1 } }, 2000000000L];

        yield return [new[] { 0 }, new[] { new[] { -3, 1 }, new[] { 2, 1 } }, 2L];

        yield return [new[] { 0, 1 }, new[] { new[] { 0, 1 }, new[] { 1, 1 } }, 0L];

        yield return [new[] { 0, 1 }, new[] { new[] { 5, 2 } }, 9L];

        yield return [new[] { 0, 1 }, new[] { new[] { 5, 0 }, new[] { -5, 2 } }, 11L];

        yield return [new[] { 1, 2, 3 }, new[] { new[] { 2, 3 } }, 2L];

        yield return [new[] { 1, 2, 3 }, new[] { new[] { 0, 1 }, new[] { 4, 2 } }, 4L];

        yield return [new[] { 1, 2, 3 }, new[] { new[] { 0, 2 }, new[] { 4, 1 } }, 4L];

        yield return [new[] { 10, 20, 30 }, new[] { new[] { 0, 3 } }, 60L];

        yield return [new[] { 10, 20, 30 }, new[] { new[] { 15, 1 }, new[] { 25, 1 }, new[] { 35, 1 } }, 15L];

        yield return [new[] { 0, 10 }, new[] { new[] { 5, 1 }, new[] { 100, 1 } }, 95L];

        yield return [new[] { -5, 5 }, new[] { new[] { 0, 2 } }, 10L];

        yield return [new[] { -5, 5 }, new[] { new[] { 0, 1 }, new[] { 10, 1 }, new[] { -10, 1 } }, 10L];

        yield return [new[] { 3, 7 }, new[] { new[] { 3, 1 }, new[] { 7, 1 } }, 0L];

        yield return [new[] { 3, 7 }, new[] { new[] { 7, 1 }, new[] { 3, 1 } }, 0L];

        yield return [new[] { 7, 3, 5 }, new[] { new[] { 4, 3 } }, 5L];

        yield return [new[] { 0, 2, 4, 6 }, new[] { new[] { 1, 2 }, new[] { 5, 2 } }, 4L];

        yield return [new[] { 0, 2, 4, 6 }, new[] { new[] { 1, 3 }, new[] { 5, 1 } }, 6L];

        yield return [new[] { 1, 2, 3, 4 }, new[] { new[] { 0, 0 }, new[] { 10, 4 } }, 30L];

        yield return [new[] { -3, -2, -1 }, new[] { new[] { -2, 1 }, new[] { 0, 2 } }, 4L];

        yield return [new[] { 100 }, new[] { new[] { 0, 1 }, new[] { 150, 1 }, new[] { 90, 1 } }, 10L];

        yield return [new[] { 1000000000, -1000000000 }, new[] { new[] { 0, 2 } }, 2000000000L];

        yield return [new[] { 0, 1000000000 }, new[] { new[] { -1000000000, 1 }, new[] { 1000000000, 1 } }, 1000000000L];

        yield return [new[] { 5, 6 }, new[] { new[] { 0, 1 }, new[] { 6, 1 } }, 5L];

        yield return [new[] { 6, 16, 20 }, new[] { new[] { 0, 1 }, new[] { 10, 1 }, new[] { 20, 1 } }, 12L];
    }
}