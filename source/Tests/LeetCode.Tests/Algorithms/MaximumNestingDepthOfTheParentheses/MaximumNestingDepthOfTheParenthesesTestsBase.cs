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

using LeetCode.Algorithms.MaximumNestingDepthOfTheParentheses;

namespace LeetCode.Tests.Algorithms.MaximumNestingDepthOfTheParentheses;

public abstract class MaximumNestingDepthOfTheParenthesesTestsBase<T>
    where T : IMaximumNestingDepthOfTheParentheses, new()
{
    [TestMethod]
    [DataRow("(1+(2*3)+((8)/4))+1", 3)]
    [DataRow("(1)+((2))+(((3)))", 3)]
    [DataRow("1+(2*3)/(2-1)", 1)]
    public void Test(string s, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDepth(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}