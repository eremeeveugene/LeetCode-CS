﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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

public abstract class MaximumProductOfTwoElementsInAnArrayTestsBase<T>
    where T : IMaximumProductOfTwoElementsInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 7 }, 12)]
    [DataRow(new[] { 3, 4, 5, 2 }, 12)]
    [DataRow(new[] { 1, 5, 4, 5 }, 16)]
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