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

using LeetCode.Algorithms.LexicographicallyMinimumStringAfterRemovingStars;

namespace LeetCode.Tests.Algorithms.LexicographicallyMinimumStringAfterRemovingStars;

public abstract class LexicographicallyMinimumStringAfterRemovingStarsTestsBase<T> where T : ILexicographicallyMinimumStringAfterRemovingStars, new()
{
    [TestMethod]
    [DataRow("aaba*", "aab")]
    [DataRow("abc", "abc")]
    [DataRow("a*", "")]
    [DataRow("ab**", "")]
    [DataRow("ba*", "b")]
    [DataRow("cb*a", "ca")]
    [DataRow("z*", "")]
    [DataRow("ab*c", "bc")]
    [DataRow("abc*", "bc")]
    [DataRow("aab*", "ab")]
    [DataRow("abcde", "abcde")]
    [DataRow("ba*b*", "b")]
    [DataRow("dba*", "db")]
    [DataRow("abcd*e*", "cde")]
    [DataRow("zab*c", "zbc")]
    [DataRow("b*a", "a")]
    [DataRow("aa*b", "ab")]
    [DataRow("cb*", "c")]
    public void ClearStars_WithAsteriskAndCharactersString_ReturnLexicographicallySmallestString(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ClearStars(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}