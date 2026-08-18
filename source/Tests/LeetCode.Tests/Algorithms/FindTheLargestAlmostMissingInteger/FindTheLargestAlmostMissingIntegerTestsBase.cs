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

using LeetCode.Algorithms.FindTheLargestAlmostMissingInteger;

namespace LeetCode.Tests.Algorithms.FindTheLargestAlmostMissingInteger;

public abstract class FindTheLargestAlmostMissingIntegerTestsBase<T> where T : IFindTheLargestAlmostMissingInteger, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 9, 2, 1, 7 }, 3, 7)]
    [DataRow(new[] { 3, 9, 7, 2, 1, 7 }, 4, 3)]
    [DataRow(new[] { 0, 0 }, 1, -1)]
    [DataRow(new[] { 5, 5, 4, 3, 3 }, 1, 4)]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { 5, 5, 3 }, 3, 5)]
    [DataRow(new[] { 5, 2, 4, 3 }, 2, 5)]
    [DataRow(new[] { 5, 2, 4, 5 }, 2, -1)]
    [DataRow(new[] { 1, 2, 4, 3, 3 }, 3, 1)]
    [DataRow(new[] { 1, 1, 4, 3, 5 }, 3, 5)]
    [DataRow(new[] { 0, 1, 1 }, 1, 0)]
    [DataRow(new[] { 0, 1, 2 }, 1, 2)]
    [DataRow(new[] { 50, 49, 50 }, 1, 49)]
    [DataRow(new[] { 2, 2, 3, 3 }, 1, -1)]
    [DataRow(new[] { 1, 4, 4, 2 }, 4, 4)]
    [DataRow(new[] { 0, 50, 25 }, 3, 50)]
    [DataRow(new[] { 0, 1, 2 }, 2, 2)]
    [DataRow(new[] { 2, 1, 2, 3 }, 2, 3)]
    [DataRow(new[] { 4, 1, 2, 4, 3 }, 4, 3)]
    [DataRow(new[] { 50, 0, 1, 2, 49 }, 3, 50)]
    public void LargestInteger_WithArrayAndSubarraySize_ReturnsLargestAlmostMissingInteger(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestInteger(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}