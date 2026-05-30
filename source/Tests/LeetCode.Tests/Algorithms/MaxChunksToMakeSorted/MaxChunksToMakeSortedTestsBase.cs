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
    public void MaxChunksToSorted_WithUnsortedArray_ReturnsMaximumNumberOfChunks(int[] arr,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxChunksToSorted(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}