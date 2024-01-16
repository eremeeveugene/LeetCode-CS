// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ReverseString2;

namespace LeetCode.Tests.Algorithms.ReverseString2;

[TestClass]
public class ReverseString2WithCharArrayTests
{
    [TestMethod]
    [DataRow("abcdefg", 2, "bacdfeg")]
    [DataRow("abcd", 2, "bacd")]
    public void ReverseString2WithCharArray_ReverseStr_WithStringAndInterval_ReturnsPartiallyReversedString(string s,
        int k, string expectedResult)
    {
        // Act
        var actualResult = ReverseString2WithCharArray.ReverseStr(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}