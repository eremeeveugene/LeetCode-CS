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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumTimeVisitingAllPoints;

public abstract class MinimumTimeVisitingAllPointsTestsBase<T> where T : IMinimumTimeVisitingAllPoints, new()
{
    [TestMethod]
    [DataRow("[[1,1],[3,4],[-1,0]]", 7)]
    [DataRow("[[3,2],[-2,2]]", 5)]
    public void MinTimeToVisitAllPoints_WithPointsArray_ReturnsSumOfStepwiseDistances(string pointsJson,
        int expectedResult)
    {
        // Arrange
        var points = JsonHelper<int[][]>.Parse(pointsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinTimeToVisitAllPoints(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}