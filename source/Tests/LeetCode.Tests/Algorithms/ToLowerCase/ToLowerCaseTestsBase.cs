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

using LeetCode.Algorithms.ToLowerCase;

namespace LeetCode.Tests.Algorithms.ToLowerCase;

public abstract class ToLowerCaseTestsBase<T> where T : IToLowerCase, new()
{
    [TestMethod]
    [DataRow("Hello", "hello")]
    [DataRow("here", "here")]
    [DataRow("LOVELY", "lovely")]
    [DataRow("Hello World", "hello world")]
    [DataRow("ABC123", "abc123")]
    [DataRow("abc", "abc")]
    [DataRow("XYZ", "xyz")]
    [DataRow("aBcDeF", "abcdef")]
    [DataRow("123", "123")]
    [DataRow("!@#", "!@#")]
    [DataRow("A", "a")]
    [DataRow("z", "z")]
    [DataRow("Z", "z")]
    [DataRow("a", "a")]
    [DataRow("MixEd CaSe 42!", "mixed case 42!")]
    [DataRow("Test_Case", "test_case")]
    [DataRow("C#", "c#")]
    [DataRow("LeetCode", "leetcode")]
    [DataRow("Al2 & Bob", "al2 & bob")]
    [DataRow("UPPER lower 99", "upper lower 99")]
    [DataRow("Hello, World!", "hello, world!")]
    [DataRow("Goodbye", "goodbye")]
    public void ToLowerCase_GivenStringInput_ReturnsLowercaseString(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ToLowerCase(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}