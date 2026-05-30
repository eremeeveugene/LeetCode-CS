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

using LeetCode.Algorithms.MergeTwo2DArraysBySummingValues;

namespace LeetCode.Tests.Algorithms.MergeTwo2DArraysBySummingValues;

public abstract class MergeTwo2DArraysBySummingValuesTestsBase<T> where T : IMergeTwo2DArraysBySummingValues, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MergeArrays_WithTwoKeyValuePairArrays_ReturnsMergedArrayWithSummedValues(int[][] nums1, int[][] nums2, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MergeArrays(nums1, nums2);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 4, 5 } }, new[] { new[] { 1, 4 }, new[] { 3, 2 }, new[] { 4, 1 } }, new[] { new[] { 1, 6 }, new[] { 2, 3 }, new[] { 3, 2 }, new[] { 4, 6 } }];

        yield return [new[] { new[] { 2, 4 }, new[] { 3, 6 }, new[] { 5, 5 } }, new[] { new[] { 1, 3 }, new[] { 4, 3 } }, new[] { new[] { 1, 3 }, new[] { 2, 4 }, new[] { 3, 6 }, new[] { 4, 3 }, new[] { 5, 5 } }];
    }
}