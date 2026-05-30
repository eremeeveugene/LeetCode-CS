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

using LeetCode.Algorithms.SumOfElementsWithFrequencyDivisibleByK;

namespace LeetCode.Tests.Algorithms.SumOfElementsWithFrequencyDivisibleByK;

public abstract class SumOfElementsWithFrequencyDivisibleByKTestsBAse<T>
    where T : ISumOfElementsWithFrequencyDivisibleByK, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3, 3, 4 }, 2, 16)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, 0)]
    [DataRow(new[] { 4, 4, 4, 1, 2, 3 }, 3, 12)]
    public void SumDivisibleByK_WithNumsAndDivisorK_ReturnsSumOfElementsWithFrequencyDivisibleByK(int[] nums,
        int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumDivisibleByK(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}