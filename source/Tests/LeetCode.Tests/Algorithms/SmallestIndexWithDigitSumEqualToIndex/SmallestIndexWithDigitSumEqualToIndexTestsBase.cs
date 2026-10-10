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

using LeetCode.Algorithms.SmallestIndexWithDigitSumEqualToIndex;

namespace LeetCode.Tests.Algorithms.SmallestIndexWithDigitSumEqualToIndex;

public abstract class SmallestIndexWithDigitSumEqualToIndexTestsBase<T> where T : ISmallestIndexWithDigitSumEqualToIndex, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 2 }, 2)]
    [DataRow(new[] { 1, 10, 11 }, 1)]
    [DataRow(new[] { 1, 2, 3 }, -1)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { 1 }, -1)]
    [DataRow(new[] { 5, 1 }, 1)]
    [DataRow(new[] { 0, 5 }, 0)]
    [DataRow(new[] { 10, 1 }, 1)]
    [DataRow(new[] { 100, 1, 2 }, 1)]
    [DataRow(new[] { 1000, 999, 2, 3 }, 2)]
    [DataRow(new[] { 0, 0, 0, 0 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, -1)]
    [DataRow(new[] { 19, 28, 37, 46, 55, 64 }, -1)]
    [DataRow(new[] { 1, 1, 11 }, 1)]
    [DataRow(new[] { 999, 999, 999, 27 }, -1)]
    [DataRow(new[] { 5, 4, 3, 2, 1, 0 }, -1)]
    [DataRow(new[] { 1000, 1000, 1000, 1000, 1000, 1000 }, 1)]
    [DataRow(new[] { 3, 2, 1 }, -1)]
    [DataRow(new[] { 7, 6, 5, 4, 3, 2, 1, 0, 8, 9, 10, 11 }, 8)]
    [DataRow(new[] { 1, 10, 100, 1000 }, 1)]
    public void SmallestIndex_WithGivenArray_ReturnsCorrectIndexOrMinusOne(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestIndex(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}