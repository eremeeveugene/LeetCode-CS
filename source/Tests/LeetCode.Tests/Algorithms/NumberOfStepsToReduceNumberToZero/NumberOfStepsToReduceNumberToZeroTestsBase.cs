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

using LeetCode.Algorithms.NumberOfStepsToReduceNumberToZero;

namespace LeetCode.Tests.Algorithms.NumberOfStepsToReduceNumberToZero;

public abstract class NumberOfStepsToReduceNumberToZeroTestsBase<T> where T : INumberOfStepsToReduceNumberToZero, new()
{
    [TestMethod]
    [DataRow(14, 6)]
    [DataRow(8, 4)]
    [DataRow(123, 12)]
    [DataRow(0, 0)]
    [DataRow(1, 1)]
    [DataRow(2, 2)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    [DataRow(5, 4)]
    [DataRow(7, 5)]
    [DataRow(15, 7)]
    [DataRow(16, 5)]
    [DataRow(31, 9)]
    [DataRow(32, 6)]
    [DataRow(100, 9)]
    [DataRow(255, 15)]
    [DataRow(256, 9)]
    [DataRow(1000, 15)]
    [DataRow(65535, 31)]
    [DataRow(524288, 20)]
    [DataRow(999999, 31)]
    [DataRow(1000000, 26)]
    public void NumberOfSteps_WithPositiveInteger_ReturnsCountToReduceNumberToZero(int nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfSteps(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}