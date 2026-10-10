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

using LeetCode.Algorithms.NumberComplement;

namespace LeetCode.Tests.Algorithms.NumberComplement;

public abstract class NumberComplementTestsBase<T> where T : INumberComplement, new()
{
    [TestMethod]
    [DataRow(1, 0)]
    [DataRow(2, 1)]
    [DataRow(3, 0)]
    [DataRow(4, 3)]
    [DataRow(5, 2)]
    [DataRow(6, 1)]
    [DataRow(7, 0)]
    [DataRow(8, 7)]
    [DataRow(9, 6)]
    [DataRow(16, 15)]
    [DataRow(69, 58)]
    [DataRow(911, 112)]
    [DataRow(1073741824, 1073741823)]
    [DataRow(2100003647, 47480000)]
    [DataRow(int.MaxValue, 0)]
    [DataRow(10, 5)]
    [DataRow(11, 4)]
    [DataRow(12, 3)]
    [DataRow(13, 2)]
    [DataRow(15, 0)]
    [DataRow(31, 0)]
    [DataRow(32, 31)]
    [DataRow(33, 30)]
    [DataRow(63, 0)]
    [DataRow(64, 63)]
    [DataRow(100, 27)]
    [DataRow(127, 0)]
    [DataRow(128, 127)]
    [DataRow(255, 0)]
    [DataRow(256, 255)]
    [DataRow(1000, 23)]
    [DataRow(1023, 0)]
    [DataRow(1024, 1023)]
    [DataRow(65535, 0)]
    [DataRow(65536, 65535)]
    [DataRow(1000000, 48575)]
    [DataRow(1048576, 1048575)]
    [DataRow(33554432, 33554431)]
    [DataRow(536870912, 536870911)]
    [DataRow(1073741825, 1073741822)]
    [DataRow(2147483646, 1)]
    [DataRow(1073741823, 0)]
    [DataRow(123456789, 10760938)]
    public void FindComplement_WithGivenNumber_ReturnsBitwiseComplement(int num, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindComplement(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}