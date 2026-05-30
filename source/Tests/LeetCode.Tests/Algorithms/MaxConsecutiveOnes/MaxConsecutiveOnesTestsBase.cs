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

using LeetCode.Algorithms.MaxConsecutiveOnes;

namespace LeetCode.Tests.Algorithms.MaxConsecutiveOnes;

public abstract class MaxConsecutiveOnesTestsBase<T> where T : IMaxConsecutiveOnes, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 0, 1, 1, 1 }, 3)]
    [DataRow(new[] { 1, 0, 1, 1, 0, 1 }, 2)]
    public void FindMaxConsecutiveOnes_WithBinaryArray_ReturnsMaximumCountOfConsecutiveOnes(int[] nums,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}