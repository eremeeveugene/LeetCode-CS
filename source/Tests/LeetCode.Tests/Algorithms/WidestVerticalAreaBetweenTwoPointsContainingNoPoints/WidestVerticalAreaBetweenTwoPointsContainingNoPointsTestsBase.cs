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

        yield return
            [new[] { new[] { 3, 1 }, new[] { 9, 0 }, new[] { 1, 0 }, new[] { 1, 4 }, new[] { 5, 3 }, new[] { 8, 8 } }, 3];
    }
}