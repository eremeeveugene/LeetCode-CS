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