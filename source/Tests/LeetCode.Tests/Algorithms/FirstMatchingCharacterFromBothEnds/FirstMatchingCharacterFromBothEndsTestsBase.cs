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

using LeetCode.Algorithms.FirstMatchingCharacterFromBothEnds;

namespace LeetCode.Tests.Algorithms.FirstMatchingCharacterFromBothEnds;

public abstract class FirstMatchingCharacterFromBothEndsTestsBase<T>
    where T : IFirstMatchingCharacterFromBothEnds, new()
{
    [TestMethod]
    [DataRow("abc", 1)]
    [DataRow("abcacbd", 1)]
    [DataRow("abcdab", -1)]
    public void FirstMatchingIndex_WithGivenString_ReturnsSmallestSymmetricMatchingIndexOrMinusOne(string s,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FirstMatchingIndex(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}