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

using LeetCode.Algorithms.ArrangingCoins;

namespace LeetCode.Tests.Algorithms.ArrangingCoins;

public abstract class ArrangingCoinsTestsBase<T> where T : IArrangingCoins, new()
{
    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 2)]
    [DataRow(4, 2)]
    [DataRow(5, 2)]
    [DataRow(6, 3)]
    [DataRow(7, 3)]
    [DataRow(8, 3)]
    [DataRow(9, 3)]
    [DataRow(10, 4)]
    [DataRow(11, 4)]
    [DataRow(15, 5)]
    [DataRow(16, 5)]
    [DataRow(21, 6)]
    [DataRow(28, 7)]
    [DataRow(100, 13)]
    [DataRow(1000, 44)]
    [DataRow(5049, 99)]
    [DataRow(5050, 100)]
    [DataRow(2147483647, 65535)]
    public void ArrangeCoins_WithCoinCount_ReturnsNumberOfCompleteStaircaseRows(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ArrangeCoins(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}