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

using LeetCode.Algorithms.MergeSortedArray;

namespace LeetCode.Tests.Algorithms.MergeSortedArray;

public abstract class MergeSortedArrayTestsBase<T> where T : IMergeSortedArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
    [DataRow(new[] { 1 }, 1, new int[] { }, 0, new[] { 1 })]
    [DataRow(new[] { 0 }, 0, new[] { 1 }, 1, new[] { 1 })]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, 0, new[] { 1, 2, 3, 4, 5 }, 5, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 0, 0 }, 0, new[] { 1, 2 }, 2, new[] { 1, 2 })]
    [DataRow(new[] { 5 }, 1, new int[] { }, 0, new[] { 5 })]
    [DataRow(new[] { 1, 0 }, 1, new[] { 1 }, 1, new[] { 1, 1 })]
    [DataRow(new[] { 2, 0 }, 1, new[] { 1 }, 1, new[] { 1, 2 })]
    [DataRow(new[] { 1, 3, 5, 0, 0, 0 }, 3, new[] { 2, 4, 6 }, 3, new[] { 1, 2, 3, 4, 5, 6 })]
    [DataRow(new[] { 4, 5, 6, 0, 0, 0 }, 3, new[] { 1, 2, 3 }, 3, new[] { 1, 2, 3, 4, 5, 6 })]
    [DataRow(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 4, 5, 6 }, 3, new[] { 1, 2, 3, 4, 5, 6 })]
    [DataRow(new[] { -1, 0, 0, 0, 0 }, 3, new[] { -3, -2 }, 2, new[] { -3, -2, -1, 0, 0 })]
    [DataRow(new[] { 0, 0, 0, 0 }, 2, new[] { 0, 0 }, 2, new[] { 0, 0, 0, 0 })]
    [DataRow(new[] { -1000000000, 1000000000, 0 }, 2, new[] { 0 }, 1, new[] { -1000000000, 0, 1000000000 })]
    [DataRow(new[] { 1, 1, 1, 0, 0, 0 }, 3, new[] { 1, 1, 1 }, 3, new[] { 1, 1, 1, 1, 1, 1 })]
    [DataRow(new[] { 2, 4, 0, 0, 0, 0 }, 2, new[] { 1, 3, 5, 7 }, 4, new[] { 1, 2, 3, 4, 5, 7 })]
    [DataRow(new[] { 1, 3, 5, 7, 0, 0 }, 4, new[] { 2, 4 }, 2, new[] { 1, 2, 3, 4, 5, 7 })]
    [DataRow(new[] { -5, -3, -1, 0, 0, 0 }, 3, new[] { -4, -2, 0 }, 3, new[] { -5, -4, -3, -2, -1, 0 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0 }, 10, new[] { 5 }, 1, new[] { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10 })]
    [DataRow(new[] { 10, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
    public void Merge_WithTwoArraysAndSizes_MergesAndSortsIntoFirstArray(int[] nums1, int m, int[] nums2, int n, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        solution.Merge(nums1, m, nums2, n);

        // Assert
        Assert.AreSequenceEqual(expectedResult, nums1);
    }
}