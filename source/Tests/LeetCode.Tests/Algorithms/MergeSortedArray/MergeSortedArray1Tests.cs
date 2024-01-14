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

using LeetCode.Algorithms.MergeSortedArray;

namespace LeetCode.Tests.Algorithms.MergeSortedArray;

[TestClass]
public class MergeSortedArray1Tests
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
    [DataRow(new[] { 1 }, 1, new int[] { }, 0, new[] { 1 })]
    [DataRow(new[] { 0 }, 0, new[] { 1 }, 1, new[] { 1 })]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, 0, new[] { 1, 2, 3, 4, 5 }, 5, new[] { 1, 2, 3, 4, 5 })]
    public void Test(int[] nums1, int m, int[] nums2, int n, int[] expectedResult)
    {
        // Act
        MergeSortedArray1.Merge(nums1, m, nums2, n);

        // Assert
        CollectionAssert.AreEqual(expectedResult, nums1);
    }
}