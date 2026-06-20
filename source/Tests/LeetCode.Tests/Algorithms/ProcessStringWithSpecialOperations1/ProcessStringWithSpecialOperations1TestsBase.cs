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

using LeetCode.Algorithms.ProcessStringWithSpecialOperations1;

namespace LeetCode.Tests.Algorithms.ProcessStringWithSpecialOperations1;

public abstract class ProcessStringWithSpecialOperations1TestsBase<T> where T : IProcessStringWithSpecialOperations1, new()
{
    [TestMethod]
    [DataRow("a#b%*", "ba")]
    [DataRow("z*#", "")]
    [DataRow("a", "a")]
    [DataRow("ab", "ab")]
    [DataRow("*", "")]
    [DataRow("**", "")]
    [DataRow("a*", "")]
    [DataRow("ab*", "a")]
    [DataRow("a#", "aa")]
    [DataRow("ab#", "abab")]
    [DataRow("a%", "a")]
    [DataRow("ab%", "ba")]
    [DataRow("abc%", "cba")]
    [DataRow("#", "")]
    [DataRow("%", "")]
    [DataRow("abc", "abc")]
    [DataRow("a#*", "a")]
    [DataRow("ab#%", "baba")]
    [DataRow("ab#*", "aba")]
    [DataRow("xy*z", "xz")]
    [DataRow("a#b#", "aabaab")]
    [DataRow("abc*%", "ba")]
    [DataRow("%a%", "a")]
    [DataRow("ab%c#", "bacbac")]
    public void ProcessStr_WithSpecialOperations_ReturnsProcessedString(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ProcessStr(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}