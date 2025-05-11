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

using LeetCode.Algorithms.CheckIfStringIsPrefixOfArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CheckIfStringIsPrefixOfArray;

public abstract class CheckIfStringIsPrefixOfArrayTestsBase<T> where T : ICheckIfStringIsPrefixOfArray, new()
{
    [TestMethod]
    [DataRow("iloveleetcode", "[\"i\",\"love\",\"leetcode\",\"apples\"]", true)]
    [DataRow("iloveleetcode", "[\"apples\",\"i\",\"love\",\"leetcode\"]", false)]
    [DataRow("a", "[\"aa\",\"aaaa\",\"banana\"]", false)]
    public void IsPrefixString_WithGivenStringAndWordsArray_ReturnsWhetherStringIsPrefixConcatenation(string s,
        string wordsJson, bool expectedResult)
    {
        // Arrange
        var words = JsonHelper<string[]>.Parse(wordsJson);

        var solution = new T();

        // Act
        var actualResult = solution.IsPrefixString(s, words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}