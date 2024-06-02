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

using LeetCode.Algorithms.LongestCommonPrefix;

namespace LeetCode.Tests.Algorithms.LongestCommonPrefix;

public abstract class LongestCommonPrefixTestsBase<T> where T : ILongestCommonPrefix, new()
{
    [TestMethod]
    [DataRow(new[] { "" }, "")]
    [DataRow(new[] { "dog", "racecar", "car" }, "")]
    [DataRow(new[] { "flower", "flow", "flight" }, "fl")]
    [DataRow(new[] { "flower", "flower", "flower", "flower" }, "flower")]
    [DataRow(new[] { "interview", "interrupt", "integrate", "integral" }, "inte")]
    [DataRow(new[] { "interspecies", "interstellar", "interstate" }, "inters")]
    [DataRow(new[] { "throne", "throne" }, "throne")]
    [DataRow(new[] { "throne", "throne", "thro" }, "thro")]
    [DataRow(new[] { "a", "b" }, "")]
    [DataRow(new[] { "a" }, "a")]
    [DataRow(new[] { "abcd" }, "abcd")]
    [DataRow(new[] { "prefix", "pretext", "preference", "pre" }, "pre")]
    [DataRow(new[] { "ab", "ab", "abc" }, "ab")]
    [DataRow(new[] { "longest", "longer", "long", "longing" }, "long")]
    public void LongestCommonPrefix_GivenStringsArray_ReturnsCorrectCommonPrefix(string[] strs, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestCommonPrefix(strs);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}