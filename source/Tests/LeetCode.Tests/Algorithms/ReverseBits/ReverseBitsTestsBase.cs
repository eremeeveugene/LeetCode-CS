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

using LeetCode.Algorithms.ReverseBits;

namespace LeetCode.Tests.Algorithms.ReverseBits;

public abstract class ReverseBitsTestsBase<T> where T : IReverseBits, new()
{
    [TestMethod]
    [DataRow("00000010100101000001111010011100", "00111001011110000010100101000000")]
    [DataRow("11111111111111111111111111111101", "10111111111111111111111111111111")]
    public void ReverseBits_WithBinaryString_ReturnsCorrectReversedBits(string nBinaryString,
        string expectedResultBinaryString)
    {
        // Arrange
        var solution = new T();

        var n = Convert.ToUInt32(nBinaryString, 2);
        var expectedResult = Convert.ToUInt32(expectedResultBinaryString, 2);

        // Act
        var actualResult = solution.reverseBits(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}