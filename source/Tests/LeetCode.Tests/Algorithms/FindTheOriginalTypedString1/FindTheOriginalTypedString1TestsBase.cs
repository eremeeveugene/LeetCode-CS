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

using LeetCode.Algorithms.FindTheOriginalTypedString1;

namespace LeetCode.Tests.Algorithms.FindTheOriginalTypedString1;

public abstract class FindTheOriginalTypedString1TestsBase<T> where T : IFindTheOriginalTypedString1, new()
{
    [TestMethod]
    [DataRow("abbcccc", 5)]
    [DataRow("abcd", 1)]
    [DataRow("aaaa", 4)]
    [DataRow("ere", 1)]
    [DataRow("a", 1)]
    [DataRow("aa", 2)]
    [DataRow("ab", 1)]
    [DataRow("aab", 2)]
    [DataRow("abb", 2)]
    [DataRow("aabb", 3)]
    [DataRow("aaabbbccc", 7)]
    [DataRow("abcabc", 1)]
    [DataRow("zzzzzzzzzz", 10)]
    [DataRow("abababab", 1)]
    [DataRow("aabaa", 3)]
    [DataRow("xyyz", 2)]
    [DataRow("qqqwqq", 4)]
    [DataRow("mississippi", 4)]
    [DataRow("aaaaaaaaaaaaaaaaaaaa", 20)]
    [DataRow("baab", 2)]
    public void PossibleStringCount_WithGivenTypedString_ReturnsPossibleOriginalStringCount(string word, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PossibleStringCount(word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}