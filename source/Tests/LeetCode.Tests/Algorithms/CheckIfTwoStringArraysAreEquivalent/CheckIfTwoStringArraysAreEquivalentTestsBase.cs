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

using LeetCode.Algorithms.CheckIfTwoStringArraysAreEquivalent;

namespace LeetCode.Tests.Algorithms.CheckIfTwoStringArraysAreEquivalent;

public abstract class CheckIfTwoStringArraysAreEquivalentTestsBase<T> where T : ICheckIfTwoStringArraysAreEquivalent, new()
{
    [TestMethod]
    [DataRow(new[] { "ab", "c" }, new[] { "a", "bc" }, true)]
    [DataRow(new[] { "a", "cb" }, new[] { "ab", "c" }, false)]
    [DataRow(new[] { "abc", "d", "defg" }, new[] { "abcddefg" }, true)]
    [DataRow(new[] { "ecxarwyyy", "ppf", "tdyayjd" }, new[] { "ecxarwyyyppft", "dyayj", "q" }, false)]
    [DataRow(new[] { "a", "b", "c" }, new[] { "abc" }, true)]
    [DataRow(new[] { "abc" }, new[] { "a", "b", "c" }, true)]
    [DataRow(new[] { "abc" }, new[] { "ab", "d" }, false)]
    [DataRow(new[] { "a" }, new[] { "a" }, true)]
    [DataRow(new[] { "a" }, new[] { "b" }, false)]
    [DataRow(new[] { "ab" }, new[] { "ab" }, true)]
    [DataRow(new[] { "abc" }, new[] { "abc" }, true)]
    [DataRow(new[] { "abc" }, new[] { "abcd" }, false)]
    [DataRow(new[] { "a", "b" }, new[] { "b", "a" }, false)]
    [DataRow(new[] { "hello", "world" }, new[] { "helloworld" }, true)]
    [DataRow(new[] { "hello", "world" }, new[] { "hello", "worl", "d" }, true)]
    [DataRow(new[] { "x" }, new[] { "x" }, true)]
    [DataRow(new[] { "z", "z" }, new[] { "zz" }, true)]
    [DataRow(new[] { "ab", "cd" }, new[] { "abc" }, false)]
    [DataRow(new[] { "foo", "bar" }, new[] { "fooba", "r" }, true)]
    [DataRow(new[] { "ab", "cd", "ef" }, new[] { "abcde", "f" }, true)]
    public void ArrayStringsAreEqual_GivenTwoStringArrays_ReturnsBooleanIndicatingEquality(string[] word1, string[] word2, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ArrayStringsAreEqual(word1, word2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}