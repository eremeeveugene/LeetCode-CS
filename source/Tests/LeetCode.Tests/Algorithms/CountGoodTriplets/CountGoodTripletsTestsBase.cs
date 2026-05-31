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

using LeetCode.Algorithms.CountGoodTriplets;

namespace LeetCode.Tests.Algorithms.CountGoodTriplets;

public abstract class CountGoodTripletsTestsBase<T> where T : ICountGoodTriplets, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 0, 1, 1, 9, 7 }, 7, 2, 3, 4)]
    [DataRow(new[] { 1, 1, 2, 2, 3 }, 0, 0, 1, 0)]
    [DataRow(new[] { 1, 2, 3 }, 10, 10, 10, 1)]
    [DataRow(new[] { 0, 0, 0 }, 0, 0, 0, 1)]
    [DataRow(new[] { 1, 1, 1 }, 0, 0, 0, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 1, 2, 3)]
    [DataRow(new[] { 1, 2, 3 }, 0, 0, 0, 0)]
    [DataRow(new[] { 5, 5, 5, 5 }, 0, 0, 0, 4)]
    [DataRow(new[] { 1, 10, 1 }, 0, 9, 0, 0)]
    [DataRow(new[] { 1, 10, 1 }, 9, 9, 0, 1)]
    [DataRow(new[] { 1, 10, 1 }, 9, 9, 9, 1)]
    [DataRow(new[] { 0, 1, 2, 3, 4 }, 2, 2, 4, 8)]
    [DataRow(new[] { 1, 2, 3, 4 }, 1, 1, 2, 2)]
    [DataRow(new[] { 9, 8, 7, 6, 5 }, 1, 1, 2, 2)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 0, 0, 0, 10)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0, 0, 0, 0)]
    [DataRow(new[] { 1, 2, 3 }, 1, 1, 2, 1)]
    [DataRow(new[] { 1, 3, 5, 7 }, 2, 2, 4, 2)]
    public void CountGoodTriplets_WithGivenArrayAndConstraints_ReturnsNumberOfValidTriplets(int[] arr, int a, int b, int c, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountGoodTriplets(arr, a, b, c);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}