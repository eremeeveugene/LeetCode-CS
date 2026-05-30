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

using LeetCode.Algorithms.NumberOfZeroFilledSubarrays;

namespace LeetCode.Tests.Algorithms.NumberOfZeroFilledSubarrays;

public abstract class NumberOfZeroFilledSubarraysTestsBase<T> where T : INumberOfZeroFilledSubarrays, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 0, 0, 2, 0, 0, 4 }, 6L)]
    [DataRow(new[] { 0, 0, 0, 2, 0, 0 }, 9L)]
    [DataRow(new[] { 2, 10, 2019 }, 0L)]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, 15L)]
    public void ZeroFilledSubarray_WithNumsArray_ReturnsCountOfZeroFilledSubarrays(int[] nums, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ZeroFilledSubarray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}