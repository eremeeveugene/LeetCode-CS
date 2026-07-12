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

using LeetCode.Algorithms.CheckIfWordOccursAsPrefixOfAnyWordInSentence;

namespace LeetCode.Tests.Algorithms.CheckIfWordOccursAsPrefixOfAnyWordInSentence;

public abstract class CheckIfWordOccursAsPrefixOfAnyWordInSentenceTestBase<T> where T : ICheckIfWordOccursAsPrefixOfAnyWordInSentence, new()
{
    [TestMethod]
    [DataRow("i love eating burger", "burg", 4)]
    [DataRow("this problem is an easy problem", "pro", 2)]
    [DataRow("i am tired", "you", -1)]
    public void IsPrefixOfWord_WithSentenceAndSearchWord_ReturnsFirstMatchingWordIndexOrMinusOne(
        string sentence,
        string searchWord,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsPrefixOfWord(sentence, searchWord);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}