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

using LeetCode.Algorithms.FindTheMaximumLengthOfValidSubsequence1;

namespace LeetCode.Tests.Algorithms.FindTheMaximumLengthOfValidSubsequence1;

public abstract class FindTheMaximumLengthOfValidSubsequence1TestsBase<T> where T : IFindTheMaximumLengthOfValidSubsequence1, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 1, 3 }, 2)]
    [DataRow(new[] { 1, 2, 1, 1, 2, 1, 2 }, 6)]
    public void MaximumLength_WithInputArray_ReturnsLengthOfLongestValidSubsequence(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumLength(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}