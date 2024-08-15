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

using LeetCode.Algorithms.FindKthSmallestPairDistance;

namespace LeetCode.Tests.Algorithms.FindKthSmallestPairDistance;

public abstract class FindKthSmallestPairDistanceTestsBase<T> where T : IFindKthSmallestPairDistance, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 1 }, 1, 0)]
    [DataRow(new[] { 1, 1, 1 }, 2, 0)]
    [DataRow(new[] { 1, 6, 1 }, 3, 5)]
    public void SmallestDistancePair_GivenArrayAndK_ReturnsExpectedDistance(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestDistancePair(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}