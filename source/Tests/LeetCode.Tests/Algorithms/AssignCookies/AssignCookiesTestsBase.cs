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

using LeetCode.Algorithms.AssignCookies;

namespace LeetCode.Tests.Algorithms.AssignCookies;

public abstract class AssignCookiesTestsBase<T> where T : IAssignCookies, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1 }, 1)]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2, 3 }, 2)]
    [DataRow(new[] { 2 }, new[] { 1 }, 0)]
    [DataRow(new[] { 3 }, new[] { 1, 2 }, 0)]
    [DataRow(new[] { 1 }, new[] { 1 }, 1)]
    [DataRow(new[] { 1 }, new[] { 2 }, 1)]
    [DataRow(new[] { 5 }, new[] { 4 }, 0)]
    [DataRow(new[] { 5 }, new[] { 5 }, 1)]
    [DataRow(new[] { 1, 1 }, new[] { 1, 1 }, 2)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, 3)]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 4, 3, 2, 1 }, new[] { 1, 1, 1, 1 }, 1)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 1, 1 }, 1)]
    [DataRow(new[] { 2, 3 }, new[] { 1, 1 }, 0)]
    [DataRow(new[] { 10 }, new[] { 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 3, 3, 3 }, 3)]
    [DataRow(new[] { 2, 4, 6 }, new[] { 1, 3, 5, 7 }, 3)]
    [DataRow(new[] { 7, 8, 9, 10 }, new[] { 5, 6, 7, 8 }, 2)]
    [DataRow(new[] { 1 }, new[] { 1, 2, 3 }, 1)]
    [DataRow(new[] { 3, 5, 7 }, new[] { 2, 4, 6 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 1, 2, 3 }, 3)]
    [DataRow(new[] { 9, 9, 9 }, new[] { 9, 9, 9 }, 3)]
    [DataRow(new[] { 100, 200 }, new[] { 50, 150 }, 1)]
    [DataRow(new[] { 1, 5, 9 }, new[] { 4, 8, 12 }, 3)]
    public void FindContentChildren_WithGivenGreedyAndSizeArrays_ReturnsMaxSatisfiedChildren(int[] g, int[] s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindContentChildren(g, s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}