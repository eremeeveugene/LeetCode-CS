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

using LeetCode.Algorithms.MaximumProductOfThreeNumbers;

namespace LeetCode.Tests.Algorithms.MaximumProductOfThreeNumbers;

public abstract class MaximumProductOfThreeNumbersTestsBase<T> where T : IMaximumProductOfThreeNumbers, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, 6)]
    [DataRow(new[] { 1, 2, 3, 4 }, 24)]
    [DataRow(new[] { -1, -2, -3 }, -6)]
    [DataRow(new[] { -100, -98, -1, 2, 3, 4 }, 39200)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { -1, 0, 1 }, 0)]
    [DataRow(new[] { 1000, 1000, 1000 }, 1000000000)]
    [DataRow(new[] { -1000, -1000, 1000 }, 1000000000)]
    [DataRow(new[] { -1000, -1000, -1000 }, -1000000000)]
    [DataRow(new[] { 7, 3, 1, 0, 0, 6 }, 126)]
    [DataRow(new[] { -5, -4, -3, -2, -1 }, -6)]
    [DataRow(new[] { -10, -10, 5, 2 }, 500)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 720)]
    [DataRow(new[] { -4, -3, -2, -1, 60 }, 720)]
    [DataRow(new[] { 2, 5, 8, 9 }, 360)]
    [DataRow(new[] { 0, -1, 3, 100, -70, -50 }, 350000)]
    [DataRow(new[] { 1, 0, 1 }, 0)]
    [DataRow(new[] { -1, -2, 1, 2 }, 4)]
    [DataRow(new[] { 6, 7, 8 }, 336)]
    [DataRow(new[] { -8, -7, 6, 5 }, 336)]
    [DataRow(new[] { 10, 20, 30, 40, -50, -60 }, 120000)]
    [DataRow(new[] { -1, -1, -1, 1 }, 1)]
    public void MaximumProduct_WithIntegerArray_ReturnsMaximumProductOfThreeNumbers(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumProduct(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}