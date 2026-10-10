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

using LeetCode.Algorithms.PointsThatIntersectWithCars;

namespace LeetCode.Tests.Algorithms.PointsThatIntersectWithCars;

public abstract class PointsThatIntersectWithCarsTestsBase<T> where T : IPointsThatIntersectWithCars, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void NumberOfPoints_WithGivenCarIntervals_ReturnsCountOfCoveredPoints(int[][] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfPoints(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 3, 6 }, new[] { 1, 5 }, new[] { 4, 7 } }, 7];

        yield return [new[] { new[] { 1, 3 }, new[] { 5, 8 } }, 7];

        yield return [new[] { new[] { 1, 1 } }, 1];

        yield return [new[] { new[] { 100, 100 } }, 1];

        yield return [new[] { new[] { 1, 100 } }, 100];

        yield return [new[] { new[] { 1, 1 }, new[] { 100, 100 } }, 2];

        yield return [new[] { new[] { 2, 2 }, new[] { 2, 2 }, new[] { 2, 2 } }, 1];

        yield return [new[] { new[] { 1, 50 }, new[] { 51, 100 } }, 100];

        yield return [new[] { new[] { 1, 50 }, new[] { 50, 100 } }, 100];

        yield return [new[] { new[] { 10, 20 }, new[] { 15, 25 }, new[] { 30, 40 } }, 27];

        yield return [new[] { new[] { 5, 5 }, new[] { 6, 6 }, new[] { 7, 7 } }, 3];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 } }, 8];

        yield return [new[] { new[] { 99, 100 }, new[] { 1, 2 } }, 4];

        yield return [new[] { new[] { 20, 30 }, new[] { 22, 24 }, new[] { 25, 28 } }, 11];

        yield return [new[] { new[] { 1, 10 }, new[] { 2, 3 }, new[] { 4, 5 }, new[] { 6, 7 } }, 10];

        yield return [new[] { new[] { 60, 70 }, new[] { 10, 20 }, new[] { 65, 80 }, new[] { 15, 25 } }, 37];

        yield return [new[] { new[] { 1, 1 }, new[] { 2, 100 } }, 100];

        yield return [new[] { new[] { 50, 60 }, new[] { 40, 55 }, new[] { 30, 45 } }, 31];

        yield return [CreateOddPointIntervals(), 50];

        yield return [CreateFullRangeIntervals(), 100];
    }

    private static int[][] CreateOddPointIntervals()
    {
        var intervals = new int[50][];

        for (var i = 0; i < intervals.Length; i++)
        {
            var point = (i * 2) + 1;

            intervals[i] = [point, point];
        }

        return intervals;
    }

    private static int[][] CreateFullRangeIntervals()
    {
        var intervals = new int[100][];

        for (var i = 0; i < intervals.Length; i++)
        {
            intervals[i] = [1, 100];
        }

        return intervals;
    }
}