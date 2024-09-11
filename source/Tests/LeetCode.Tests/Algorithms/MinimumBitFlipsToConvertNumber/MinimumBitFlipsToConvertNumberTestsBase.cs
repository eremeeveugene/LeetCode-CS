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

using LeetCode.Algorithms.MinimumBitFlipsToConvertNumber;

namespace LeetCode.Tests.Algorithms.MinimumBitFlipsToConvertNumber;

public abstract class MinimumBitFlipsToConvertNumberTestsBase<T> where T : IMinimumBitFlipsToConvertNumber, new()
{
    [TestMethod]
    [DataRow(0, 0, 0)]
    [DataRow(10, 7, 3)]
    [DataRow(3, 4, 3)]
    [DataRow(8, 15, 3)]
    [DataRow(170, 85, 8)]
    [DataRow(536870911, 0, 29)]
    [DataRow(536868863, 2048, 29)]
    [DataRow(1000000000, 1, 14)]
    [DataRow(16777215, 536870911, 5)]
    [DataRow(987654321, 123456789, 15)]
    public void MinBitFlips_WithStartAndGoal_ReturnsMinNumberOfFlips(int start, int goal, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinBitFlips(start, goal);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}