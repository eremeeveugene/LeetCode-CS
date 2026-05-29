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

using LeetCode.Algorithms.NumberOfWaysToSplitArray;

namespace LeetCode.Tests.Algorithms.NumberOfWaysToSplitArray;

public abstract class NumberOfWaysToSplitArrayTestsBase<T> where T : INumberOfWaysToSplitArray, new()
{
    [TestMethod]
    [DataRow(new[] { 10, 4, -8, 7 }, 2)]
    [DataRow(new[] { 2, 3, 1, 0 }, 2)]
    public void WaysToSplitArray_WithIntegerArray_ReturnsNumberOfValidSplits(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.WaysToSplitArray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}
