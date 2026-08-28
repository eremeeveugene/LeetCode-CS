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

using LeetCode.Algorithms.RectangleOverlap;

namespace LeetCode.Tests.Algorithms.RectangleOverlap;

public abstract class RectangleOverlapTestsBase<T> where T : IRectangleOverlap, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void IsRectangleOverlap_WithGivenRectangles_ReturnsWhetherTheirIntersectionHasPositiveArea(int[] rec1, int[] rec2, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsRectangleOverlap(rec1, rec2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 0, 0, 2, 2 }, new[] { 1, 1, 3, 3 }, true];
        yield return [new[] { 0, 0, 1, 1 }, new[] { 1, 0, 2, 1 }, false];
        yield return [new[] { 0, 0, 1, 1 }, new[] { 2, 2, 3, 3 }, false];
        yield return [new[] { 2, 0, 3, 1 }, new[] { 0, 0, 2, 1 }, false];
        yield return [new[] { 0, 2, 1, 3 }, new[] { 0, 0, 1, 2 }, false];
        yield return [new[] { 0, 0, 1, 1 }, new[] { 0, 1, 1, 2 }, false];
        yield return [new[] { 0, 0, 4, 4 }, new[] { 1, 1, 2, 2 }, true];
        yield return [new[] { 1, 1, 2, 2 }, new[] { 0, 0, 4, 4 }, true];
        yield return [new[] { -2, -2, 2, 2 }, new[] { -2, -2, 2, 2 }, true];
        yield return [new[] { -4, -3, -1, -1 }, new[] { -3, -2, 0, 1 }, true];
        yield return [new[] { -5, -5, -4, -4 }, new[] { -3, -3, -2, -2 }, false];
        yield return [new[] { 0, 0, 4, 1 }, new[] { 2, -2, 3, 3 }, true];
        yield return [new[] { 0, 0, 1, 10 }, new[] { 0, 5, 1, 6 }, true];
        yield return [new[] { 0, 0, 10, 1 }, new[] { 5, 0, 6, 1 }, true];
        yield return [new[] { 0, 0, 2, 2 }, new[] { -1, 1, 1, 3 }, true];
        yield return [new[] { -1_000_000_000, -1_000_000_000, 1_000_000_000, 1_000_000_000 }, new[] { -1, -1, 1, 1 }, true];
        yield return [new[] { -1_000_000_000, -1_000_000_000, 0, 0 }, new[] { 0, 0, 1_000_000_000, 1_000_000_000 }, false];
        yield return [new[] { 0, 0, 3, 3 }, new[] { 2, -1, 4, 1 }, true];
        yield return [new[] { 0, 0, 3, 3 }, new[] { -1, 2, 1, 4 }, true];
        yield return [new[] { 0, 0, 2, 2 }, new[] { 2, 2, 4, 4 }, false];
        yield return [new[] { 0, 0, 2, 2 }, new[] { -2, 2, 0, 4 }, false];
        yield return [new[] { 0, 0, 2, 2 }, new[] { 2, -2, 4, 0 }, false];
        yield return [new[] { 0, 0, 2, 2 }, new[] { -2, -2, 0, 0 }, false];
        yield return [new[] { 1, 1, 5, 5 }, new[] { 4, 4, 6, 6 }, true];
        yield return [new[] { 1, 1, 5, 5 }, new[] { 5, 2, 7, 4 }, false];
    }
}