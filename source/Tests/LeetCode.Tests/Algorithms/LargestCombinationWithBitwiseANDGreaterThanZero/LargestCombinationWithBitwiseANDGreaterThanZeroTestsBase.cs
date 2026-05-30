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

public abstract class LargestCombinationWithBitwiseANDGreaterThanZeroTestsBase<T>
    where T : ILargestCombinationWithBitwiseANDGreaterThanZero, new()
{
    [TestMethod]
    [DataRow(new[] { 16, 17, 71, 62, 12, 24, 14 }, 4)]
    [DataRow(new[] { 8, 8 }, 2)]
    public void LargestCombination_GivenCandidatesArray_ReturnsMaxCombinationSize(int[] candidates,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestCombination(candidates);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}