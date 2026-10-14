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

using LeetCode.Algorithms.CountSubarraysWhereMaxElementAppearsAtLeastKTimes;

namespace LeetCode.Tests.Algorithms.CountSubarraysWhereMaxElementAppearsAtLeastKTimes;

public abstract class CountSubarraysWhereMaxElementAppearsAtLeastKTimesTestsBase<T>
    where T : ICountSubarraysWhereMaxElementAppearsAtLeastKTimes, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 2, 3, 3 }, 2, 6)]
    [DataRow(new[] { 1, 4, 2, 1 }, 3, 0)]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { 1 }, 2, 0)]
    [DataRow(new[] { 5, 5 }, 1, 3)]
    [DataRow(new[] { 5, 5 }, 2, 1)]
    [DataRow(new[] { 5, 5 }, 3, 0)]
    [DataRow(new[] { 1, 2, 3 }, 1, 3)]
    [DataRow(new[] { 3, 2, 1 }, 1, 3)]
    [DataRow(new[] { 1, 3, 2, 3, 3 }, 3, 2)]
    [DataRow(new[] { 1, 3, 2, 3, 3 }, 1, 13)]
    [DataRow(new[] { 2, 2, 2, 2 }, 2, 6)]
    [DataRow(new[] { 2, 2, 2, 2 }, 4, 1)]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, 2, 4)]
    [DataRow(new[] { 7, 1, 7, 1, 7 }, 2, 5)]
    [DataRow(new[] { 4, 4, 1, 4 }, 3, 1)]
    [DataRow(new[] { 1000000, 1, 1000000 }, 2, 1)]
    [DataRow(new[] { 1, 1, 1, 5 }, 1, 4)]
    [DataRow(new[] { 5, 1, 1, 1 }, 1, 4)]
    [DataRow(new[] { 2, 3, 2, 3, 2, 3 }, 2, 8)]
    public void CountSubarrays_WithElementAndArray_ReturnsNumberOfValidSubarraysContainingElementK(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSubarrays(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}