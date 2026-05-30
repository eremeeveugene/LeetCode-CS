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

using LeetCode.Algorithms.FindTheEncryptedString;

namespace LeetCode.Tests.Algorithms.FindTheEncryptedString;

public abstract class FindTheEncryptedStringTestsBase<T> where T : IFindTheEncryptedString, new()
{
    [TestMethod]
    [DataRow("dart", 3, "tdar")]
    [DataRow("aaa", 1, "aaa")]
    public void GetEncryptedString_WithStringAndShiftValue_ReturnsEncryptedString(string s, int k, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetEncryptedString(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}