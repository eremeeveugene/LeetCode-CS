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

using LeetCode.Algorithms.NumberOfStepsToReduceNumberInBinaryRepresentationToOne;

namespace LeetCode.Tests.Algorithms.NumberOfStepsToReduceNumberInBinaryRepresentationToOne;

public abstract class NumberOfStepsToReduceNumberInBinaryRepresentationToOneTestsBase<T>
    where T : INumberOfStepsToReduceNumberInBinaryRepresentationToOne, new()
{
    [TestMethod]
    [DataRow("1101", 6)]
    [DataRow("10", 1)]
    [DataRow("1", 0)]
    [DataRow("1111011110000011100000110001011011110010111001010111110001", 85)]
    public void NumSteps_GivenBinaryString_ReturnsNumberOfStepsToReduceToOne(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumSteps(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}