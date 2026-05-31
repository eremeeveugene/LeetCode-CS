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

using LeetCode.Algorithms.ContinuousSubarrays;

namespace LeetCode.Tests.Algorithms.ContinuousSubarrays;

public abstract class ContinuousSubarraysTestsBase<T> where T : IContinuousSubarrays, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 4, 2, 4 }, 8L)]
    [DataRow(new[] { 1, 2, 3 }, 6L)]
    [DataRow(new[] { 1 }, 1L)]
    [DataRow(new[] { 5, 5 }, 3L)]
    [DataRow(new[] { 1, 1, 1 }, 6L)]
    [DataRow(new[] { 1, 3 }, 3L)]
    [DataRow(new[] { 1, 4 }, 2L)]
    [DataRow(new[] { 1, 10, 100 }, 3L)]
    [DataRow(new[] { 3, 3, 3, 3 }, 10L)]
    [DataRow(new[] { 1, 2, 2, 1 }, 10L)]
    [DataRow(new[] { 0, 0, 0 }, 6L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 12L)]
    [DataRow(new[] { 10, 8, 6 }, 3L)]
    [DataRow(new[] { 2, 2 }, 3L)]
    [DataRow(new[] { 1, 3, 5, 7 }, 5L)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 7L)]
    [DataRow(new[] { 100, 100 }, 3L)]
    [DataRow(new[] { 1, 2, 4, 8 }, 4L)]
    public void ContinuousSubarrays_GivenArrayOfIntegers_ReturnsCountOfValidSubarrays(int[] nums, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ContinuousSubarrays(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}