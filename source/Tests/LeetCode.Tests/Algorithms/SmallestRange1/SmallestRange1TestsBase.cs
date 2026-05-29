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

using LeetCode.Algorithms.SmallestRange1;

namespace LeetCode.Tests.Algorithms.SmallestRange1;

public abstract class SmallestRange1TestsBase<T> where T : ISmallestRange1, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, 0, 0)]
    [DataRow(new[] { 0, 10 }, 2, 6)]
    [DataRow(new[] { 1, 3, 6 }, 3, 0)]
    public void SmallestRangeI_WithArrayAndAdjustmentLimit_ReturnsMinimumPossibleScore(int[] nums, int k,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestRangeI(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}
