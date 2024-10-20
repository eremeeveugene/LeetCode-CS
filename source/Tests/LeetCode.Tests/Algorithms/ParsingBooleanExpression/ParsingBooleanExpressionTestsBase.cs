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

using LeetCode.Algorithms.ParsingBooleanExpression;

namespace LeetCode.Tests.Algorithms.ParsingBooleanExpression;

public abstract class ParsingBooleanExpressionTestsBase<T> where T : IParsingBooleanExpression, new()
{
    [TestMethod]
    [DataRow("&(|(f))", false)]
    [DataRow("|(f,f,f,t)", true)]
    [DataRow("!(&(f,t))", true)]
    public void ParseBoolExpr_GivenBooleanExpression_EvaluatesToCorrectResult(string expression, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ParseBoolExpr(expression);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}