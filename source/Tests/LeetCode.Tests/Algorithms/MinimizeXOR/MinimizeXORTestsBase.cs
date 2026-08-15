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

using LeetCode.Algorithms.MinimizeXOR;

namespace LeetCode.Tests.Algorithms.MinimizeXOR;

public abstract class MinimizeXORTestsBase<T> where T : IMinimizeXOR, new()
{
    [TestMethod]
    [DataRow(3, 5, 3)]
    [DataRow(1, 12, 3)]
    [DataRow(1, 1, 1)]
    [DataRow(1, 2, 1)]
    [DataRow(2, 1, 2)]
    [DataRow(2, 3, 3)]
    [DataRow(5, 3, 5)]
    [DataRow(6, 10, 6)]
    [DataRow(10, 6, 10)]
    [DataRow(7, 7, 7)]
    [DataRow(9, 9, 9)]
    [DataRow(8, 1, 8)]
    [DataRow(1, 8, 1)]
    [DataRow(12, 1, 8)]
    [DataRow(15, 3, 12)]
    [DataRow(3, 15, 15)]
    [DataRow(16, 31, 31)]
    [DataRow(31, 16, 16)]
    [DataRow(25, 72, 24)]
    [DataRow(42, 21, 42)]
    [DataRow(65, 84, 67)]
    [DataRow(255, 256, 128)]
    [DataRow(256, 255, 383)]
    [DataRow(1024, 2047, 2047)]
    [DataRow(4096, 4095, 6143)]
    [DataRow(536870912, 7, 536870915)]
    [DataRow(1073741823, 1, 536870912)]
    [DataRow(123456789, 987654321, 123456791)]
    [DataRow(999999999, 999999999, 999999999)]
    [DataRow(1000000000, 1, 536870912)]
    [DataRow(1, 1000000000, 8191)]
    [DataRow(1000000000, 999999999, 1000000255)]
    public void MinimizeXor_WithTwoNumbers_ReturnsNumberWithMinimizedXor(int num1, int num2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimizeXor(num1, num2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}