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

using LeetCode.Algorithms.ConstructStringWithRepeatLimit;

namespace LeetCode.Tests.Algorithms.ConstructStringWithRepeatLimit;

public abstract class ConstructStringWithRepeatLimitTestsBase<T> where T : IConstructStringWithRepeatLimit, new()
{
    [TestMethod]
    [DataRow("cczazcc", 3, "zzcccac")]
    [DataRow("aababab", 2, "bbabaa")]
    public void RepeatLimitedString_WithInputStringAndRepeatLimit_ReturnsLexicographicallyLargestString(string s,
        int repeatLimit, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RepeatLimitedString(s, repeatLimit);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}