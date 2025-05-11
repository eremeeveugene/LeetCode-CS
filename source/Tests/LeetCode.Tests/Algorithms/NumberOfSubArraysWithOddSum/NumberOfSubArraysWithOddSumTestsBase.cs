// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.NumberOfSubArraysWithOddSum;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.NumberOfSubArraysWithOddSum;

public abstract class NumberOfSubArraysWithOddSumTestsBase<T> where T : INumberOfSubArraysWithOddSum, new()
{
    [TestMethod]
    [DataRow("[1,3,5]", 4)]
    [DataRow("[2,4,6]", 0)]
    [DataRow("[1,2,3,4,5,6,7]", 16)]
    public void NumOfSubarrays_WithGivenArray_ReturnsCountOfOddSumSubarrays(string arrJson, int expectedResult)
    {
        // Arrange
        var arr = JsonHelper<int[]>.Parse(arrJson);

        var solution = new T();

        // Act
        var actualResult = solution.NumOfSubarrays(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}