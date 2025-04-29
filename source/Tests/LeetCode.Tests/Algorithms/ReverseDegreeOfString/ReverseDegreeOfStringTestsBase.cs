// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ReverseDegreeOfString;

namespace LeetCode.Tests.Algorithms.ReverseDegreeOfString;

public abstract class ReverseDegreeOfStringTestsBase<T> where T : IReverseDegreeOfString, new()
{
    [TestMethod]
    [DataRow("abc", 148)]
    [DataRow("zaza", 160)]
    public void ReverseDegree_WithInputString_ReturnsCalculatedDegree(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReverseDegree(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}