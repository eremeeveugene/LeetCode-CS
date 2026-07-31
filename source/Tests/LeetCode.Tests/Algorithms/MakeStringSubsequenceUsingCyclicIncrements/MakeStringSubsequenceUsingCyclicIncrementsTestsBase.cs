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

using LeetCode.Algorithms.MakeStringSubsequenceUsingCyclicIncrements;

namespace LeetCode.Tests.Algorithms.MakeStringSubsequenceUsingCyclicIncrements;

public abstract class MakeStringSubsequenceUsingCyclicIncrementsTestsBase<T> where T : IMakeStringSubsequenceUsingCyclicIncrements, new()
{
    [TestMethod]
    [DataRow("abc", "ad", true)]
    [DataRow("zc", "ad", true)]
    [DataRow("ab", "d", false)]
    [DataRow("a", "b", true)]
    [DataRow("a", "a", true)]
    [DataRow("z", "a", true)]
    [DataRow("z", "z", true)]
    [DataRow("a", "c", false)]
    [DataRow("abc", "abc", true)]
    [DataRow("aaa", "b", true)]
    [DataRow("aaa", "bbb", true)]
    [DataRow("xyz", "yza", true)]
    [DataRow("abcde", "bdf", true)]
    [DataRow("abcde", "ace", true)]
    [DataRow("zzz", "aaa", true)]
    [DataRow("ba", "b", true)]
    [DataRow("ba", "a", true)]
    [DataRow("z", "b", false)]
    [DataRow("abcd", "abcde", false)]
    public void CanMakeSubsequence_WithGivenStrings_ReturnsTrueIfPossible(string str1, string str2, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanMakeSubsequence(str1, str2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}