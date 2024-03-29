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

using LeetCode.Algorithms.CountSubarraysWhereMaxElementAppearsAtLeastKTimes;

namespace LeetCode.Tests.Algorithms.CountSubarraysWhereMaxElementAppearsAtLeastKTimes;

public abstract class CountSubarraysWhereMaxElementAppearsAtLeastKTimesTestsBase<T>
    where T : ICountSubarraysWhereMaxElementAppearsAtLeastKTimes, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 2, 3, 3 }, 2, 6)]
    [DataRow(new[] { 1, 4, 2, 1 }, 3, 0)]
    public void CountSubarrays_GivenArrayAndThreshold_ReturnsExpectedCount(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSubarrays(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}