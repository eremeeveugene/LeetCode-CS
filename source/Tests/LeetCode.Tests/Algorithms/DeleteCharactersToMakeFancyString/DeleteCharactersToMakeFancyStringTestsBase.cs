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

using LeetCode.Algorithms.DeleteCharactersToMakeFancyString;

namespace LeetCode.Tests.Algorithms.DeleteCharactersToMakeFancyString;

public abstract class DeleteCharactersToMakeFancyStringTestsBase<T> where T : IDeleteCharactersToMakeFancyString, new()
{
    [TestMethod]
    [DataRow("leeetcode", "leetcode")]
    [DataRow("aaabaaaa", "aabaa")]
    [DataRow("aab", "aab")]
    public void MakeFancyString_WithInputString_RemovesConsecutiveDuplicates(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MakeFancyString(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}