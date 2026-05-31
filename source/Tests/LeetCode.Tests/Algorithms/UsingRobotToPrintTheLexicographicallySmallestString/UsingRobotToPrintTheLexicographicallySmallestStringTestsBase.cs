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

using LeetCode.Algorithms.UsingRobotToPrintTheLexicographicallySmallestString;

namespace LeetCode.Tests.Algorithms.UsingRobotToPrintTheLexicographicallySmallestString;

public abstract class UsingRobotToPrintTheLexicographicallySmallestStringTestsBase<T> where T : IUsingRobotToPrintTheLexicographicallySmallestString, new()
{
    [TestMethod]
    [DataRow("zza", "azz")]
    [DataRow("bac", "abc")]
    [DataRow("bdda", "addb")]
    [DataRow("bydizfve", "bdevfziy")]
    [DataRow("bzeyxf", "befxyz")]
    [DataRow("vzhofnpo", "fnohopzv")]
    [DataRow("mmuqezwmomeplrtskz", "eekstrlpmomwzqummz")]
    [DataRow("a", "a")]
    [DataRow("z", "z")]
    [DataRow("az", "az")]
    [DataRow("za", "az")]
    [DataRow("abc", "abc")]
    [DataRow("cba", "abc")]
    [DataRow("dcba", "abcd")]
    [DataRow("aaaa", "aaaa")]
    [DataRow("zzzz", "zzzz")]
    [DataRow("azbz", "azbz")]
    [DataRow("cbad", "abcd")]
    [DataRow("edcba", "abcde")]
    [DataRow("abcde", "abcde")]
    [DataRow("zyxwv", "vwxyz")]
    [DataRow("ba", "ab")]
    [DataRow("cab", "abc")]
    public void RobotWithString_WithGivenString_ReturnsLexicographicallySmallestWrittenString(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RobotWithString(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}