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

using LeetCode.Algorithms.FindScoreOfAnArrayAfterMarkingAllElements;

namespace LeetCode.Tests.Algorithms.FindScoreOfAnArrayAfterMarkingAllElements;

public abstract class FindScoreOfAnArrayAfterMarkingAllElements1<T> where T : IFindScoreOfAnArrayAfterMarkingAllElements, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1, 3, 4, 5, 2 }, 7L)]
    [DataRow(new[] { 2, 3, 5, 1, 3, 2 }, 5L)]
    [DataRow(new[] { 1 }, 1L)]
    [DataRow(new[] { 5 }, 5L)]
    [DataRow(new[] { 1, 1 }, 1L)]
    [DataRow(new[] { 2, 1 }, 1L)]
    [DataRow(new[] { 1, 2, 3 }, 4L)]
    [DataRow(new[] { 3, 2, 1 }, 4L)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 3L)]
    [DataRow(new[] { 5, 5, 5, 5 }, 10L)]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, 3L)]
    [DataRow(new[] { 10, 1, 10 }, 1L)]
    [DataRow(new[] { 1000000, 1000000, 1000000 }, 2000000L)]
    [DataRow(new[] { 4, 3, 2, 1 }, 4L)]
    [DataRow(new[] { 1, 3, 5, 7, 9, 2, 4, 6, 8 }, 14L)]
    [DataRow(new[] { 2, 2, 3, 3, 1, 1 }, 6L)]
    [DataRow(new[] { 7, 7, 1, 7, 7 }, 15L)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 25L)]
    [DataRow(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 25L)]
    [DataRow(new[] { 1, 3, 2, 4, 2 }, 5L)]
    public void FindScore_WithIntegerArray_ReturnsScore(int[] nums, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindScore(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}