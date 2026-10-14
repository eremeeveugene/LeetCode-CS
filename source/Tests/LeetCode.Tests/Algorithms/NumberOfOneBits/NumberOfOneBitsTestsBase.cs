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

using LeetCode.Algorithms.NumberOfOneBits;

namespace LeetCode.Tests.Algorithms.NumberOfOneBits;

public abstract class NumberOfOneBitsTestsBase<T> where T : INumberOfOneBits, new()
{
    [TestMethod]
    [DataRow(11, 3)]
    [DataRow(128, 1)]
    [DataRow(2147483645, 30)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 2)]
    [DataRow(7, 3)]
    [DataRow(8, 1)]
    [DataRow(15, 4)]
    [DataRow(16, 1)]
    [DataRow(255, 8)]
    [DataRow(256, 1)]
    [DataRow(1023, 10)]
    [DataRow(1024, 1)]
    [DataRow(65535, 16)]
    [DataRow(65536, 1)]
    [DataRow(65537, 2)]
    [DataRow(1073741824, 1)]
    [DataRow(2147483647, 31)]
    [DataRow(2147483646, 30)]
    [DataRow(1431655765, 16)]
    [DataRow(1000000000, 13)]
    [DataRow(123456789, 16)]
    [DataRow(1073741823, 30)]
    public void HammingWeight_WithIntegerInput_ReturnsNumberOfSetBits(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HammingWeight(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}