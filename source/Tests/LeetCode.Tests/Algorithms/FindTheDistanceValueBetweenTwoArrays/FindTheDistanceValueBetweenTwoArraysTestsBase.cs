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

using LeetCode.Algorithms.FindTheDistanceValueBetweenTwoArrays;

namespace LeetCode.Tests.Algorithms.FindTheDistanceValueBetweenTwoArrays;

public abstract class FindTheDistanceValueBetweenTwoArraysTestsBase<T> where T : IFindTheDistanceValueBetweenTwoArrays, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 5, 8 }, new[] { 10, 9, 1, 8 }, 2, 2)]
    [DataRow(new[] { 1, 4, 2, 3 }, new[] { -4, -3, 6, 10, 20, 30 }, 3, 2)]
    [DataRow(new[] { 2, 1, 100, 3 }, new[] { -5, -2, 10, -3, 7 }, 6, 1)]
    [DataRow(new[] { 1 }, new[] { 1 }, 0, 0)]
    [DataRow(new[] { 1 }, new[] { 2 }, 0, 1)]
    [DataRow(new[] { 1 }, new[] { 2 }, 1, 0)]
    [DataRow(new[] { 1 }, new[] { 3 }, 1, 1)]
    [DataRow(new[] { 5 }, new[] { 1 }, 3, 1)]
    [DataRow(new[] { 5 }, new[] { 1 }, 4, 0)]
    [DataRow(new[] { 1 }, new[] { 5 }, 3, 1)]
    [DataRow(new[] { 1 }, new[] { 5 }, 4, 0)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, 0, 0)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, 0, 3)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, 1, 2)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, 100, 0)]
    [DataRow(new[] { -1000 }, new[] { 1000 }, 100, 1)]
    [DataRow(new[] { -1000, 1000 }, new[] { 0 }, 100, 2)]
    [DataRow(new[] { -5, -3, -1 }, new[] { -4 }, 1, 1)]
    [DataRow(new[] { -5, -3, -1 }, new[] { -4 }, 0, 3)]
    [DataRow(new[] { 7, 7, 7 }, new[] { 7 }, 0, 0)]
    [DataRow(new[] { 7, 7, 7 }, new[] { 9 }, 1, 3)]
    [DataRow(new[] { 7, 7, 7 }, new[] { 9, 9 }, 2, 0)]
    [DataRow(new[] { 10, 1, 5 }, new[] { 3 }, 1, 3)]
    [DataRow(new[] { 10, 1, 5 }, new[] { 3 }, 2, 1)]
    [DataRow(new[] { 1, 10, 20 }, new[] { 5, 15 }, 4, 2)]
    [DataRow(new[] { 1, 10, 20 }, new[] { 5, 15 }, 5, 0)]
    [DataRow(new[] { 0 }, new[] { -1, 1 }, 0, 1)]
    [DataRow(new[] { 0 }, new[] { -1, 1 }, 1, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 3 }, 1, 2)]
    [DataRow(new[] { 100, 200, 300 }, new[] { 150, 250 }, 49, 3)]
    [DataRow(new[] { 100, 200, 300 }, new[] { 150, 250 }, 50, 0)]
    [DataRow(new[] { -1000, -500, 0, 500, 1000 }, new[] { -900, -450, 100, 450, 950 }, 50, 2)]
    public void FindTheDistanceValue_WithTwoArraysAndDistance_ReturnsDistanceValue(int[] arr1, int[] arr2, int d, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindTheDistanceValue(arr1, arr2, d);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}