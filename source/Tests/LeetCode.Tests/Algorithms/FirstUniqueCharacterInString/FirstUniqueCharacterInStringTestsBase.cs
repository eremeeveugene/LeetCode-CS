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

using LeetCode.Algorithms.FirstUniqueCharacterInString;

namespace LeetCode.Tests.Algorithms.FirstUniqueCharacterInString;

public abstract class FirstUniqueCharacterInStringTestsBase<T> where T : IFirstUniqueCharacterInString, new()
{
    [TestMethod]
    [DataRow("leetcode", 0)]
    [DataRow("loveleetcode", 2)]
    [DataRow("aabb", -1)]
    public void FirstUniqChar_GivenString_ReturnsIndexOfFirstUniqueChar(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FirstUniqChar(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}