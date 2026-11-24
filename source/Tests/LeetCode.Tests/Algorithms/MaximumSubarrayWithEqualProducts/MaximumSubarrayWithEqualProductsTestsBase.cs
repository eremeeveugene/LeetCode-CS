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

using LeetCode.Algorithms.MaximumSubarrayWithEqualProducts;

namespace LeetCode.Tests.Algorithms.MaximumSubarrayWithEqualProducts;

public abstract class MaximumSubarrayWithEqualProductsTestsBase<T> where T : IMaximumSubarrayWithEqualProducts, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 1, 2, 1, 1, 1 }, 5)]
    [DataRow(new[] { 2, 3, 4, 5, 6 }, 3)]
    [DataRow(new[] { 1, 2, 3, 1, 4, 5, 1 }, 5)]
    [DataRow(new[] { 1, 1 }, 2)]
    [DataRow(new[] { 2, 2 }, 2)]
    [DataRow(new[] { 10, 10 }, 2)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 5)]
    [DataRow(new[] { 2, 2, 2, 2 }, 2)]
    [DataRow(new[] { 2, 3, 5, 7 }, 4)]
    [DataRow(new[] { 1, 2, 3, 5, 7, 1 }, 6)]
    [DataRow(new[] { 10, 10, 10, 10, 10 }, 2)]
    [DataRow(new[] { 6, 10, 15 }, 2)]
    [DataRow(new[] { 4, 9, 5, 7 }, 4)]
    [DataRow(new[] { 8, 9, 5, 7, 1, 1 }, 6)]
    [DataRow(new[] { 2, 4, 8, 3 }, 2)]
    [DataRow(new[] { 3, 4, 5, 6, 7 }, 3)]
    [DataRow(new[] { 7, 1, 10, 3, 1 }, 5)]
    [DataRow(new[] { 9, 3, 1, 1, 2, 5, 7 }, 6)]
    [DataRow(new[] { 5, 5, 1, 5 }, 2)]
    [DataRow(new[] { 1, 10, 9, 7, 6 }, 4)]
    [DataRow(new[] { 2, 1, 2, 1, 2 }, 3)]
    [DataRow(new[] { 1, 1, 2, 1, 1 }, 5)]
    [DataRow(new[] { 6, 1, 1, 5, 7, 4, 9 }, 6)]
    [DataRow(new[] { 8, 8, 8, 9, 9, 9, 7, 7 }, 2)]
    [DataRow(new[] { 6, 10, 3, 5, 7 }, 3)]
    public void MaxLength_WithInputNums_ReturnsLongestProductEquivalentSubarrayLength(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxLength(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}