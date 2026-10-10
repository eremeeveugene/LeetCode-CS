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

using LeetCode.Algorithms.LargestCombinationWithBitwiseANDGreaterThanZero;

namespace LeetCode.Tests.Algorithms.LargestCombinationWithBitwiseANDGreaterThanZero;

public abstract class LargestCombinationWithBitwiseANDGreaterThanZeroTestsBase<T> where T : ILargestCombinationWithBitwiseANDGreaterThanZero, new()
{
    [TestMethod]
    [DataRow(new[] { 16, 17, 71, 62, 12, 24, 14 }, 4)]
    [DataRow(new[] { 8, 8 }, 2)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 1, 1 }, 2)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 1, 2, 3 }, 2)]
    [DataRow(new[] { 7, 7, 7 }, 3)]
    [DataRow(new[] { 10000000 }, 1)]
    [DataRow(new[] { 10000000, 10000000, 1 }, 2)]
    [DataRow(new[] { 3, 5, 6 }, 2)]
    [DataRow(new[] { 1, 2, 4, 8, 16, 32 }, 1)]
    [DataRow(new[] { 255, 255, 1 }, 3)]
    [DataRow(new[] { 1, 3, 7, 15, 31, 63 }, 6)]
    [DataRow(new[] { 8388608, 8388608, 4194304 }, 2)]
    [DataRow(new[] { 9999999, 8388607, 5000000 }, 3)]
    [DataRow(new[] { 5, 10, 5, 10, 5, 10, 5 }, 4)]
    [DataRow(new[] { 1023, 512, 256, 128 }, 2)]
    [DataRow(new[] { 1, 1, 1, 1, 2, 2, 2 }, 4)]
    [DataRow(new[] { 10000000, 6, 12 }, 2)]
    [DataRow(new[] { 8388608, 8388609, 4194304 }, 2)]
    public void LargestCombination_GivenCandidatesArray_ReturnsMaxCombinationSize(int[] candidates, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestCombination(candidates);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}