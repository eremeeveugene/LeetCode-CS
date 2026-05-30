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

using LeetCode.Algorithms.CountEqualAndDivisiblePairsInAnArray;

namespace LeetCode.Tests.Algorithms.CountEqualAndDivisiblePairsInAnArray;

public abstract class CountEqualAndDivisiblePairsInAnArrayTestsBase<T> where T : ICountEqualAndDivisiblePairsInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 1, 2, 2, 2, 1, 3 }, 2, 4)]
    [DataRow(new[] { 1, 2, 3, 4 }, 1, 0)]
    public void CountPairs_WithEqualElementsAndIndexProductDivisibleByK_ReturnsTheNumberOfPairs(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountPairs(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}