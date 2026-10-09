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

using LeetCode.Algorithms.RemoveOutermostParentheses;

namespace LeetCode.Tests.Algorithms.RemoveOutermostParentheses;

public abstract class RemoveOutermostParenthesesTestsBase<T> where T : IRemoveOutermostParentheses, new()
{
    [TestMethod]
    [DataRow("(()())(())", "()()()")]
    [DataRow("(()())(())(()(()))", "()()()()(())")]
    [DataRow("()()", "")]
    [DataRow("()", "")]
    [DataRow("(())", "()")]
    [DataRow("((()))", "(())")]
    [DataRow("(((())))", "((()))")]
    [DataRow("()()()", "")]
    [DataRow("(())()", "()")]
    [DataRow("()(())", "()")]
    [DataRow("(()())", "()()")]
    [DataRow("(()()())", "()()()")]
    [DataRow("(())(())", "()()")]
    [DataRow("((())())", "(())()")]
    [DataRow("(()(()))", "()(())")]
    [DataRow("((()()))", "(()())")]
    [DataRow("(()())()", "()()")]
    [DataRow("()(()())", "()()")]
    [DataRow("(())()(())", "()()")]
    [DataRow("((()))()", "(())")]
    [DataRow("()((()))", "(())")]
    [DataRow("(()(())())", "()(())()")]
    public void RemoveOuterParentheses_GivenValidParenthesesString_ReturnsStringWithoutOutermostParentheses(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveOuterParentheses(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}