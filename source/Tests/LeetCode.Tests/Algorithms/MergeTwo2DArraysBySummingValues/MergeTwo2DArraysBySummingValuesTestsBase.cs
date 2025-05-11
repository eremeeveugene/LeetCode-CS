// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MergeTwo2DArraysBySummingValues;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.MergeTwo2DArraysBySummingValues;

public abstract class MergeTwo2DArraysBySummingValuesTestsBase<T> where T : IMergeTwo2DArraysBySummingValues, new()
{
    [TestMethod]
    [DataRow("[[1,2],[2,3],[4,5]]", "[[1,4],[3,2],[4,1]]", "[[1,6],[2,3],[3,2],[4,6]]")]
    [DataRow("[[2,4],[3,6],[5,5]]", "[[1,3],[4,3]]", "[[1,3],[2,4],[3,6],[4,3],[5,5]]")]
    public void MergeArrays_WithTwoJaggedArrays_ReturnsMergedArray(string nums1Json, string nums2Json,
        string expectedResultJson)
    {
        // Arrange
        var nums1 = JsonHelper<int>.DeserializeToJaggedArray(nums1Json);
        var nums2 = JsonHelper<int>.DeserializeToJaggedArray(nums2Json);
        var expectedResult = JsonHelper<int>.DeserializeToJaggedArray(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.MergeArrays(nums1, nums2);

        // Assert
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }
}