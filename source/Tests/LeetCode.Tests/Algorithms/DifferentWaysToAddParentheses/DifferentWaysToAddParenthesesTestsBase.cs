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

using LeetCode.Algorithms.DifferentWaysToAddParentheses;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DifferentWaysToAddParentheses;

public abstract class DifferentWaysToAddParenthesesTestsBase<T> where T : IDifferentWaysToAddParentheses, new()
{
    [TestMethod]
    [DataRow("2-1-1", "[0,2]")]
    [DataRow("2*3-4*5", "[-34,-14,-10,-10,10]")]
    [DataRow("99", "[99]")]
    [DataRow("12+34-56*78+90", "[-9362,-4412,-3684,-4232,-1614,-9362,-4412,-1680,-1680,-4232,-1614,-4232,-690,-690]")]
    [DataRow("9-8+7-6+5-4",
        "[1,1,-1,9,-1,1,1,-1,-1,9,-1,9,-1,-1,1,1,3,-7,3,-13,-13,1,1,1,1,3,-11,3,1,-9,1,-9,-9,-7,3,-21,-7,1,1,3,-11,3]")]
    public void DiffWaysToCompute_WithExpression_ReturnsAllPossibleResults(string expression,
        string expectedResultJsonArray)
    {
        // Arrange
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.DiffWaysToCompute(expression);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult.ToArray());
    }
}