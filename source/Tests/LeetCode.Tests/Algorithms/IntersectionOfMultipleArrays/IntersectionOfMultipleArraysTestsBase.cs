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

using LeetCode.Algorithms.IntersectionOfMultipleArrays;

namespace LeetCode.Tests.Algorithms.IntersectionOfMultipleArrays;

public abstract class IntersectionOfMultipleArraysTestsBase<T> where T : IIntersectionOfMultipleArrays, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Intersection_WithMultipleNumsArrays_ReturnsCommonElementsAcrossAllArrays(int[][] nums,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Intersection(nums).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 3, 1, 2, 4, 5 }, new[] { 1, 2, 3, 4 }, new[] { 3, 4, 5, 6 } }, new[] { 3, 4 }];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, Array.Empty<int>()];
    }
}