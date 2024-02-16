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

using LeetCode.Algorithms.RemoveDuplicatesFromSortedArray;

namespace LeetCode.Tests.Algorithms.RemoveDuplicatesFromSortedArray;

public abstract class RemoveDuplicatesFromSortedArrayTestsBase<T> where T : IRemoveDuplicatesFromSortedArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 2 }, 2, new[] { 1, 2 })]
    [DataRow(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new[] { 0, 1, 2, 3, 4 })]
    public void RemoveDuplicates_GivenSortedArray_ReturnsCountOfUniqueElements(int[] nums, int expectedResult,
        int[] expectedNums)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveDuplicates(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        CollectionAssert.AreEquivalent(expectedNums, nums.Take(actualResult).ToArray());
    }
}