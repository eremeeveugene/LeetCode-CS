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

using LeetCode.Algorithms.CountAndSay;

namespace LeetCode.Tests.Algorithms.CountAndSay;

public abstract class CountAndSayTestsBase<T> where T : ICountAndSay, new()
{
    [TestMethod]
    [DataRow(1, "1")]
    [DataRow(2, "11")]
    [DataRow(3, "21")]
    [DataRow(4, "1211")]
    public void CountAndSay_WithPositiveIntegerInput_ReturnsNthElementOfTheSequence(int n, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountAndSay(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}