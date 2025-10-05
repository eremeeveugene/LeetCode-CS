// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ContainerWithMostWater;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ContainerWithMostWater;

public abstract class ContainerWithMostWaterTestsBase<T> where T : IContainerWithMostWater, new()
{
    [TestMethod]
    [DataRow("[1,1]", 1)]
    [DataRow("[1,8,6,2,5,4,8,3,7]", 49)]
    public void MaxArea_WithHeightsArray_ReturnsMaximumWaterContained(string heightsJson, int expectedResult)
    {
        // Arrange
        var heights = JsonHelper<int[]>.Parse(heightsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxArea(heights);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}