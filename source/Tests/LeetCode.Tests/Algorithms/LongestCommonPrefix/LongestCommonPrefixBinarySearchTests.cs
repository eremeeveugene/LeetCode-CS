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

[TestClass]
public class LongestCommonPrefixBinarySearchTests
{
    [TestMethod]
    [DataRow(new[] { "" }, "")]
    [DataRow(new[] { "dog", "racecar", "car" }, "")]
    [DataRow(new[] { "flower", "flow", "flight" }, "fl")]
    [DataRow(new[] { "flower", "flower", "flower", "flower" }, "flower")]
    public void LongestCommonPrefix_GivenStringsArray_ReturnsCorrectCommonPrefix(string[] strs, string expectedResult)
    {
        // Arrange
        var longestCommonPrefixBinarySearch = new LongestCommonPrefixBinarySearch();

        // Act
        var actualResult = longestCommonPrefixBinarySearch.LongestCommonPrefix(strs);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}