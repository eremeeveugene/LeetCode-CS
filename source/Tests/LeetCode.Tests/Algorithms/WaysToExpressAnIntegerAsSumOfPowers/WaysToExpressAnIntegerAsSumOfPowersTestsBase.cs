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

using LeetCode.Algorithms.WaysToExpressAnIntegerAsSumOfPowers;

namespace LeetCode.Tests.Algorithms.WaysToExpressAnIntegerAsSumOfPowers;

public abstract class WaysToExpressAnIntegerAsSumOfPowersTestsBase<T> where T : IWaysToExpressAnIntegerAsSumOfPowers, new()
{
    [TestMethod]
    [DataRow(10, 2, 1)]
    [DataRow(4, 1, 2)]
    [DataRow(1, 1, 1)]
    [DataRow(1, 2, 1)]
    [DataRow(1, 5, 1)]
    [DataRow(2, 1, 1)]
    [DataRow(3, 1, 2)]
    [DataRow(5, 1, 3)]
    [DataRow(10, 1, 10)]
    [DataRow(10, 3, 0)]
    [DataRow(13, 2, 1)]
    [DataRow(16, 2, 1)]
    [DataRow(25, 2, 2)]
    [DataRow(36, 2, 1)]
    [DataRow(100, 2, 3)]
    [DataRow(100, 3, 1)]
    [DataRow(160, 3, 1)]
    [DataRow(300, 1, 872471266)]
    [DataRow(300, 2, 25)]
    [DataRow(300, 5, 0)]
    public void NumberOfWays_WithPositiveNAndExponent_ReturnsCountOfUniquePowerSumDecompositions(int n, int x, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfWays(n, x);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}