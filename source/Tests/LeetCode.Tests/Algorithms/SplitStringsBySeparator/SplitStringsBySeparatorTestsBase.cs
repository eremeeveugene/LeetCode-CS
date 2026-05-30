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

namespace LeetCode.Tests.Algorithms.SplitStringsBySeparator;

public abstract class SplitStringsBySeparatorTestsBase<T> where T : ISplitStringsBySeparator, new()
{
    [TestMethod]
    [DataRow(new[] { "one.two.three", "four.five", "six" }, '.', new[] { "one", "two", "three", "four", "five", "six" })]
    [DataRow(new[] { "$easy$", "$problem$" }, '$', new[] { "easy", "problem" })]
    [DataRow(new[] { "|||" }, '|', new string[] { })]
    public void SplitWordsBySeparator_WithStringsContainingSeparator_RemovesSeparatorAndExcludesEmptyStrings(string[] words, char separator, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SplitWordsBySeparator(words, separator).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}