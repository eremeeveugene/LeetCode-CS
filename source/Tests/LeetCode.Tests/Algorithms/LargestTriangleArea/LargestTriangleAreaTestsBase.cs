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

using LeetCode.Algorithms.LargestTriangleArea;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LargestTriangleArea;

public abstract class LargestTriangleAreaTestsBase<T> where T : ILargestTriangleArea, new()
{
    [TestMethod]
    [DataRow("[[0,0],[0,1],[1,0],[0,2],[2,0]]", 2.0)]
    [DataRow("[[1,0],[0,0],[0,1]]", 0.5)]
    public void LargestTriangleArea_WithPoints_ReturnsMaximumTriangleArea(string pointsJson,
        double expectedResult)
    {
        // Arrange
        var points = JsonHelper.Parse<int[][]>(pointsJson);

        var solution = new T();

        // Act
        var actualResult = solution.LargestTriangleArea(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}