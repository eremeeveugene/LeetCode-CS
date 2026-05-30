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

using LeetCode.Algorithms.TypeOfTriangle;

namespace LeetCode.Tests.Algorithms.TypeOfTriangle;

public abstract class TypeOfTriangleTestsBase<T> where T : ITypeOfTriangle, new()
{
    [TestMethod]
    [DataRow(new[] { 8, 4, 2 }, "none")]
    [DataRow(new[] { 3, 3, 3 }, "equilateral")]
    [DataRow(new[] { 3, 4, 5 }, "scalene")]
    [DataRow(new[] { 3, 3, 5 }, "isosceles")]
    [DataRow(new[] { 5, 3, 3 }, "isosceles")]
    [DataRow(new[] { 3, 5, 3 }, "isosceles")]
    [DataRow(new[] { 4, 4, 6 }, "isosceles")]
    [DataRow(new[] { 6, 4, 4 }, "isosceles")]
    [DataRow(new[] { 4, 6, 4 }, "isosceles")]
    public void TriangleType_WithThreeSideLengths_ReturnsStringRepresentingTheTypeOfTriangle(int[] nums, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TriangleType(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}