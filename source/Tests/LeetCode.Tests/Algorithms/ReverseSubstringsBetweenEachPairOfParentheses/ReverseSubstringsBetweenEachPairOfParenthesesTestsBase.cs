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

using LeetCode.Algorithms.ReverseSubstringsBetweenEachPairOfParentheses;

namespace LeetCode.Tests.Algorithms.ReverseSubstringsBetweenEachPairOfParentheses;

public abstract class ReverseSubstringsBetweenEachPairOfParenthesesTestsBase<T> where T : IReverseSubstringsBetweenEachPairOfParentheses, new()
{
    [TestMethod]
    [DataRow("(abcd)", "dcba")]
    [DataRow("(u(love)i)", "iloveu")]
    [DataRow("(ed(et(oc))el)", "leetcode")]
    [DataRow("a", "a")]
    [DataRow("()", "")]
    [DataRow("(a)", "a")]
    [DataRow("a(b)c", "abc")]
    [DataRow("(ab)(cd)", "badc")]
    [DataRow("((a))", "a")]
    [DataRow("(a(b)c)", "cba")]
    [DataRow("((ab)c)", "cab")]
    [DataRow("(a(bc))", "bca")]
    [DataRow("(((abc)))", "cba")]
    [DataRow("ab(cd)ef", "abdcef")]
    [DataRow("(ab)cd(ef)", "bacdfe")]
    [DataRow("a(b(c(d)e)f)g", "afcdebg")]
    [DataRow("(abc)(def)(ghi)", "cbafedihg")]
    [DataRow("((ab)(cd))", "cdab")]
    [DataRow("(ed(et(oc))el)x", "leetcodex")]
    [DataRow("(kq(s((ohcs)(kroi)dx(kom)cw)u)d)l", "dswckomxdkroiohcsuqkl")]
    public void ReverseParentheses_WithNestedParentheses_ReturnsReversedString(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReverseParentheses(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}