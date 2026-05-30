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

using LeetCode.Algorithms.CheckIfParenthesesStringCanBeValid;

namespace LeetCode.Tests.Algorithms.CheckIfParenthesesStringCanBeValid;

public abstract class CheckIfParenthesesStringCanBeValidTestsBase<T> where T : ICheckIfParenthesesStringCanBeValid, new()
{
    [TestMethod]
    [DataRow("))()))", "010100", true)]
    [DataRow("()()", "0000", true)]
    [DataRow(")", "0", false)]
    [DataRow("((()(()()))()((()()))))()((()(()", "10111100100101001110100010001001", true)]
    public void CanBeValid_WithStringAndLocked_ReturnsWhetherParenthesesCanBeValid(string s, string locked, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanBeValid(s, locked);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}