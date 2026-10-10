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

using LeetCode.Algorithms.CountCompleteSubarraysInAnArray;

namespace LeetCode.Tests.Algorithms.CountCompleteSubarraysInAnArray;

public abstract class CountCompleteSubarraysInAnArrayTestsBase<T> where T : ICountCompleteSubarraysInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 1, 2, 2 }, 4)]
    [DataRow(new[] { 5, 5, 5, 5 }, 10)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 2000 }, 1)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 2, 1 }, 1)]
    [DataRow(new[] { 1, 1, 1 }, 6)]
    [DataRow(new[] { 1, 2, 3 }, 1)]
    [DataRow(new[] { 3, 2, 1, 2, 3 }, 5)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 15)]
    [DataRow(new[] { 1000, 1000, 1000, 1000, 1000, 1000 }, 21)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1)]
    [DataRow(new[] { 5, 4, 3, 2, 1, 1 }, 2)]
    [DataRow(new[] { 7, 7, 8, 8, 9, 9 }, 4)]
    [DataRow(new[] { 1, 1, 2, 1, 1 }, 8)]
    [DataRow(new[] { 2000, 1, 2000, 1, 2000 }, 10)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 }, 28)]
    [DataRow(new[] { 10, 20, 10, 30, 20, 10 }, 9)]
    [DataRow(new[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 }, 55)]
    [DataRow(new[] { 1, 2, 2, 2, 2, 2, 1 }, 11)]
    public void CountCompleteSubarrays_WithGivenArray_ReturnsNumberOfCompleteSubarrays(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountCompleteSubarrays(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}