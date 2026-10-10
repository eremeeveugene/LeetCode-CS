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

using LeetCode.Algorithms.MaximumProductOfTwoElementsInAnArray;

namespace LeetCode.Tests.Algorithms.MaximumProductOfTwoElementsInAnArray;

public abstract class MaximumProductOfTwoElementsInAnArrayTestsBase<T> where T : IMaximumProductOfTwoElementsInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 7 }, 12)]
    [DataRow(new[] { 3, 4, 5, 2 }, 12)]
    [DataRow(new[] { 1, 5, 4, 5 }, 16)]
    [DataRow(new[] { 1, 1 }, 0)]
    [DataRow(new[] { 1000, 1000 }, 998001)]
    [DataRow(new[] { 1, 1000 }, 0)]
    [DataRow(new[] { 2, 2, 2 }, 1)]
    [DataRow(new[] { 10, 2, 5, 2 }, 36)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 72)]
    [DataRow(new[] { 1000, 999, 1 }, 997002)]
    [DataRow(new[] { 7, 7, 7, 7 }, 36)]
    [DataRow(new[] { 5, 1, 1, 1, 9 }, 32)]
    [DataRow(new[] { 100, 1, 100 }, 9801)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 0)]
    [DataRow(new[] { 2, 1000, 3 }, 1998)]
    [DataRow(new[] { 500, 400, 300, 200 }, 199101)]
    [DataRow(new[] { 9, 8, 7, 6, 5 }, 56)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6 }, 40)]
    [DataRow(new[] { 1000, 1, 1000, 1, 1000 }, 998001)]
    [DataRow(new[] { 8, 3 }, 14)]
    public void MaxProduct_WithVariousInputs_ReturnsMaximumProduct(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxProduct(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}