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

using LeetCode.Algorithms.CheckIfTwoStringArraysAreEquivalent;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CheckIfTwoStringArraysAreEquivalent;

public abstract class CheckIfTwoStringArraysAreEquivalentTestsBase<T>
    where T : ICheckIfTwoStringArraysAreEquivalent, new()
{
    [TestMethod]
    [DataRow("[\"ab\", \"c\"]", "[\"a\", \"bc\"]", true)]
    [DataRow("[\"a\", \"cb\"]", "[\"ab\", \"c\"]", false)]
    [DataRow("[\"abc\", \"d\", \"defg\"]", "[\"abcddefg\"]", true)]
    [DataRow("[\"ecxarwyyy\", \"ppf\", \"tdyayjd\"]", "[\"ecxarwyyyppft\", \"dyayj\", \"q\"]", false)]
    [DataRow("[\"a\", \"b\", \"c\"]", "[\"abc\"]", true)]
    [DataRow("[\"abc\"]", "[\"a\", \"b\", \"c\"]", true)]
    [DataRow("[\"abc\"]", "[\"ab\", \"d\"]", false)]
    public void ArrayStringsAreEqual_GivenTwoStringArrays_ReturnsBooleanIndicatingEquality(string word1JsonArray,
        string word2JsonArray, bool expectedResult)
    {
        // Arrange
        var word1 = JsonHelper<string>.DeserializeToArray(word1JsonArray);
        var word2 = JsonHelper<string>.DeserializeToArray(word2JsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ArrayStringsAreEqual(word1, word2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}