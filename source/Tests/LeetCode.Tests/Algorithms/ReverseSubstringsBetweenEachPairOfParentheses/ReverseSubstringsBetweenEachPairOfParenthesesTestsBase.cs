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

using LeetCode.Algorithms.ReverseSubstringsBetweenEachPairOfParentheses;

namespace LeetCode.Tests.Algorithms.ReverseSubstringsBetweenEachPairOfParentheses;

public abstract class ReverseSubstringsBetweenEachPairOfParenthesesTestsBase<T>
    where T : IReverseSubstringsBetweenEachPairOfParentheses, new()
{
    [TestMethod]
    [DataRow("(abcd)", "dcba")]
    [DataRow("(u(love)i)", "iloveu")]
    [DataRow("(ed(et(oc))el)", "leetcode")]
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