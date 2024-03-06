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

using LeetCode.Algorithms.MajorityElement;

namespace LeetCode.Tests.Algorithms.MajorityElement;

public abstract class MajorityElementTestsBase<T> where T : IMajorityElement, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 3 }, 3)]
    [DataRow(new[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    public void MajorityElement_WithIntegerArray_ReturnsMajorityElement(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MajorityElement(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}