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

using LeetCode.Algorithms.ReversePrefixOfWord;

namespace LeetCode.Tests.Algorithms.ReversePrefixOfWord;

public abstract class ReverseStringTestsBase<T> where T : IReversePrefixOfWord, new()
{
    [TestMethod]
    [DataRow("abcdefd", 'd', "dcbaefd")]
    [DataRow("xyxzxe", 'z', "zxyxxe")]
    [DataRow("abcd", 'z', "abcd")]
    public void ReversePrefix_GivenWordAndChar_ReturnsModifiedString(string word, char ch, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReversePrefix(word, ch);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}