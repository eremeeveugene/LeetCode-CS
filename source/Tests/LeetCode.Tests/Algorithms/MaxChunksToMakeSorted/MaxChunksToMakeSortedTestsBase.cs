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

using LeetCode.Algorithms.MaxChunksToMakeSorted;

namespace LeetCode.Tests.Algorithms.MaxChunksToMakeSorted;

public abstract class MaxChunksToMakeSortedTestsBase<T> where T : IMaxChunksToMakeSorted, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 3, 2, 1, 0 }, 1)]
    [DataRow(new[] { 1, 0, 2, 3, 4 }, 4)]
    [DataRow(new[] { 0 }, 1)]
    [DataRow(new[] { 1, 0 }, 1)]
    [DataRow(new[] { 0, 1 }, 2)]
    [DataRow(new[] { 0, 1, 2 }, 3)]
    [DataRow(new[] { 2, 1, 0 }, 1)]
    [DataRow(new[] { 1, 2, 0 }, 1)]
    [DataRow(new[] { 2, 0, 1 }, 1)]
    [DataRow(new[] { 0, 2, 1 }, 2)]
    [DataRow(new[] { 1, 0, 3, 2 }, 2)]
    [DataRow(new[] { 3, 2, 1, 0 }, 1)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5 }, 6)]
    [DataRow(new[] { 5, 4, 3, 2, 1, 0 }, 1)]
    [DataRow(new[] { 1, 0, 2, 4, 3 }, 3)]
    [DataRow(new[] { 2, 0, 1, 4, 3, 5 }, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 0 }, 1)]
    [DataRow(new[] { 0, 2, 1, 4, 3, 6, 5, 8, 7, 9 }, 6)]
    [DataRow(new[] { 2, 3, 5, 0, 1, 4 }, 1)]
    [DataRow(new[] { 0, 3, 2, 4, 5, 6, 1 }, 2)]
    [DataRow(new[] { 1, 3, 0, 5, 7, 2, 4, 6 }, 1)]
    [DataRow(new[] { 7, 4, 8, 1, 2, 5, 3, 6, 0 }, 1)]
    [DataRow(new[] { 5, 1, 3, 6, 0, 7, 9, 4, 8, 2 }, 1)]
    [DataRow(new[] { 9, 0, 8, 4, 6, 5, 1, 7, 2, 3 }, 1)]
    public void MaxChunksToSorted_WithUnsortedArray_ReturnsMaximumNumberOfChunks(int[] arr, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxChunksToSorted(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}