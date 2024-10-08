// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MinimumNumberOfSwapsToMakeTheStringBalanced;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfSwapsToMakeTheStringBalanced;

public abstract class MinimumNumberOfSwapsToMakeTheStringBalancedTestsBase<T>
    where T : IMinimumNumberOfSwapsToMakeTheStringBalanced, new()
{
    [TestMethod]
    [DataRow("[]", 0)]
    [DataRow("][][", 1)]
    [DataRow("]]][[[", 2)]
    public void MinSwaps_GivenUnbalancedBracketsString_ReturnsMinimumSwapsToBalance(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinSwaps(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}