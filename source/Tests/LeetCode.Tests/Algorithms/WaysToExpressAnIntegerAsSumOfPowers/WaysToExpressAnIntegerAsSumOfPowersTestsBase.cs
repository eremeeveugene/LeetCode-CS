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