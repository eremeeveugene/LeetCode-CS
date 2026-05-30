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

using LeetCode.Algorithms.DistributeCandies;

namespace LeetCode.Tests.Algorithms.DistributeCandies;

public abstract class DistributeCandiesTestsBase<T> where T : IDistributeCandies, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, 3)]
    [DataRow(new[] { 1, 1, 2, 3 }, 2)]
    [DataRow(new[] { 6, 6, 6, 6 }, 1)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4 }, 2)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 1, 1, 2 }, 2)]
    [DataRow(new[] { 1, 2, 2, 3 }, 2)]
    [DataRow(new[] { 1, 2, 3, 3 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 3)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 4 }, 3)]
    [DataRow(new[] { 1, 1, 1, 1, 2, 3 }, 3)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 2 }, 2)]
    [DataRow(new[] { 0, 0, 0, 1, 2, 3 }, 3)]
    [DataRow(new[] { -1, -1, -2, -2, -3, -4 }, 3)]
    [DataRow(new[] { -100000, 100000 }, 1)]
    [DataRow(new[] { -100000, -100000, 100000, 100000 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 5, 5, 5 }, 4)]
    [DataRow(new[] { 7, 7, 8, 8, 9, 9, 10, 10 }, 4)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 }, 5)]
    public void DistributeCandies_WithCandyTypes_ReturnsMaximumDistinctTypesWithinHalfLimit(int[] candyTypes, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DistributeCandies(candyTypes);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}