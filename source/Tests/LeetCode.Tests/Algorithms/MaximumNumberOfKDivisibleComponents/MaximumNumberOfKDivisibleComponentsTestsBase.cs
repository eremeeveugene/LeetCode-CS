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

using LeetCode.Algorithms.MaximumNumberOfKDivisibleComponents;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfKDivisibleComponents;

public abstract class MaximumNumberOfKDivisibleComponentsTestsBase<T> where T : IMaximumNumberOfKDivisibleComponents, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxKDivisibleComponents_WithGraphEdgesAndValues_ReturnsComponentCount(int n, int[][] edges, int[] values, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxKDivisibleComponents(n, edges, values, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [5, new[] { new[] { 0, 2 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 2, 4 } }, new[] { 1, 8, 1, 4, 4 }, 6, 2];

        yield return [7, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 5 }, new[] { 2, 6 } }, new[] { 3, 0, 6, 1, 5, 2, 1 }, 3, 3];
    }
}