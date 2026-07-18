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

using LeetCode.Algorithms.ValidTriangleNumber;

namespace LeetCode.Tests.Algorithms.ValidTriangleNumber;

public abstract class ValidTriangleNumberTestsBase<T> where T : IValidTriangleNumber, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 2, 3, 4 }, 3)]
    [DataRow(new[] { 4, 2, 3, 4 }, 4)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 1, 1, 1 }, 1)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(new[] { 3, 4, 5 }, 1)]
    [DataRow(new[] { 5, 5, 5 }, 1)]
    [DataRow(new[] { 1, 1, 2 }, 0)]
    [DataRow(new[] { 2, 2, 2, 2 }, 4)]
    [DataRow(new[] { 1, 2, 3, 4 }, 1)]
    [DataRow(new[] { 5, 10, 5 }, 0)]
    [DataRow(new[] { 7, 7, 7, 7 }, 4)]
    [DataRow(new[] { 1, 1, 1, 1 }, 4)]
    [DataRow(new[] { 3, 3, 3, 3 }, 4)]
    [DataRow(new[] { 6, 8, 10, 5 }, 4)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3)]
    [DataRow(new[] { 10, 10, 10, 10 }, 4)]
    [DataRow(new[] { 0, 1, 1 }, 0)]
    [DataRow(new[] { 5, 5, 10 }, 0)]
    [DataRow(new[] { 1, 2, 2 }, 1)]
    [DataRow(new[] { 4, 5, 6, 7 }, 4)]
    [DataRow(new[] { 2, 3, 4 }, 1)]
    [DataRow(new[] { 6, 6, 6, 6, 6 }, 10)]
    public void TriangleNumber_WithSideLengths_ReturnsCountOfValidTriangles(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TriangleNumber(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}