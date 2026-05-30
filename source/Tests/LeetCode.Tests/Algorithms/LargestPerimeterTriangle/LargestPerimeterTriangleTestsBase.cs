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
    public void LargestPerimeter_WithSideLengths_ReturnsMaximumTrianglePerimeterOrZero(int[] nums,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestPerimeter(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}