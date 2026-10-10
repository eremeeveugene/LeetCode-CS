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

using LeetCode.Algorithms.CheckIfAllAsAppearsBeforeAllBs;

namespace LeetCode.Tests.Algorithms.CheckIfAllAsAppearsBeforeAllBs;

public abstract class CheckIfAllAsAppearsBeforeAllBsTestsBase<T> where T : ICheckIfAllAsAppearsBeforeAllBs, new()
{
    [TestMethod]
    [DataRow("aaabbb", true)]
    [DataRow("abab", false)]
    [DataRow("bbb", true)]
    [DataRow("a", true)]
    [DataRow("b", true)]
    [DataRow("ab", true)]
    [DataRow("ba", false)]
    [DataRow("aab", true)]
    [DataRow("bba", false)]
    [DataRow("aaaa", true)]
    [DataRow("bbbb", true)]
    [DataRow("abb", true)]
    [DataRow("aba", false)]
    [DataRow("aabb", true)]
    [DataRow("abbb", true)]
    [DataRow("baaa", false)]
    [DataRow("aaab", true)]
    [DataRow("bab", false)]
    [DataRow("abbab", false)]
    [DataRow("aaaabbbb", true)]
    public void CheckString_WithInputString_ReturnsTrueIfAllAsAppearBeforeBs(string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckString(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}