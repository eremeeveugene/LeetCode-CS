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

using LeetCode.Algorithms.LargestPerimeterTriangle;

namespace LeetCode.Tests.Algorithms.LargestPerimeterTriangle;

public abstract class LargestPerimeterTriangleTestsBase<T> where T : ILargestPerimeterTriangle, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1, 2 }, 5)]
    [DataRow(new[] { 1, 2, 1, 10 }, 0)]
    [DataRow(new[] { 3, 2, 3, 4 }, 10)]
    [DataRow(new[] { 1, 1, 1 }, 3)]
    [DataRow(new[] { 5, 5, 5 }, 15)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(new[] { 2, 3, 4, 5, 6 }, 15)]
    [DataRow(new[] { 10, 10, 10 }, 30)]
    [DataRow(new[] { 1, 1, 2 }, 0)]
    [DataRow(new[] { 5, 5, 1 }, 11)]
    [DataRow(new[] { 3, 6, 2, 3 }, 8)]
    [DataRow(new[] { 7, 10, 5, 40 }, 22)]
    [DataRow(new[] { 1, 1, 1, 1 }, 3)]
    [DataRow(new[] { 4, 4, 4, 4 }, 12)]
    [DataRow(new[] { 2, 2, 2, 3 }, 7)]
    [DataRow(new[] { 1, 1 }, 0)]
    [DataRow(new[] { 5 }, 0)]
    [DataRow(new[] { 1, 1, 1, 100 }, 3)]
    public void LargestPerimeter_WithSideLengths_ReturnsMaximumTrianglePerimeterOrZero(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestPerimeter(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}