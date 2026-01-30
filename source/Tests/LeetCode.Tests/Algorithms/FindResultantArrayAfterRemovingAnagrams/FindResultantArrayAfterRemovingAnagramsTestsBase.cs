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

using LeetCode.Algorithms.FindResultantArrayAfterRemovingAnagrams;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindResultantArrayAfterRemovingAnagrams;

public abstract class FindResultantArrayAfterRemovingAnagramsTestsBase<T>
    where T : IFindResultantArrayAfterRemovingAnagrams, new()
{
    [TestMethod]
    [DataRow("[\"abba\",\"baba\",\"bbaa\",\"cd\",\"cd\"]", "[\"abba\",\"cd\"]")]
    [DataRow("\"a\",\"b\",\"c\",\"d\",\"e\"]", "[\"a\",\"b\",\"c\",\"d\",\"e\"]")]
    public void RemoveAnagrams_WithWordsArray_RemovesAllSubsequentAnagramDuplicates(string wordsJson,
        string expectedResultJson)
    {
        // Arrange
        var words = JsonHelper<string[]>.Parse(wordsJson);
        var expectedResult = JsonHelper<string[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveAnagrams(words).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}