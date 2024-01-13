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

using LeetCode.Algorithms.AddToArrayFormOfInteger;

namespace LeetCode.Tests.Algorithms.AddToArrayFormOfInteger;

[TestClass]
public class AddToArrayFormOfIntegerSummationTests
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 0, 0 }, 34, new[] { 1, 2, 3, 4 })]
    [DataRow(new[] { 2, 7, 4 }, 181, new[] { 4, 5, 5 })]
    [DataRow(new[] { 2, 1, 5 }, 806, new[] { 1, 0, 2, 1 })]
    public void AddToArrayFormOfIntegerSummation_ValidInput_ReturnsExpectedResult(int[] num, int k,
        int[] expectedResult)
    {
        // Act
        var actualResult = AddToArrayFormOfIntegerSummation.GetResult(num, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}