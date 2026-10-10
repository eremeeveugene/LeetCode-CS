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

using LeetCode.Algorithms.RansomNote;

namespace LeetCode.Tests.Algorithms.RansomNote;

public abstract class RansomNoteTestsBase<T> where T : IRansomNote, new()
{
    [TestMethod]
    [DataRow("a", "b", false)]
    [DataRow("aa", "ab", false)]
    [DataRow("aa", "aab", true)]
    [DataRow("a", "a", true)]
    [DataRow("z", "z", true)]
    [DataRow("z", "a", false)]
    [DataRow("a", "z", false)]
    [DataRow("zz", "zzz", true)]
    [DataRow("zzz", "zz", false)]
    [DataRow("abc", "cba", true)]
    [DataRow("abc", "ab", false)]
    [DataRow("aab", "baa", true)]
    [DataRow("aabb", "abab", true)]
    [DataRow("xyz", "zyxwvu", true)]
    [DataRow("hello", "olleh", true)]
    [DataRow("hello", "helo", false)]
    [DataRow("zebra", "abrez", true)]
    [DataRow("aa", "a", false)]
    [DataRow("b", "abcdefghijklmnopqrstuvwxy", true)]
    [DataRow("z", "abcdefghijklmnopqrstuvwxy", false)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", "zyxwvutsrqponmlkjihgfedcba", true)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxy", false)]
    public void CanConstruct_WithRansomNoteAndMagazine_ReturnsWhetherConstructIsPossible(string ransomNote, string magazine, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanConstruct(ransomNote, magazine);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void CanConstruct_WithMaxLengthStrings_ReturnsTrue()
    {
        // Arrange
        var solution = new T();

        var ransomNote = new char[100000];
        var magazine = new char[100000];

        for (var i = 0; i < ransomNote.Length; i++)
        {
            ransomNote[i] = (char)('a' + (i % 26));
            magazine[magazine.Length - 1 - i] = (char)('a' + (i % 26));
        }

        // Act
        var actualResult = solution.CanConstruct(new string(ransomNote), new string(magazine));

        // Assert
        Assert.IsTrue(actualResult);
    }

    [TestMethod]
    public void CanConstruct_WithMaxLengthStringsMissingOneLetter_ReturnsFalse()
    {
        // Arrange
        var solution = new T();

        var ransomNote = new char[100000];
        var magazine = new char[100000];

        for (var i = 0; i < ransomNote.Length; i++)
        {
            ransomNote[i] = 'z';
            magazine[i] = 'z';
        }

        magazine[99999] = 'y';

        // Act
        var actualResult = solution.CanConstruct(new string(ransomNote), new string(magazine));

        // Assert
        Assert.IsFalse(actualResult);
    }
}