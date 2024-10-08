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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.AddToArrayFormOfInteger;

public abstract class AddToArrayFormOfIntegerTestsBase<T> where T : IAddToArrayFormOfInteger, new()
{
    [TestMethod]
    [DataRow("[1, 2, 0, 0]", 34, "[1, 2, 3, 4]")]
    [DataRow("[2, 7, 4]", 181, "[4, 5, 5]")]
    [DataRow("[2, 1, 5]", 806, "[1, 0, 2, 1]")]
    public void AddToArrayForm_WithArrayAndInteger_ReturnsSumAsArray(string numJsonArray, int k,
        string expectedResultJsonArray)
    {
        // Arrange
        var solution = new T();

        var num = JsonHelper<int>.DeserializeToArray(numJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        // Act
        var actualResult = solution.AddToArrayForm(num, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}