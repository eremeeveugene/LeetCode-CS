// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.SortArrayByIncreasingFrequency;

namespace LeetCode.Tests.Algorithms.SortArrayByIncreasingFrequency;

public abstract class SortArrayByIncreasingFrequencyTestsBase<T> where T : ISortArrayByIncreasingFrequency, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 2, 2, 2, 3 }, new[] { 3, 1, 1, 2, 2, 2 })]
    [DataRow(new[] { 2, 3, 1, 3, 2 }, new[] { 1, 3, 3, 2, 2 })]
    [DataRow(new[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 }, new[] { 5, -1, 4, 4, -6, -6, 1, 1, 1 })]
    public void FrequencySort_GivenNumsArray_ReturnsArraySortedByFrequency(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FrequencySort(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}