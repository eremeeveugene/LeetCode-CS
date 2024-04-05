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

using LeetCode.Algorithms.MakeTheStringGreat;

namespace LeetCode.Tests.Algorithms.MakeTheStringGreat;

public abstract class MakeTheStringGreatTestsBase<T> where T : IMakeTheStringGreat, new()
{
    [TestMethod]
    [DataRow("", "")]
    [DataRow("s", "s")]
    [DataRow("leEeetcode", "leetcode")]
    [DataRow("abBAcC", "")]
    [DataRow("djrDdRJD", "")]
    public void MakeGood_WhenGivenStrings_RemovesAdjacentOppositeCasePairs(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MakeGood(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}