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

using LeetCode.Algorithms.LargestNumberAtLeastTwiceOfOthers;

namespace LeetCode.Tests.Algorithms.LargestNumberAtLeastTwiceOfOthers;

public abstract class LargestNumberAtLeastTwiceOfOthersTestsBase<T> where T : ILargestNumberAtLeastTwiceOfOthers, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 6, 1, 0 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4 }, -1)]
    [DataRow(new[] { 0, 1 }, 1)]
    [DataRow(new[] { 1, 0 }, 0)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 1, 3 }, 1)]
    [DataRow(new[] { 2, 1 }, 0)]
    [DataRow(new[] { 100, 0, 50 }, 0)]
    [DataRow(new[] { 100, 0, 51 }, -1)]
    [DataRow(new[] { 0, 0, 0, 1 }, 3)]
    [DataRow(new[] { 1, 1, 2 }, 2)]
    [DataRow(new[] { 4, 2, 1, 0, 8 }, 4)]
    [DataRow(new[] { 50, 50, 100 }, 2)]
    [DataRow(new[] { 8, 3, 1, 4 }, 0)]
    [DataRow(new[] { 10, 5, 20 }, 2)]
    [DataRow(new[] { 0, 100 }, 1)]
    [DataRow(new[] { 1, 2, 3, 6 }, 3)]
    [DataRow(new[] { 7, 0, 3, 14, 5 }, 3)]
    [DataRow(new[] { 99, 100 }, -1)]
    [DataRow(new[] { 5, 0, 10, 2 }, 2)]
    public void DominantIndex_WithIntegerArrayContainingUniqueLargest_ReturnsIndexOfLargestElementOrMinusOne(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DominantIndex(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}