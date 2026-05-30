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
    }
}