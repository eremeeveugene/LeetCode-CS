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

using LeetCode.Algorithms.ConstructTheMinimumBitwiseArray1;

namespace LeetCode.Tests.Algorithms.ConstructTheMinimumBitwiseArray1;

public abstract class ConstructTheMinimumBitwiseArray1TestsBase<T> where T : IConstructTheMinimumBitwiseArray1, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, 5, 7 }, new[] { -1, 1, 4, 3 })]
    [DataRow(new[] { 11, 13, 31 }, new[] { 9, 12, 15 })]
    [DataRow(new[] { 2 }, new[] { -1 })]
    [DataRow(new[] { 3 }, new[] { 1 })]
    [DataRow(new[] { 5 }, new[] { 4 })]
    [DataRow(new[] { 7 }, new[] { 3 })]
    [DataRow(new[] { 11 }, new[] { 9 })]
    [DataRow(new[] { 13 }, new[] { 12 })]
    [DataRow(new[] { 17, 19, 23 }, new[] { 16, 17, 19 })]
    [DataRow(new[] { 29, 31, 37 }, new[] { 28, 15, 36 })]
    [DataRow(new[] { 41, 43, 47 }, new[] { 40, 41, 39 })]
    [DataRow(new[] { 53 }, new[] { 52 })]
    [DataRow(new[] { 59, 61 }, new[] { 57, 60 })]
    [DataRow(new[] { 67, 71, 73 }, new[] { 65, 67, 72 })]
    [DataRow(new[] { 79, 89 }, new[] { 71, 88 })]
    [DataRow(new[] { 97, 101 }, new[] { 96, 100 })]
    [DataRow(new[] { 127 }, new[] { 63 })]
    [DataRow(new[] { 257 }, new[] { 256 })]
    [DataRow(new[] { 509, 521 }, new[] { 508, 520 })]
    [DataRow(new[] { 997 }, new[] { 996 })]
    [DataRow(new[] { 977 }, new[] { 976 })]
    [DataRow(new[] { 83, 251, 983 }, new[] { 81, 249, 979 })]
    [DataRow(new[] { 991, 607, 863 }, new[] { 975, 591, 847 })]
    [DataRow(new[] { 179, 367, 719 }, new[] { 177, 359, 711 })]
    public void MinBitwiseArray_WithPrimeNumbersArray_ReturnsArrayWithMinimizedBitwiseValuesOrNegativeOne(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinBitwiseArray(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}