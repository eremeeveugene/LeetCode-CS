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

using LeetCode.Algorithms.RepeatedSubstringPattern;

namespace LeetCode.Tests.Algorithms.RepeatedSubstringPattern;

public abstract class RepeatedSubstringPatternTestsBase<T> where T : IRepeatedSubstringPattern, new()
{
    [TestMethod]
    [DataRow("abab", true)]
    [DataRow("aba", false)]
    [DataRow("abcabcabcabc", true)]
    public void RepeatedSubstringPattern_GivenString_EvaluatesStringPatternRepetition(string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RepeatedSubstringPattern(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}