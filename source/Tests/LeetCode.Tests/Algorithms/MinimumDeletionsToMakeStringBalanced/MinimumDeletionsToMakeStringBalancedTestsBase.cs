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

using LeetCode.Algorithms.MinimumDeletionsToMakeStringBalanced;

namespace LeetCode.Tests.Algorithms.MinimumDeletionsToMakeStringBalanced;

public abstract class MinimumDeletionsToMakeStringBalancedTestsBase<T>
    where T : IMinimumDeletionsToMakeStringBalanced, new()
{
    [TestMethod]
    [DataRow("aababbab", 2)]
    [DataRow("bbaaaaabb", 2)]
    public void MinimumDeletions_WithInputString_ReturnsMinimumDeletionsToMakeStringBalanced(string s,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumDeletions(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}