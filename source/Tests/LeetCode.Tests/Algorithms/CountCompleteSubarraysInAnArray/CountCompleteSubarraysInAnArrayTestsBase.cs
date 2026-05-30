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