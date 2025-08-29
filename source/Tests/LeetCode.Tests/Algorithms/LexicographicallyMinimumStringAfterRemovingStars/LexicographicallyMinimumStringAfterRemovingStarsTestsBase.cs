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

using LeetCode.Algorithms.LexicographicallyMinimumStringAfterRemovingStars;

namespace LeetCode.Tests.Algorithms.LexicographicallyMinimumStringAfterRemovingStars;

public abstract class LexicographicallyMinimumStringAfterRemovingStarsTestsBase<T>
    where T : ILexicographicallyMinimumStringAfterRemovingStars, new()
{
    [TestMethod]
    [DataRow("aaba*", "aab")]
    [DataRow("abc", "abc")]
    public void ClearStars_WithAsteriskAndCharactersString_ReturnLexicographicallySmallestString(
        string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ClearStars(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}