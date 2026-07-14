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

using LeetCode.Algorithms.RemoveDuplicatesFromSortedArray2;

namespace LeetCode.Tests.Algorithms.RemoveDuplicatesFromSortedArray2;

public abstract class RemoveDuplicatesFromSortedArray2TestsBase<T> where T : IRemoveDuplicatesFromSortedArray2, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 1, 2, 2, 3 }, 5, new[] { 1, 1, 2, 2, 3 })]
    [DataRow(new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, 7, new[] { 0, 0, 1, 1, 2, 3, 3 })]
    [DataRow(new[] { 1 }, 1, new[] { 1 })]
    [DataRow(new[] { 1, 1 }, 2, new[] { 1, 1 })]
    [DataRow(new[] { 1, 1, 1 }, 2, new[] { 1, 1 })]
    [DataRow(new[] { 1, 2 }, 2, new[] { 1, 2 })]
    [DataRow(new[] { 1, 1, 2, 2 }, 4, new[] { 1, 1, 2, 2 })]
    [DataRow(new[] { 1, 1, 1, 1 }, 2, new[] { 1, 1 })]
    [DataRow(new[] { -3, -3, -2, -1, -1, -1 }, 5, new[] { -3, -3, -2, -1, -1 })]
    [DataRow(new[] { 0, 0, 0, 0 }, 2, new[] { 0, 0 })]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3, 3 }, 6, new[] { 1, 1, 2, 2, 3, 3 })]
    [DataRow(new[] { -1, -1, -1, 0, 0, 1, 1, 1 }, 6, new[] { -1, -1, 0, 0, 1, 1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 }, 6, new[] { 1, 1, 2, 2, 3, 3 })]
    [DataRow(new[] { 0, 0, 1 }, 3, new[] { 0, 0, 1 })]
    [DataRow(new[] { 0, 1, 1, 1, 2 }, 4, new[] { 0, 1, 1, 2 })]
    [DataRow(new[] { -5, -5, -5, -4 }, 3, new[] { -5, -5, -4 })]
    [DataRow(new[] { 1, 1, 2, 3, 3, 3, 4, 5, 5 }, 8, new[] { 1, 1, 2, 3, 3, 4, 5, 5 })]
    public void RemoveDuplicates_WithSortedArray_ReturnsNewLengthAndModifiesArrayCorrectly(int[] nums, int expectedResult, int[] expectedNums)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveDuplicates(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        Assert.AreSequenceEqual(expectedNums, nums.Take(expectedResult).ToArray());
    }
}