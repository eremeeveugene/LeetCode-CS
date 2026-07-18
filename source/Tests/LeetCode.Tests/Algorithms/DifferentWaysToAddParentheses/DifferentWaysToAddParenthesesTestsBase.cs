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

using LeetCode.Algorithms.DifferentWaysToAddParentheses;

namespace LeetCode.Tests.Algorithms.DifferentWaysToAddParentheses;

public abstract class DifferentWaysToAddParenthesesTestsBase<T> where T : IDifferentWaysToAddParentheses, new()
{
    [TestMethod]
    [DataRow("2-1-1", new[] { 0, 2 })]
    [DataRow("2*3-4*5", new[] { -34, -14, -10, -10, 10 })]
    [DataRow("99", new[] { 99 })]
    [DataRow("12+34-56*78+90", new[] { -9362, -4412, -3684, -4232, -1614, -9362, -4412, -1680, -1680, -4232, -1614, -4232, -690, -690 })]
    [DataRow(
        "9-8+7-6+5-4",
        new[]
        {
            1,
            1,
            -1,
            9,
            -1,
            1,
            1,
            -1,
            -1,
            9,
            -1,
            9,
            -1,
            -1,
            1,
            1,
            3,
            -7,
            3,
            -13,
            -13,
            1,
            1,
            1,
            1,
            3,
            -11,
            3,
            1,
            -9,
            1,
            -9,
            -9,
            -7,
            3,
            -21,
            -7,
            1,
            1,
            3,
            -11,
            3
        })]
    [DataRow("1+1", new[] { 2 })]
    [DataRow("1-1", new[] { 0 })]
    [DataRow("1*1", new[] { 1 })]
    [DataRow("1+2+3", new[] { 6, 6 })]
    [DataRow("1*2-3*4", new[] { -10, -4, -10, -4, -4 })]
    [DataRow("2*3*4", new[] { 24, 24 })]
    [DataRow("100", new[] { 100 })]
    [DataRow("0+1", new[] { 1 })]
    [DataRow("5-2+1", new[] { 2, 4 })]
    [DataRow("1*2*3*4", new[] { 24, 24, 24, 24, 24 })]
    [DataRow("10-5+3", new[] { 2, 8 })]
    [DataRow("1+2-3+4", new[] { -4, 4, -4, 4, 4 })]
    [DataRow("3*4", new[] { 12 })]
    [DataRow("3+4*2", new[] { 14, 11 })]
    [DataRow("2*3+4*5", new[] { 46, 70, 26, 70, 50 })]
    [DataRow("8-3", new[] { 5 })]
    public void DiffWaysToCompute_WithExpression_ReturnsAllPossibleResults(string expression, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DiffWaysToCompute(expression).ToArray();

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }
}