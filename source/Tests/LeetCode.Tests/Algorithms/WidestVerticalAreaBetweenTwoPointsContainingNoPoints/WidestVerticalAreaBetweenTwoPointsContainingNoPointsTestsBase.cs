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

using LeetCode.Algorithms.WidestVerticalAreaBetweenTwoPointsContainingNoPoints;

namespace LeetCode.Tests.Algorithms.WidestVerticalAreaBetweenTwoPointsContainingNoPoints;

public abstract class WidestVerticalAreaBetweenTwoPointsContainingNoPointsTestsBase<T>
    where T : IWidestVerticalAreaBetweenTwoPointsContainingNoPoints, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxWidthOfVerticalArea_WithJsonPoints_ReturnsMaxWidth(int[][] points, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxWidthOfVerticalArea(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 8, 7 }, new[] { 9, 9 }, new[] { 7, 4 }, new[] { 9, 7 } }, 1];

        yield return [new[] { new[] { 3, 1 }, new[] { 9, 0 }, new[] { 1, 0 }, new[] { 1, 4 }, new[] { 5, 3 }, new[] { 8, 8 } }, 3];

        yield return [new[] { new[] { 1, 1 }, new[] { 2, 2 } }, 1];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 0];

        yield return [new[] { new[] { 5, 5 }, new[] { 5, 6 }, new[] { 5, 7 } }, 0];

        yield return [new[] { new[] { 1, 0 }, new[] { 2, 0 }, new[] { 3, 0 } }, 1];

        yield return [new[] { new[] { 0, 0 }, new[] { 1000000000, 1000000000 } }, 1000000000];

        yield return [new[] { new[] { 1000000000, 0 }, new[] { 0, 1000000000 } }, 1000000000];

        yield return [new[] { new[] { 1, 1 }, new[] { 10, 1 }, new[] { 11, 1 }, new[] { 12, 1 } }, 9];

        yield return [new[] { new[] { 1, 1 }, new[] { 2, 1 }, new[] { 3, 1 }, new[] { 100, 1 } }, 97];

        yield return [new[] { new[] { 3, 3 }, new[] { 1, 1 }, new[] { 2, 2 }, new[] { 10, 10 }, new[] { 4, 4 } }, 6];

        yield return [new[] { new[] { 0, 5 }, new[] { 3, 5 }, new[] { 3, 6 }, new[] { 7, 1 }, new[] { 8, 8 } }, 4];

        yield return [new[] { new[] { 100, 0 }, new[] { 90, 0 }, new[] { 80, 0 }, new[] { 70, 0 }, new[] { 60, 0 } }, 10];

        yield return [new[] { new[] { 60, 0 }, new[] { 70, 0 }, new[] { 80, 0 }, new[] { 90, 0 }, new[] { 100, 0 } }, 10];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 1, 4 } }, 0];

        yield return [new[] { new[] { 0, 0 }, new[] { 500000000, 1 }, new[] { 1000000000, 2 } }, 500000000];

        yield return [new[] { new[] { 9, 9 }, new[] { 1, 1 }, new[] { 5, 5 }, new[] { 1, 2 }, new[] { 9, 1 }, new[] { 5, 2 } }, 4];

        yield return [new[] { new[] { 2, 0 }, new[] { 4, 0 }, new[] { 8, 0 }, new[] { 16, 0 }, new[] { 32, 0 }, new[] { 64, 0 } }, 32];

        yield return [CreateEvenlySpacedPoints(100000, 10000), 10000];

        yield return [CreateTwoClustersPoints(50000, 1000000000), 999900002];
    }

    private static int[][] CreateEvenlySpacedPoints(int count, int step)
    {
        var points = new int[count][];

        for (var i = 0; i < count; i++)
        {
            points[i] = [i * step, i];
        }

        return points;
    }

    private static int[][] CreateTwoClustersPoints(int clusterSize, int maxX)
    {
        var points = new int[clusterSize * 2][];

        for (var i = 0; i < clusterSize; i++)
        {
            points[i] = [i, 0];
            points[clusterSize + i] = [maxX - i, 0];
        }

        return points;
    }
}