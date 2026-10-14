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

using LeetCode.Algorithms.FindTheMaximumLengthOfValidSubsequence2;

namespace LeetCode.Tests.Algorithms.FindTheMaximumLengthOfValidSubsequence2;

public abstract class FindTheMaximumLengthOfValidSubsequence2TestsBase<T> where T : IFindTheMaximumLengthOfValidSubsequence2, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, 5)]
    [DataRow(new[] { 1, 4, 2, 3, 1, 4 }, 3, 4)]
    [DataRow(new[] { 1, 1 }, 1, 2)]
    [DataRow(new[] { 1, 2 }, 5, 2)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2, 4)]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, 3, 5)]
    [DataRow(new[] { 3, 6, 9, 12 }, 3, 4)]
    [DataRow(new[] { 1, 3, 5, 7 }, 2, 4)]
    [DataRow(new[] { 2, 4, 6, 8, 10 }, 4, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 3, 4)]
    [DataRow(new[] { 5, 5, 5 }, 10, 3)]
    [DataRow(new[] { 1000000000, 1, 1000000000 }, 7, 3)]
    [DataRow(new[] { 7, 3, 7, 3, 7 }, 10, 5)]
    [DataRow(new[] { 1, 4, 7, 10, 13 }, 3, 5)]
    [DataRow(new[] { 2, 3, 2, 3, 2, 3 }, 5, 6)]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 4, 5)]
    [DataRow(new[] { 1, 5, 2, 6, 3, 7, 4, 8 }, 6, 4)]
    [DataRow(new[] { 4, 4, 4, 4 }, 8, 4)]
    [DataRow(new[] { 10, 1, 9, 2, 8, 3 }, 11, 2)]
    [DataRow(new[] { 1, 2, 4, 8, 16, 32 }, 7, 4)]
    public void MaximumLength_WithIntegerArrayAndLimitK_ReturnsMaximumLengthUnderConstraint(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumLength(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}