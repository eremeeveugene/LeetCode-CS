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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MergeSortedArray;

public abstract class MergeSortedArrayTestsBase<T> where T : IMergeSortedArray, new()
{
    [TestMethod]
    [DataRow("[1,2,3,0,0,0]", 3, "[2,5,6]", 3, "[1,2,2,3,5,6]")]
    [DataRow("[1]", 1, "[]", 0, "[1]")]
    [DataRow("[0]", 0, "[1]", 1, "[1]")]
    [DataRow("[0,0,0,0,0]", 0, "[1,2,3,4,5]", 5, "[1,2,3,4,5]")]
    public void Merge_WithTwoArraysAndSizes_MergesAndSortsIntoFirstArray(string nums1Json, int m,
        string nums2Json, int n, string expectedResultJson)
    {
        // Arrange
        var nums1 = JsonHelper<int[]>.Parse(nums1Json);
        var nums2 = JsonHelper<int[]>.Parse(nums2Json);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        solution.Merge(nums1, m, nums2, n);

        // Assert
        CollectionAssert.AreEqual(expectedResult, nums1);
    }
}