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

using LeetCode.Algorithms.ClearDigits;

namespace LeetCode.Tests.Algorithms.ClearDigits;

public abstract class ClearDigitsTestsBase<T> where T : IClearDigits, new()
{
    [TestMethod]
    [DataRow("abc", "abc")]
    [DataRow("cb34", "")]
    [DataRow("a1", "")]
    [DataRow("ab1", "a")]
    [DataRow("ab12", "")]
    [DataRow("a1b2", "")]
    [DataRow("abc1", "ab")]
    [DataRow("abc12", "a")]
    [DataRow("a1bc2", "b")]
    [DataRow("a", "a")]
    [DataRow("z", "z")]
    [DataRow("hello", "hello")]
    [DataRow("ab1c2d3", "a")]
    [DataRow("abcd12", "ab")]
    [DataRow("abcd1", "abc")]
    [DataRow("a1b1c1d1", "")]
    [DataRow("xy1z", "xz")]
    [DataRow("abc123", "")]
    [DataRow("abcde3", "abcd")]
    [DataRow("ab1cd2ef", "acef")]
    [DataRow("q9", "")]
    [DataRow("leet0code1", "leecod")]
    public void ClearDigits_GivenStringWithLettersAndDigits_ReturnsStringWithoutDigits(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ClearDigits(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}