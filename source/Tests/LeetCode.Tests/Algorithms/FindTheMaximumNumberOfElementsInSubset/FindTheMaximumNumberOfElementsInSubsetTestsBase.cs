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

using LeetCode.Algorithms.FindTheMaximumNumberOfElementsInSubset;

namespace LeetCode.Tests.Algorithms.FindTheMaximumNumberOfElementsInSubset;

public abstract class FindTheMaximumNumberOfElementsInSubsetTestsBase<T> where T : IFindTheMaximumNumberOfElementsInSubset, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 4, 1, 2, 2 }, 3)]
    [DataRow(new[] { 1, 3, 2, 4 }, 1)]
    [DataRow(new[] { 2, 2 }, 1)]
    [DataRow(new[] { 3, 9, 3 }, 3)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 1, 1 }, 3)]
    [DataRow(new[] { 1, 1, 1, 1 }, 3)]
    [DataRow(new[] { 2, 4, 2 }, 3)]
    [DataRow(new[] { 2, 4, 16, 4, 2 }, 5)]
    [DataRow(new[] { 3, 3, 3 }, 1)]
    [DataRow(new[] { 10 }, 1)]
    [DataRow(new[] { 2, 2, 2, 2, 4, 4 }, 3)]
    [DataRow(new[] { 5, 5 }, 1)]
    [DataRow(new[] { 3, 9, 9, 3 }, 3)]
    [DataRow(new[] { 7, 7, 49, 49, 7, 7 }, 3)]
    [DataRow(new[] { 2, 2, 4, 4, 16, 16, 256 }, 7)]
    [DataRow(new[] { 4, 2, 2 }, 3)]
    [DataRow(new[] { 6, 6, 6, 6 }, 1)]
    [DataRow(new[] { 1, 1, 2, 2, 4 }, 3)]
    [DataRow(new[] { 1000000000 }, 1)]
    [DataRow(new[] { 3, 3, 9 }, 3)]
    [DataRow(new[] { 1, 1, 1, 5 }, 3)]
    public void MaximumLength_WithInputNums_ReturnsMaximumSubsetSize(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumLength(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}