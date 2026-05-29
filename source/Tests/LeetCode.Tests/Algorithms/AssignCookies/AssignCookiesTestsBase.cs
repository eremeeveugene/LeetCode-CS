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
    public void FindContentChildren_WithGivenGreedyAndSizeArrays_ReturnsMaxSatisfiedChildren(int[] g,
        int[] s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindContentChildren(g, s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}