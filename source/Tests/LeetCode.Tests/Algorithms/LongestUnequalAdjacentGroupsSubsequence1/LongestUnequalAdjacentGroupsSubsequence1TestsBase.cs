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

using LeetCode.Algorithms.LongestUnequalAdjacentGroupsSubsequence1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LongestUnequalAdjacentGroupsSubsequence1;

public abstract class LongestUnequalAdjacentGroupsSubsequence1TestsBase<T>
    where T : ILongestUnequalAdjacentGroupsSubsequence1, new()
{
    [TestMethod]
    [DataRow("[\"e\",\"a\",\"b\"]", "[0,0,1]", "[\"e\",\"b\"]")]
    [DataRow("[\"a\",\"b\",\"c\",\"d\"]", "[1,0,1,1]", "[\"a\",\"b\",\"c\"]")]
    public void GetLongestSubsequence_WithWordsAndGroupLabels_ReturnsLongestSubsequenceByGroupOrder(string wordsJson,
        string groupsJson, string expectedResultJson)
    {
        // Arrange
        var words = JsonHelper<string[]>.Parse(wordsJson);
        var groups = JsonHelper.Parse<int[]>(groupsJson);
        var expectedResult = JsonHelper<string[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.GetLongestSubsequence(words, groups).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}