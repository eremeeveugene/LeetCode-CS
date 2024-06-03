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

using LeetCode.Algorithms.AppendCharactersToStringToMakeSubsequence;

namespace LeetCode.Tests.Algorithms.AppendCharactersToStringToMakeSubsequence;

public abstract class AppendCharactersToStringToMakeSubsequenceTestsBase<T>
    where T : IAppendCharactersToStringToMakeSubsequence, new()
{
    [TestMethod]
    [DataRow("a", "a", 0)]
    [DataRow("a", "z", 1)]
    [DataRow("z", "abcde", 5)]
    [DataRow("abz", "abc", 1)]
    [DataRow("abcde", "a", 0)]
    [DataRow("abcde", "abc", 0)]
    [DataRow("abcde", "bdf", 1)]
    [DataRow("abcdef", "abcdef", 0)]
    [DataRow("axbyczd", "abcd", 0)]
    [DataRow("vrykt", "rkge", 2)]
    [DataRow("coaching", "coding", 4)]
    public void AppendCharacters_GivenSourceAndTargetStrings_ReturnsExpectedCharacterCount(string s, string t,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AppendCharacters(s, t);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}