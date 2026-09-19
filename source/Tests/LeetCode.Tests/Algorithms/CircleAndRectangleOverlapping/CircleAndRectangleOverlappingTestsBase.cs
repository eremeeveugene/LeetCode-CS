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

using LeetCode.Algorithms.CircleAndRectangleOverlapping;

namespace LeetCode.Tests.Algorithms.CircleAndRectangleOverlapping;

public abstract class CircleAndRectangleOverlappingTestsBase<T> where T : ICircleAndRectangleOverlapping, new()
{
    [TestMethod]
    [DataRow(1, 0, 0, 1, -1, 3, 1, true)]
    [DataRow(1, 1, 1, 1, -3, 2, -1, false)]
    [DataRow(1, 0, 0, -1, 0, 0, 1, true)]
    [DataRow(2, 0, 0, -1, -1, 1, 1, true)]
    [DataRow(5, 0, 0, 3, 4, 6, 7, true)]
    [DataRow(4, 0, 0, 3, 4, 6, 7, false)]
    [DataRow(1, -10000, -10000, 9998, 9998, 10000, 10000, false)]
    [DataRow(1, 0, 0, -5, -5, 5, 5, true)]
    [DataRow(10, 0, 0, -2, -2, 2, 2, true)]
    [DataRow(1, -2, 0, -2, -2, 2, 2, true)]
    [DataRow(1, 2, 2, -2, -2, 2, 2, true)]
    [DataRow(2, -4, 0, -2, -2, 2, 2, true)]
    [DataRow(2, 4, 0, -2, -2, 2, 2, true)]
    [DataRow(2, 0, -4, -2, -2, 2, 2, true)]
    [DataRow(2, 0, 4, -2, -2, 2, 2, true)]
    [DataRow(2, -5, 0, -2, -2, 2, 2, false)]
    [DataRow(2, 5, 0, -2, -2, 2, 2, false)]
    [DataRow(2, 0, -5, -2, -2, 2, 2, false)]
    [DataRow(2, 0, 5, -2, -2, 2, 2, false)]
    [DataRow(5, -5, -6, -2, -2, 2, 2, true)]
    [DataRow(5, -5, 6, -2, -2, 2, 2, true)]
    [DataRow(5, 5, -6, -2, -2, 2, 2, true)]
    [DataRow(5, 5, 6, -2, -2, 2, 2, true)]
    [DataRow(4, -5, -6, -2, -2, 2, 2, false)]
    [DataRow(4, -5, 6, -2, -2, 2, 2, false)]
    [DataRow(4, 5, -6, -2, -2, 2, 2, false)]
    [DataRow(4, 5, 6, -2, -2, 2, 2, false)]
    [DataRow(3, 4, 0, -2, -2, 2, 2, true)]
    [DataRow(3, 4, 4, -2, -2, 2, 2, true)]
    [DataRow(2000, 10000, 10000, 8000, 9999, 8001, 10000, true)]
    [DataRow(2000, -10000, -10000, -7999, -10000, -7998, -9999, false)]
    public void CheckOverlap_WithCircleAndRectangle_ReturnsWhetherTheyOverlap(
        int radius,
        int xCenter,
        int yCenter,
        int x1,
        int y1,
        int x2,
        int y2,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckOverlap(radius, xCenter, yCenter, x1, y1, x2, y2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}