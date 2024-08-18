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

using LeetCode.Algorithms.UglyNumber2;

namespace LeetCode.Tests.Algorithms.UglyNumber2;

public abstract class UglyNumber2TestsBase<T> where T : IUglyNumber2, new()
{
    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(7, 8)]
    [DataRow(8, 9)]
    [DataRow(10, 12)]
    [DataRow(69, 540)]
    [DataRow(420, 393216)]
    [DataRow(1287, 284765625)]
    [DataRow(1689, 2109375000)]
    [DataRow(1690, 2123366400)]
    public void NthUglyNumber_WithGivenN_ReturnsExpectedUglyNumber(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NthUglyNumber(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}