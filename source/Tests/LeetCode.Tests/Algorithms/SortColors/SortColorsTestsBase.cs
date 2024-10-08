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

using LeetCode.Algorithms.SortColors;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SortColors;

public abstract class SortColorsTestsBase<T> where T : ISortColors, new()
{
    [TestMethod]
    [DataRow("[2,0,2,1,1,0]", "[0,0,1,1,2,2]")]
    [DataRow("[2,0,1]", "[0,1,2]")]
    public void SortColors_WithUnsortedArray_ReturnsSortedArray(string numsJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        solution.SortColors(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, nums);
    }
}