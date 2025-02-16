// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.FindLongestSpecialSubstringThatOccursThrice1;

namespace LeetCode.Tests.Algorithms.FindLongestSpecialSubstringThatOccursThrice1;

public abstract class FindLongestSpecialSubstringThatOccursThrice1TestsBase<T>
    where T : IFindLongestSpecialSubstringThatOccursThrice1, new()
{
    [TestMethod]
    [DataRow("aaaa", 2)]
    [DataRow("abcdef", -1)]
    [DataRow("abcaba", 1)]
    public void MaximumLength_WithInputString_ReturnsLengthOfTheLongestSpecialSubstring(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumLength(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}