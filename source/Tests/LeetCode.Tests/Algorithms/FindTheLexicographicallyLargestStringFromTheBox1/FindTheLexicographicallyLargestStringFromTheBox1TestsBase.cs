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

using LeetCode.Algorithms.FindTheLexicographicallyLargestStringFromTheBox1;

namespace LeetCode.Tests.Algorithms.FindTheLexicographicallyLargestStringFromTheBox1;

public abstract class FindTheLexicographicallyLargestStringFromTheBox1TestsBase<T>
    where T : IFindTheLexicographicallyLargestStringFromTheBox1, new()
{
    [TestMethod]
    [DataRow("dbca", 2, "dbc")]
    [DataRow("gggg", 4, "g")]
    public void AnswerString_WithWordAndNumFriends_ReturnsLexicographicallySmallestSubsequence(string word,
        int numFriends, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AnswerString(word, numFriends);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}