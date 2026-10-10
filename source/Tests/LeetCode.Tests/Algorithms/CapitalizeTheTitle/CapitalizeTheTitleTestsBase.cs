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

using LeetCode.Algorithms.CapitalizeTheTitle;

namespace LeetCode.Tests.Algorithms.CapitalizeTheTitle;

public abstract class CapitalizeTheTitleTestsBase<T> where T : ICapitalizeTheTitle, new()
{
    [TestMethod]
    [DataRow("capiTalIze tHe titLe", "Capitalize The Title")]
    [DataRow("First leTTeR of EACH Word", "First Letter of Each Word")]
    [DataRow("i lOve leetcode", "i Love Leetcode")]
    [DataRow("a", "a")]
    [DataRow("ab", "ab")]
    [DataRow("AB", "ab")]
    [DataRow("abc", "Abc")]
    [DataRow("ABC", "Abc")]
    [DataRow("aBC dEF", "Abc Def")]
    [DataRow("a b c", "a b c")]
    [DataRow("ab cd ef", "ab cd ef")]
    [DataRow("hello world", "Hello World")]
    [DataRow("HELLO", "Hello")]
    [DataRow("a bcd", "a Bcd")]
    [DataRow("abc de", "Abc de")]
    [DataRow("The Quick Brown Fox", "The Quick Brown Fox")]
    [DataRow("of the people", "of The People")]
    [DataRow("I AM A GOOD BOY", "i am a Good Boy")]
    [DataRow("xYz", "Xyz")]
    [DataRow("zz zzz zzzz", "zz Zzz Zzzz")]
    public void CapitalizeTitle_WithMixedCaseTitle_ReturnsProperlyFormattedTitle(string title, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CapitalizeTitle(title);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}