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

using LeetCode.Algorithms.MinimumAddToMakeParenthesesValid;

namespace LeetCode.Tests.Algorithms.MinimumAddToMakeParenthesesValid;

public abstract class MinimumAddToMakeParenthesesValidTestsBase<T> where T : IMinimumAddToMakeParenthesesValid, new()
{
    [TestMethod]
    [DataRow("())", 1)]
    [DataRow("(((", 3)]
    public void MinAddToMakeValid_GivenStringOfParentheses_ReturnsMinimumAdditionsRequired(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinAddToMakeValid(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}