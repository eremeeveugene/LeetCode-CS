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

using LeetCode.Algorithms.MaximumNestingDepthOfTheParentheses;

namespace LeetCode.Tests.Algorithms.MaximumNestingDepthOfTheParentheses;

public abstract class MaximumNestingDepthOfTheParenthesesTestsBase<T> where T : IMaximumNestingDepthOfTheParentheses, new()
{
    [TestMethod]
    [DataRow("(1+(2*3)+((8)/4))+1", 3)]
    [DataRow("(1)+((2))+(((3)))", 3)]
    [DataRow("1+(2*3)/(2-1)", 1)]
    [DataRow("1", 0)]
    [DataRow("()", 1)]
    [DataRow("(())", 2)]
    [DataRow("()()", 1)]
    [DataRow("(((())))", 4)]
    [DataRow("1+2", 0)]
    [DataRow("(1)", 1)]
    [DataRow("(1+(2))", 2)]
    [DataRow("((1)+(2))", 2)]
    [DataRow("(1)(2)(3)", 1)]
    [DataRow("8*((1*(5+6))*(8/6))", 3)]
    [DataRow("(((1)))+(2)", 3)]
    [DataRow("1-(2*(3+(4/(5-6))))", 4)]
    [DataRow("((((((((((9))))))))))", 10)]
    [DataRow("1+2+3+4+5", 0)]
    [DataRow("(1+2)*(3+4)*(5+6)", 1)]
    [DataRow("((1+2)*3)+((4))", 2)]
    public void MaxDepth_WithMathematicalExpression_ReturnsMaximumNestingDepth(string s, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDepth(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}