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

using LeetCode.Algorithms.SortingTheSentence;

namespace LeetCode.Tests.Algorithms.SortingTheSentence;

public abstract class SortingTheSentenceTestsBase<T> where T : ISortingTheSentence, new()
{
    [TestMethod]
    [DataRow("is2 sentence4 This1 a3", "This is a sentence")]
    [DataRow("Myself2 Me1 I4 and3", "Me Myself and I")]
    public void SortSentence_GivenShuffledWords_ReturnsCorrectlyOrderedSentence(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SortSentence(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}