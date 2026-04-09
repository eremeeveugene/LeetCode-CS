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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TypeOfTriangle;

public abstract class TypeOfTriangleTestsBase<T> where T : ITypeOfTriangle, new()
{
    [TestMethod]
    [DataRow("[8,4,2]", "none")]
    [DataRow("[3,3,3]", "equilateral")]
    [DataRow("[3,4,5]", "scalene")]
    [DataRow("[3,3,5]", "isosceles")]
    [DataRow("[5,3,3]", "isosceles")]
    [DataRow("[3,5,3]", "isosceles")]
    [DataRow("[4,4,6]", "isosceles")]
    [DataRow("[6,4,4]", "isosceles")]
    [DataRow("[4,6,4]", "isosceles")]
    public void TriangleType_WithThreeSideLengths_ReturnsStringRepresentingTheTypeOfTriangle(string numsJson,
        string expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.TriangleType(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}