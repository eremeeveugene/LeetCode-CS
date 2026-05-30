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

using LeetCode.Algorithms.MinimumPairRemovalToSortArray1;

namespace LeetCode.Tests.Algorithms.MinimumPairRemovalToSortArray1;

public abstract class MinimumPairRemovalToSortArray1TestsBase<T> where T : IMinimumPairRemovalToSortArray1, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 2, 3, 1 }, 2)]
    [DataRow(new[] { 1, 2, 2 }, 0)]
    [DataRow(new[] { 2, 2, -1, 3, -2, 2, 1, 1, 1, 0, -1 }, 9)]
    public void MinimumPairRemoval_WithUnsortedArray_ReturnsMinimumNumberOfOperationsNeededToSort(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumPairRemoval(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}