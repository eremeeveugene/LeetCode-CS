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

using LeetCode.Algorithms.ContainerWithMostWater;

namespace LeetCode.Tests.Algorithms.ContainerWithMostWater;

public abstract class ContainerWithMostWaterTestsBase<T> where T : IContainerWithMostWater, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 2, 1 }, 1)]
    [DataRow(new[] { 4, 3, 2, 1, 4 }, 16)]
    [DataRow(new[] { 1, 2, 1 }, 2)]
    [DataRow(new[] { 2, 3, 4, 5, 18, 17, 6 }, 17)]
    [DataRow(new[] { 5, 5, 5, 5 }, 15)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 6)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 6)]
    [DataRow(new[] { 10000, 10000 }, 10000)]
    [DataRow(new[] { 0, 0 }, 0)]
    [DataRow(new[] { 0, 5, 0 }, 0)]
    [DataRow(new[] { 3, 9, 3, 4, 7, 2, 12, 6 }, 45)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1 }, 5)]
    [DataRow(new[] { 7, 1, 2, 3, 9 }, 28)]
    [DataRow(new[] { 2, 3, 10, 5, 7, 8, 9 }, 36)]
    [DataRow(new[] { 6, 1, 6 }, 12)]
    [DataRow(new[] { 100, 1, 1, 1, 100 }, 400)]
    [DataRow(new[] { 1, 1000, 1000, 1 }, 1000)]
    [DataRow(new[] { 4, 4, 2, 4 }, 12)]
    [DataRow(new[] { 8, 10, 14, 0, 13, 10, 9, 9, 8, 9 }, 72)]
    public void MaxArea_WithHeightsArray_ReturnsMaximumWaterContained(int[] heights, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxArea(heights);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}