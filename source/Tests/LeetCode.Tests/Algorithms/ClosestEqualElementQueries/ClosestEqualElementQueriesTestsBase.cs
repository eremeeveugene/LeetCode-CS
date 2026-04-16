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