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

using LeetCode.Algorithms.MaximumDistanceInArrays;

namespace LeetCode.Tests.Algorithms.MaximumDistanceInArrays;

public abstract class MaximumDistanceInArraysTestsBase<T> where T : IMaximumDistanceInArrays, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxDistance_WithSortedArrays_ReturnsMaximumAbsoluteDifferenceBetweenTwoArrays(int[][] arraysData, int expectedResult)
    {
        // Arrange
        var solution = new T();

        var arrays = arraysData.Cast<IList<int>>().ToList();

        // Act
        var actualResult = solution.MaxDistance(arrays);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1 }, new[] { 1 } }, 0];

        yield return [new[] { new[] { 1, 4 }, new[] { 0, 5 } }, 4];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5 }, new[] { 1, 2, 3 } }, 4];
    }
}