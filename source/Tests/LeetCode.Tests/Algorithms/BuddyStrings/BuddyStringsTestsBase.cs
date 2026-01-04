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

using LeetCode.Algorithms.BuddyStrings;

namespace LeetCode.Tests.Algorithms.BuddyStrings;

public abstract class BuddyStringsTestsBase<T> where T : IBuddyStrings, new()
{
    [TestMethod]
    [DataRow("ab", "ba", true)]
    [DataRow("ab", "ab", false)]
    [DataRow("aa", "aa", true)]
    [DataRow("abcaa", "abcbb", false)]
    [DataRow("abcd", "abcde", false)]
    public void BuddyStrings_WithGivenStrings_ReturnsTrueIfSingleSwapMakesEqualOtherwiseFalse(string s, string goal,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.BuddyStrings(s, goal);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}