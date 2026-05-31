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

using LeetCode.Algorithms.FindIfArrayCanBeSorted;

namespace LeetCode.Tests.Algorithms.FindIfArrayCanBeSorted;

public abstract class FindIfArrayCanBeSortedTestsBase<T> where T : IFindIfArrayCanBeSorted, new()
{
    [TestMethod]
    [DataRow(new[] { 8, 4, 2, 30, 15 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, true)]
    [DataRow(new[] { 3, 16, 8, 4, 2 }, false)]
    [DataRow(new[] { 1 }, true)]
    [DataRow(new[] { 2, 1 }, true)]
    [DataRow(new[] { 3, 2 }, false)]
    [DataRow(new[] { 5, 4, 5 }, false)]
    [DataRow(new[] { 4, 2 }, true)]
    [DataRow(new[] { 6, 5, 7 }, true)]
    [DataRow(new[] { 1, 1, 1 }, true)]
    [DataRow(new[] { 8, 4, 2, 16, 32 }, true)]
    [DataRow(new[] { 3, 6, 5 }, true)]
    [DataRow(new[] { 7, 7, 7 }, true)]
    [DataRow(new[] { 128, 64, 32 }, true)]
    [DataRow(new[] { 2, 3 }, true)]
    [DataRow(new[] { 14, 7, 3 }, false)]
    [DataRow(new[] { 5, 7, 11 }, true)]
    public void CanSortArray_WithUnsortedOrSortedArray_ReturnsIfArrayCanBeSorted(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanSortArray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}