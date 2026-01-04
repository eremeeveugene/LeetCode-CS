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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LargestPerimeterTriangle;

public abstract class LargestPerimeterTriangleTestsBase<T> where T : ILargestPerimeterTriangle, new()
{
    [TestMethod]
    [DataRow("[2,1,2]", 5)]
    [DataRow("[1,2,1,10]", 0)]
    public void LargestPerimeter_WithSideLengths_ReturnsMaximumTrianglePerimeterOrZero(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.LargestPerimeter(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}