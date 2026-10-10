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

using LeetCode.Algorithms.ParsingBooleanExpression;

namespace LeetCode.Tests.Algorithms.ParsingBooleanExpression;

public abstract class ParsingBooleanExpressionTestsBase<T> where T : IParsingBooleanExpression, new()
{
    [TestMethod]
    [DataRow("&(|(f))", false)]
    [DataRow("|(f,f,f,t)", true)]
    [DataRow("!(&(f,t))", true)]
    [DataRow("&(|(f,t),t)", true)]
    [DataRow("t", true)]
    [DataRow("f", false)]
    [DataRow("!(t)", false)]
    [DataRow("!(f)", true)]
    [DataRow("&(t,t)", true)]
    [DataRow("&(t,f)", false)]
    [DataRow("|(f,f)", false)]
    [DataRow("|(t,f)", true)]
    [DataRow("&(f)", false)]
    [DataRow("|(t)", true)]
    [DataRow("&(t,t,t,t)", true)]
    [DataRow("|(f,f,f,f)", false)]
    [DataRow("!(!(t))", true)]
    [DataRow("!(|(f,f))", true)]
    [DataRow("&(!(f),!(f))", true)]
    [DataRow("|(&(t,f),&(f,t))", false)]
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