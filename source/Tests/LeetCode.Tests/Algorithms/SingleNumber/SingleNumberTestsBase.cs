// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.SingleNumber;

namespace LeetCode.Tests.Algorithms.SingleNumber;

public abstract class SingleNumberTestsBase<T> where T : ISingleNumber, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 2, 1 }, 1)]
    [DataRow(new[] { 4, 1, 2, 1, 2 }, 4)]
    [DataRow(new[] { 1 }, 1)]
    public void SingleNumber_WithIntegerArray_ReturnsSingleNumber(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SingleNumber(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}