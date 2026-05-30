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