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