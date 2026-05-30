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

using LeetCode.Algorithms.MinimumDeletionsForKMostKDistinctCharacters;

namespace LeetCode.Tests.Algorithms.MinimumDeletionsForKMostKDistinctCharacters;

public abstract class MinimumDeletionsForKMostKDistinctCharactersTestsBase<T> where T : IMinimumDeletionsForKMostKDistinctCharacters, new()
{
    [TestMethod]
    [DataRow("abc", 2, 1)]
    [DataRow("aabb", 2, 0)]
    [DataRow("yyyzz", 1, 2)]
    [DataRow("wund", 1, 3)]
    public void MinDeletion_WithStringAndLimitK_ReturnsMinimumDeletions(string s, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinDeletion(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}