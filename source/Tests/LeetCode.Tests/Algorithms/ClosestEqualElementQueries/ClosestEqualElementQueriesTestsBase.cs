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

using LeetCode.Algorithms.ClosestEqualElementQueries;

namespace LeetCode.Tests.Algorithms.ClosestEqualElementQueries;

public abstract class ClosestEqualElementQueriesTestsBase<T> where T : IClosestEqualElementQueries, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 0, 1, 2, 3 }, new[] { -1, -1, -1, -1 })]
    [DataRow(new[] { 1, 3, 1, 4, 1, 3, 2 }, new[] { 0, 3, 5 }, new[] { 2, -1, 3 })]
    [DataRow(new[] { 5, 5 }, new[] { 0, 1 }, new[] { 1, 1 })]
    [DataRow(new[] { 7, 1, 2, 3, 7 }, new[] { 0, 4 }, new[] { 1, 1 })]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, new[] { 0, 1, 2, 3, 4, 5 }, new[] { 2, 2, 2, 2, 2, 2 })]
    [DataRow(new[] { 4, 1, 2, 4, 3, 4 }, new[] { 0, 3, 5 }, new[] { 1, 2, 1 })]
    [DataRow(new[] { 8, 6, 8, 6, 8 }, new[] { 0, 2, 4, 1, 3 }, new[] { 1, 2, 1, 2, 2 })]
    [DataRow(new[] { 9, 1, 9, 2, 3, 4, 9 }, new[] { 0, 2, 6 }, new[] { 1, 2, 1 })]
    [DataRow(new[] { 1, 2, 3, 1, 4, 5, 1 }, new[] { 0, 3, 6 }, new[] { 1, 3, 1 })]
    [DataRow(new[] { 2, 2, 2, 2 }, new[] { 0, 1, 2, 3 }, new[] { 1, 1, 1, 1 })]
    [DataRow(new[] { 1, 2, 3, 2, 1 }, new[] { 0, 1, 2, 3, 4 }, new[] { 1, 2, -1, 2, 1 })]
    [DataRow(new[] { 3, 1, 3, 1, 3, 1, 3 }, new[] { 0, 1, 6 }, new[] { 1, 2, 1 })]
    public void SolveQueries_WithCircularArrayAndQueryIndices_ReturnsMinimumDistance(int[] nums, int[] queries,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SolveQueries(nums, queries).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}