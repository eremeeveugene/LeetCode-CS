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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.UniqueMorseCodeWords;

public abstract class UniqueMorseCodeWordsTestsBase<T> where T : IUniqueMorseCodeWords, new()
{
    [TestMethod]
    [DataRow("[\"gin\", \"zen\", \"gig\", \"msg\"]", 2)]
    [DataRow("[\"a\"]", 1)]
    public void UniqueMorseRepresentations_GivenWordsArray_ReturnsCountOfUniqueRepresentations(string wordsJsonArray,
        int expectedResult)
    {
        // Arrange
        var words = JsonHelper<string>.DeserializeToArray(wordsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.UniqueMorseRepresentations(words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}