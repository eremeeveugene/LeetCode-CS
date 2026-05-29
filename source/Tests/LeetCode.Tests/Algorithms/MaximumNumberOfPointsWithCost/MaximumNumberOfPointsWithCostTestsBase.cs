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

using LeetCode.Algorithms.MaximumNumberOfPointsWithCost;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfPointsWithCost;

public abstract class MaximumNumberOfPointsWithCostTestsBase<T> where T : IMaximumNumberOfPointsWithCost, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxPoints_WithPointsMatrix_ReturnsMaximumAchievablePoints(int[][] points, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxPoints(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1 } }, 1L];

        yield return [new[] { new[] { 5, 1, 100, 3 } }, 100L];

        yield return [new[] { new[] { 1, 5 }, new[] { 2, 3 }, new[] { 4, 2 } }, 11L];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 1, 5, 1 }, new[] { 3, 1, 1 } }, 9L];

        yield return [new[] { new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 100000, 0, 0 }, new[] { 0, 0, 0, 0, 0 } }, 100000L];

        yield return [new[] { new[] { 100000, 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1, 100000 }, new[] { 1, 1, 1, 1, 1, 1 }, new[] { 100000, 1, 1, 1, 1, 1 }, new[] { 1, 100000, 1, 1, 1, 1 } }, 399990L];

        yield return [new[] { new[] { 100000, 90000, 80000, 70000, 60000, 50000 }, new[] { 1, 2, 3, 4, 5, 6 }, new[] { 100000, 90000, 80000, 70000, 60000, 50000 }, new[] { 5, 10, 15, 20, 25, 30 }, new[] { 100000, 90000, 80000, 70000, 60000, 50000 } }, 300021L];
    }
}