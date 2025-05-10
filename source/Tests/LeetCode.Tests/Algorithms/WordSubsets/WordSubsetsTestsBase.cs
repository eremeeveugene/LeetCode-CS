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

using LeetCode.Algorithms.WordSubsets;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.WordSubsets;

public abstract class WordSubsetsTestsBase<T> where T : IWordSubsets, new()
{
    [TestMethod]
    [DataRow("[\"amazon\",\"apple\",\"facebook\",\"google\",\"leetcode\"]", "[\"e\",\"o\"]",
        "[\"facebook\",\"google\",\"leetcode\"]")]
    [DataRow("[\"amazon\",\"apple\",\"facebook\",\"google\",\"leetcode\"]", "[\"l\",\"e\"]",
        "[\"apple\",\"google\",\"leetcode\"]")]
    public void WordSubsets_WithWords1AndWords2_ReturnsMatchingSubset(string words1Json, string words2Json,
        string expectedResultJson)
    {
        // Arrange
        var words1 = JsonHelper<string>.DeserializeToArray(words1Json);
        var words2 = JsonHelper<string>.DeserializeToArray(words2Json);
        var expectedResult = JsonHelper<string>.DeserializeToArray(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.WordSubsets(words1, words2);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}