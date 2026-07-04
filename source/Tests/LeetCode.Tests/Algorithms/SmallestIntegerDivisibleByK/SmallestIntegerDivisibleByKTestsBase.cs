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

using LeetCode.Algorithms.SmallestIntegerDivisibleByK;

namespace LeetCode.Tests.Algorithms.SmallestIntegerDivisibleByK;

public abstract class SmallestIntegerDivisibleByKTestsBase<T> where T : ISmallestIntegerDivisibleByK, new()
{
    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(2, -1)]
    [DataRow(3, 3)]
    [DataRow(5, -1)]
    [DataRow(7, 6)]
    [DataRow(9, 9)]
    [DataRow(11, 2)]
    [DataRow(13, 6)]
    [DataRow(17, 16)]
    [DataRow(19, 18)]
    [DataRow(21, 6)]
    [DataRow(23, 22)]
    [DataRow(27, 27)]
    [DataRow(29, 28)]
    [DataRow(31, 15)]
    [DataRow(33, 6)]
    [DataRow(37, 3)]
    [DataRow(41, 5)]
    [DataRow(63, 18)]
    [DataRow(81, 81)]
    [DataRow(99, 18)]
    [DataRow(101, 4)]
    [DataRow(333, 9)]
    [DataRow(999, 27)]
    [DataRow(7919, 3959)]
    [DataRow(12345, -1)]
    [DataRow(54321, 8568)]
    [DataRow(88888, -1)]
    [DataRow(99999, 45)]
    [DataRow(100000, -1)]
    public void SmallestRepunitDivByK_WithPositiveInteger_ReturnsSmallestRepunitLength(int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestRepunitDivByK(k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}