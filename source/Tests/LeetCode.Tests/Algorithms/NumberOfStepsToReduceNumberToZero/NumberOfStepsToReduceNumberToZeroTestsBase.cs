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

using LeetCode.Algorithms.NumberOfStepsToReduceNumberToZero;

namespace LeetCode.Tests.Algorithms.NumberOfStepsToReduceNumberToZero;

public abstract class NumberOfStepsToReduceNumberToZeroTestsBase<T> where T : INumberOfStepsToReduceNumberToZero, new()
{
    [TestMethod]
    [DataRow(14, 6)]
    [DataRow(8, 4)]
    [DataRow(123, 12)]
    public void NumberOfSteps_GivenNumber_ReturnsExpectedStepCount(int nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfSteps(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}