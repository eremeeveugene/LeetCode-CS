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

using LeetCode.Algorithms.ThirdMaximumNumber;

namespace LeetCode.Tests.Algorithms.ThirdMaximumNumber;

public abstract class ThirdMaximumNumberTestsBase<T> where T : IThirdMaximumNumber, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 1 }, 1)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 1, 1, 2 }, 2)]
    [DataRow(new[] { 2, 2, 3, 1 }, 1)]
    [DataRow(new[] { 2, 2, 3, 1 }, 1)]
    [DataRow(new[] { 14 }, 14)]
    [DataRow(new[] { 1, 2, int.MinValue }, int.MinValue)]
    [DataRow(new[] { 1, int.MinValue, 2 }, int.MinValue)]
    public void ThirdMax_WithIntArray_ReturnsThirdMaximumOrMaximum(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ThirdMax(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}