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
    [DataRow("11", 3)]
    [DataRow("100", 2)]
    [DataRow("101", 5)]
    [DataRow("111", 4)]
    [DataRow("1000", 3)]
    [DataRow("1010", 6)]
    [DataRow("1011", 6)]
    [DataRow("1111", 5)]
    [DataRow("10000", 4)]
    [DataRow("11011", 7)]
    [DataRow("101010", 9)]
    [DataRow("111111", 7)]
    [DataRow("11111111111111111111", 21)]
    [DataRow("1000000000000000000000000000000", 30)]
    [DataRow("10101010101010101010101010101010101010101", 62)]
    [DataRow("10000000011100001010100000110101011010110111001000111010111001100101011101100011111001011011110011010101111010010011010000001111011000110101010101001011011011110101001001011001110100000001001100111111000000110011100111000001001110011110110011001101011010110100001001011101110001111000001010111101100101011101110110111100100110100110011001100101000100110001111011010011101110000100110110111011011001000111101011011101000010011100101111000100011100110000000110100011010110010111011001001000100011110100", 745)]
    [DataRow("1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111", 101)]
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