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

using LeetCode.Algorithms.FindTheOriginalTypedString1;

namespace LeetCode.Tests.Algorithms.FindTheOriginalTypedString1;

public abstract class FindTheOriginalTypedString1TestsBase<T> where T : IFindTheOriginalTypedString1, new()
{
    [TestMethod]
    [DataRow("abbcccc", 5)]
    [DataRow("abcd", 1)]
    [DataRow("aaaa", 4)]
    [DataRow("ere", 1)]
    public void PossibleStringCount_WithGivenTypedString_ReturnsPossibleOriginalStringCount(string word,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PossibleStringCount(word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}