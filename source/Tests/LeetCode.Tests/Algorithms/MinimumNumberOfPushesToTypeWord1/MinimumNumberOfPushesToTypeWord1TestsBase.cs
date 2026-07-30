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

using LeetCode.Algorithms.MinimumNumberOfPushesToTypeWord1;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfPushesToTypeWord1;

public abstract class MinimumNumberOfPushesToTypeWord1TestsBase<T> where T : IMinimumNumberOfPushesToTypeWord1, new()
{
    [TestMethod]
    [DataRow("a", 1)]
    [DataRow("yz", 2)]
    [DataRow("abc", 3)]
    [DataRow("wxyz", 4)]
    [DataRow("abcde", 5)]
    [DataRow("qwerty", 6)]
    [DataRow("abcdefg", 7)]
    [DataRow("abcdefgh", 8)]
    [DataRow("abcdefghi", 10)]
    [DataRow("qwertyuiop", 12)]
    [DataRow("abcdefghijk", 14)]
    [DataRow("abcdefghijklm", 18)]
    [DataRow("abcdefghijklmno", 22)]
    [DataRow("abcdefghijklmnop", 24)]
    [DataRow("abcdefghijklmnopq", 27)]
    [DataRow("abcdefghijklmnopqr", 30)]
    [DataRow("abcdefghijklmnopqrst", 36)]
    [DataRow("abcdefghijklmnopqrstu", 39)]
    [DataRow("abcdefghijklmnopqrstuvw", 45)]
    [DataRow("abcdefghijklmnopqrstuvwx", 48)]
    [DataRow("abcdefghijklmnopqrstuvwxy", 52)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 56)]
    public void MinimumPushes_WithWord_ReturnsMinimumNumberOfPushes(string word, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumPushes(word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}