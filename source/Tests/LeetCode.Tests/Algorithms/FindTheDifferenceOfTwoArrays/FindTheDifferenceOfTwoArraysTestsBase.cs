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

using LeetCode.Algorithms.FindTheDifferenceOfTwoArrays;

namespace LeetCode.Tests.Algorithms.FindTheDifferenceOfTwoArrays;

public abstract class FindTheDifferenceOfTwoArraysTestsBase<T> where T : IFindTheDifferenceOfTwoArrays, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindDifference_WithTwoIntegerArrays_ReturnsUniqueElementsInEachArray(int[] nums1, int[] nums2, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDifference(nums1, nums2);

        // Assert
        Assert.AreEquivalent<IEnumerable<IEnumerable<int>>>(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 2, 3 }, new[] { 2, 4, 6 }, new[] { new[] { 1, 3 }, new[] { 4, 6 } }];

        yield return [new[] { 1, 2, 3, 3 }, new[] { 1, 1, 2, 2 }, new[] { new[] { 3 }, Array.Empty<int>() }];
    }
}