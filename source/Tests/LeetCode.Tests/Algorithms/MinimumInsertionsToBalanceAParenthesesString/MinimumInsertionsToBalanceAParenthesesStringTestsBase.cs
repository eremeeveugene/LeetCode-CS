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

using LeetCode.Algorithms.MinimumInsertionsToBalanceAParenthesesString;

namespace LeetCode.Tests.Algorithms.MinimumInsertionsToBalanceAParenthesesString;

public abstract class MinimumInsertionsToBalanceAParenthesesStringTestsBase<T> where T : IMinimumInsertionsToBalanceAParenthesesString, new()
{
    [TestMethod]
    [DataRow("(()))", 1)]
    [DataRow("())", 0)]
    [DataRow("))())(", 3)]
    [DataRow("((((((", 12)]
    [DataRow(")))))))", 5)]
    [DataRow("(", 2)]
    [DataRow(")", 2)]
    [DataRow("))", 1)]
    [DataRow("()", 1)]
    [DataRow("()))", 2)]
    [DataRow("(()", 3)]
    [DataRow("())())", 0)]
    [DataRow("(())))", 0)]
    [DataRow(")()", 3)]
    [DataRow("(()))(", 3)]
    [DataRow("((())))", 2)]
    [DataRow("((()))))", 1)]
    [DataRow(")))", 3)]
    [DataRow("))))", 2)]
    [DataRow("()()", 2)]
    [DataRow("()))((", 6)]
    [DataRow("(()()))", 2)]
    [DataRow("))(", 3)]
    [DataRow("(())", 2)]
    [DataRow("())(", 2)]
    [DataRow("()))))", 3)]
    public void MinInsertions_WithGivenString_ReturnsMinimumInsertions(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinInsertions(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}