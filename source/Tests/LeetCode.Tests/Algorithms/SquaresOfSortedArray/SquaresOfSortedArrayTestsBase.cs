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

using LeetCode.Algorithms.SquaresOfSortedArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SquaresOfSortedArray;

public abstract class SquaresOfSortedArrayTestsBase<T> where T : ISquaresOfSortedArray, new()
{
    [TestMethod]
    [DataRow("[-4,-1,0,3,10]", "[0,1,9,16,100]")]
    [DataRow("[-7,-3,2,3,11]", "[4,9,9,49,121]")]
    public void SortedSquares_GivenArrayOfIntegers_ReturnsSortedArrayOfSquares(string numsJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.SortedSquares(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}