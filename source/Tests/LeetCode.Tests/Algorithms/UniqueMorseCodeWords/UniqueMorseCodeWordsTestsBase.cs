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

using LeetCode.Algorithms.UniqueMorseCodeWords;

namespace LeetCode.Tests.Algorithms.UniqueMorseCodeWords;

public abstract class UniqueMorseCodeWordsTestsBase<T> where T : IUniqueMorseCodeWords, new()
{
    [TestMethod]
    [DataRow(new[] { "gin", "zen", "gig", "msg" }, 2)]
    [DataRow(new[] { "a" }, 1)]
    public void UniqueMorseRepresentations_GivenWordsArray_ReturnsCountOfUniqueRepresentations(string[] words,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.UniqueMorseRepresentations(words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}