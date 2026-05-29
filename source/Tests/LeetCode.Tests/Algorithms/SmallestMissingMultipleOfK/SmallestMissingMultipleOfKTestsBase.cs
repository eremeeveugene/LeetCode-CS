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

using LeetCode.Algorithms.SmallestMissingMultipleOfK;

namespace LeetCode.Tests.Algorithms.SmallestMissingMultipleOfK;

public abstract class SmallestMissingMultipleOfKTestsBase<T>
    where T : ISmallestMissingMultipleOfK, new()
{
    [TestMethod]
    [DataRow(new[] { 8, 2, 3, 4, 6 }, 2, 10)]
    [DataRow(new[] { 1, 4, 7, 10, 15 }, 5, 5)]
    public void MissingMultiple_WithArrayAndMultipleK_ReturnsSmallestMissingPositiveMultipleOfK(int[] nums, int k,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MissingMultiple(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}
