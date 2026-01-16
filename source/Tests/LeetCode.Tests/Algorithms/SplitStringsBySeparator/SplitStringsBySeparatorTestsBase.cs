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

using LeetCode.Algorithms.SplitStringsBySeparator;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SplitStringsBySeparator;

public abstract class SplitStringsBySeparatorTestsBase<T> where T : ISplitStringsBySeparator, new()
{
    [TestMethod]
    [DataRow("[\"one.two.three\",\"four.five\",\"six\"]", '.', "[\"one\",\"two\",\"three\",\"four\",\"five\",\"six\"]")]
    [DataRow("[\"$easy$\",\"$problem$\"]", '$', "[\"easy\",\"problem\"]")]
    [DataRow("[\"|||\"]", '|', "[]")]
    public void SplitWordsBySeparator_WithStringsContainingSeparator_RemovesSeparatorAndExcludesEmptyStrings(
        string wordsJson, char separator, string expectedResultJson)
    {
        // Arrange
        var words = JsonHelper<string[]>.Parse(wordsJson);
        var expectedResult = JsonHelper<string[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.SplitWordsBySeparator(words, separator).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}