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

using LeetCode.Algorithms.StringCompression3;

namespace LeetCode.Tests.Algorithms.StringCompression3;

public abstract class StringCompression3TestsBase<T> where T : IStringCompression3, new()
{
    [TestMethod]
    [DataRow("abcde", "1a1b1c1d1e")]
    [DataRow("aaaaaaaaaaaaaabb", "9a5a2b")]
    public void CompressedString_WithGivenWord_ReturnsCompressedString(string word, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CompressedString(word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}