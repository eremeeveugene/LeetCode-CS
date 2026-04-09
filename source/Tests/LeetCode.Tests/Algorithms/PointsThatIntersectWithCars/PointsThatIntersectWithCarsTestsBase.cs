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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.PointsThatIntersectWithCars;

public abstract class PointsThatIntersectWithCarsTestsBase<T> where T : IPointsThatIntersectWithCars, new()
{
    [TestMethod]
    [DataRow("[[3,6],[1,5],[4,7]]", 7)]
    [DataRow("[[1,3],[5,8]]", 7)]
    public void NumberOfPoints_WithGivenCarIntervals_ReturnsCountOfCoveredPoints(string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<IList<IList<int>>>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.NumberOfPoints(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}