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

using LeetCode.Algorithms.FractionAdditionAndSubtraction;

namespace LeetCode.Tests.Algorithms.FractionAdditionAndSubtraction;

public abstract class FractionAdditionAndSubtractionTestsBase<T> where T : IFractionAdditionAndSubtraction, new()
{
    [TestMethod]
    [DataRow("-1/2+1/2", "0/1")]
    [DataRow("1/6-1/6+2/3-2/3", "0/1")]
    [DataRow("1/10-1/10", "0/1")]
    [DataRow("1/4+3/4", "1/1")]
    [DataRow("-1/2+1/2+1/3", "1/3")]
    [DataRow("1/3-1/2", "-1/6")]
    [DataRow("-1/3+1/4-1/5+1/6-1/7+1/8-1/9+1/10-1/9+1/10", "-79/504")]
    [DataRow("9/4-5/3+7/2-9/5+10/6-1/7+1/8-2/9+2/10", "9853/2520")]
    [DataRow("-1/1-1/1-1/1-1/1-1/1-1/1-1/1-1/1-1/1-1/1", "-10/1")]
    [DataRow("-1/3-1/4-1/5-1/6-1/7-1/8-1/9-1/10-1/10-6/10", "-1073/504")]
    public void FractionAddition_GivenExpression_ReturnsSimplifiedResult(string expression, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FractionAddition(expression);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}