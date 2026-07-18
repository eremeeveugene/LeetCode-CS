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

using LeetCode.Algorithms.CountSpecialTriplets;

namespace LeetCode.Tests.Algorithms.CountSpecialTriplets;

public abstract class CountSpecialTripletsTestsBase<T> where T : ICountSpecialTriplets, new()
{
    [TestMethod]
    [DataRow(new[] { 6, 3, 6 }, 1)]
    [DataRow(new[] { 0, 1, 0, 0 }, 1)]
    [DataRow(new[] { 8, 4, 2, 8, 4 }, 2)]
    [DataRow(new[] { 1, 2, 1 }, 0)]
    [DataRow(new[] { 2, 1, 2 }, 1)]
    [DataRow(new[] { 4, 2, 4 }, 1)]
    [DataRow(new[] { 0, 0, 0 }, 1)]
    [DataRow(new[] { 1, 1, 1 }, 0)]
    [DataRow(new[] { 6, 3, 6, 3, 6 }, 4)]
    [DataRow(new[] { 10, 5, 10 }, 1)]
    [DataRow(new[] { 100, 50, 100 }, 1)]
    [DataRow(new[] { 2, 1, 2, 1, 2 }, 4)]
    [DataRow(new[] { 4, 2, 1, 4 }, 1)]
    [DataRow(new[] { 3, 3, 3 }, 0)]
    [DataRow(new[] { 8, 4, 8 }, 1)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(new[] { 0, 0, 0, 0 }, 4)]
    [DataRow(new[] { 12, 6, 12 }, 1)]
    [DataRow(new[] { 5, 5, 5, 5 }, 0)]
    [DataRow(new[] { 14, 7, 14, 7 }, 4)]
    [DataRow(new[] { 2, 2, 2, 2, 2 }, 0)]
    public void SpecialTriplets_WithNumsArray_ReturnsCountOfSpecialTriplets(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SpecialTriplets(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}