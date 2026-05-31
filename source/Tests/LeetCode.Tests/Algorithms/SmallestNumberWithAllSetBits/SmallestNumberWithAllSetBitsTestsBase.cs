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

using LeetCode.Algorithms.SmallestNumberWithAllSetBits;

namespace LeetCode.Tests.Algorithms.SmallestNumberWithAllSetBits;

public abstract class SmallestNumberWithAllSetBitsTestsBase<T> where T : ISmallestNumberWithAllSetBits, new()
{
    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(2, 3)]
    [DataRow(3, 3)]
    [DataRow(4, 7)]
    [DataRow(5, 7)]
    [DataRow(7, 7)]
    [DataRow(8, 15)]
    [DataRow(10, 15)]
    [DataRow(15, 15)]
    [DataRow(16, 31)]
    [DataRow(20, 31)]
    [DataRow(31, 31)]
    [DataRow(32, 63)]
    [DataRow(63, 63)]
    [DataRow(64, 127)]
    [DataRow(127, 127)]
    [DataRow(128, 255)]
    [DataRow(255, 255)]
    [DataRow(256, 511)]
    [DataRow(511, 511)]
    [DataRow(512, 1023)]
    [DataRow(1023, 1023)]
    [DataRow(1024, 1023)]
    [DataRow(int.MaxValue, 1023)]
    public void SmallestNumber_WithPositiveNumberN_ReturnsSmallestNumberWithSetBits(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestNumber(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}