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

using LeetCode.Algorithms.CountNumberOfBadPairs;

namespace LeetCode.Tests.Algorithms.CountNumberOfBadPairs;

public abstract class CountNumberOfBadPairsTestsBase<T> where T : ICountNumberOfBadPairs, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 1, 3, 3 }, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0)]
    public void CountBadPairs_GivenArray_ReturnsCountOfBadPairs(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountBadPairs(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}