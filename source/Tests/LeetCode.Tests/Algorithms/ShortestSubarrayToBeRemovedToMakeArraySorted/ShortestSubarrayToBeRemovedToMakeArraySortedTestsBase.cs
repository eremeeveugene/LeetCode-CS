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

using LeetCode.Algorithms.ShortestSubarrayToBeRemovedToMakeArraySorted;

namespace LeetCode.Tests.Algorithms.ShortestSubarrayToBeRemovedToMakeArraySorted;

public abstract class ShortestSubarrayToBeRemovedToMakeArraySortedTestsBase<T> where T : IShortestSubarrayToBeRemovedToMakeArraySorted, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 10, 4, 2, 3, 5 }, 3)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 4)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(new[] { 1, 2, 3, 100, 4, 5, 150 }, 1)]
    [DataRow(new[] { 1, 3, 2, 4, 5 }, 1)]
    [DataRow(new[] { 5, 4, 3, 2, 1, 0 }, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 1 }, 1)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 3, 2, 1 }, 2)]
    [DataRow(new[] { 1, 1, 1, 1 }, 0)]
    [DataRow(new[] { 1, 2, 10, 3, 4, 5 }, 1)]
    [DataRow(new[] { 9, 1, 2, 3, 4, 5 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 9, 1 }, 1)]
    [DataRow(new[] { 1, 5, 2, 3, 4, 5 }, 1)]
    [DataRow(new[] { 1, 2, 3, 5, 4, 6, 7 }, 1)]
    [DataRow(new[] { 10, 9, 8, 7, 6, 5 }, 5)]
    [DataRow(new[] { 1, 2, 3, 2, 1, 2, 3 }, 3)]
    [DataRow(new[] { 5, 1, 2, 3, 4 }, 1)]
    [DataRow(new[] { 1, 4, 2, 3, 5 }, 1)]
    [DataRow(new[] { 1, 2, 5, 3, 4, 5, 6 }, 1)]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1, 7 }, 5)]
    [DataRow(new[] { 1, 3, 5, 2, 4, 6 }, 2)]
    public void FindLengthOfShortestSubarray_GivenArray_ReturnsLengthOfShortestToBeRemoved(int[] arr, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindLengthOfShortestSubarray(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}