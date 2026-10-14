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

using LeetCode.Algorithms.MinimumTimeVisitingAllPoints;

namespace LeetCode.Tests.Algorithms.MinimumTimeVisitingAllPoints;

public abstract class MinimumTimeVisitingAllPointsTestsBase<T> where T : IMinimumTimeVisitingAllPoints, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinTimeToVisitAllPoints_WithPointsArray_ReturnsSumOfStepwiseDistances(int[][] points, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinTimeToVisitAllPoints(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 1 }, new[] { 3, 4 }, new[] { -1, 0 } }, 7];

        yield return [new[] { new[] { 3, 2 }, new[] { -2, 2 } }, 5];
        yield return [new[] { new[] { 0, 0 } }, 0];
        yield return [new[] { new[] { 5, 5 } }, 0];
        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 0];
        yield return [new[] { new[] { 0, 0 }, new[] { 1, 1 } }, 1];
        yield return [new[] { new[] { 0, 0 }, new[] { 5, 0 } }, 5];
        yield return [new[] { new[] { 0, 0 }, new[] { 0, -7 } }, 7];
        yield return [new[] { new[] { 0, 0 }, new[] { 3, 7 } }, 7];
        yield return [new[] { new[] { -5, -5 }, new[] { 5, 5 } }, 10];
        yield return [new[] { new[] { 1, 1 }, new[] { 2, 3 }, new[] { 3, 1 }, new[] { 1, 1 } }, 6];
        yield return [new[] { new[] { 0, 0 }, new[] { 2, 1 }, new[] { 4, 2 }, new[] { 6, 3 } }, 6];
        yield return [new[] { new[] { -25, 34 }, new[] { -24, 5 }, new[] { 26, 19 }, new[] { -43, -34 }, new[] { 49, 47 }, new[] { 11, -45 }, new[] { 43, 37 } }, 414];
        yield return [new[] { new[] { 14, -29 }, new[] { 31, 4 }, new[] { -19, 45 }, new[] { 2, 41 }, new[] { -25, 50 }, new[] { 38, -47 } }, 228];
        yield return [new[] { new[] { -22, -32 }, new[] { -34, -23 }, new[] { 26, 11 }, new[] { 47, -1 }, new[] { -4, -19 }, new[] { 24, -47 }, new[] { -47, 44 } }, 263];
        yield return [new[] { new[] { 19, 18 }, new[] { -35, 15 }, new[] { -45, 32 }, new[] { -50, 9 } }, 94];
        yield return [new[] { new[] { 34, 21 }, new[] { -10, -10 }, new[] { 35, 4 }, new[] { 5, 38 }, new[] { -25, -43 }, new[] { -18, -25 } }, 222];
        yield return [new[] { new[] { -1, 4 }, new[] { 27, 16 }, new[] { -31, -43 }, new[] { -38, -41 }, new[] { -34, 19 }, new[] { 20, 41 } }, 208];
        yield return [new[] { new[] { -44, 2 }, new[] { -23, -3 } }, 21];
        yield return [new[] { new[] { 49, -39 }, new[] { 19, -9 }, new[] { -37, 2 }, new[] { 50, -45 }, new[] { 3, 40 }, new[] { 8, 24 } }, 274];
        yield return [new[] { new[] { -45, -5 }, new[] { -38, 36 } }, 41];
        yield return [new[] { new[] { -40, -33 }, new[] { 36, -15 }, new[] { -6, 47 } }, 138];
        yield return [new[] { new[] { 49, 37 }, new[] { 39, 5 }, new[] { -6, 16 }, new[] { 10, 27 }, new[] { -1, 41 }, new[] { -46, -45 } }, 193];
        yield return [new[] { new[] { 22, -49 }, new[] { 16, -36 }, new[] { 29, 38 } }, 87];
        yield return [new[] { new[] { -1000, -1000 }, new[] { 1000, 1000 } }, 2000];
        yield return [new[] { new[] { -1000, 1000 }, new[] { 1000, -1000 }, new[] { -1000, 1000 } }, 4000];
        yield return [new[] { new[] { -1000, -1000 }, new[] { 1000, 0 } }, 2000];
    }
}