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
    }
}