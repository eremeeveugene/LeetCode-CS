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

using LeetCode.Algorithms.MinimumRemoveToMakeValidParentheses;

namespace LeetCode.Tests.Algorithms.MinimumRemoveToMakeValidParentheses;

public abstract class MinimumRemoveToMakeValidParenthesesTestsBase<T>
    where T : IMinimumRemoveToMakeValidParentheses, new()
{
    [TestMethod]
    [DataRow("lee(t(c)o)de)", "lee(t(c)o)de")]
    [DataRow("a)b(c)d", "ab(c)d")]
    [DataRow("))((", "")]
    public void MinRemoveToMakeValid_GivenString_ReturnsValidParenthesesString(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinRemoveToMakeValid(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}