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

using LeetCode.Algorithms.ComplementOfBase10Integer;

namespace LeetCode.Tests.Algorithms.ComplementOfBase10Integer;

public abstract class ComplementOfBase10IntegerTestsBase<T> where T : IComplementOfBase10Integer, new()
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
    [DataRow(911, 112)]
    [DataRow(1073741824, 1073741823)]
    [DataRow(2100003647, 47480000)]
    [DataRow(int.MaxValue, 0)]
    public void BitwiseComplement_WithNumber_ReturnsComplement(int num, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.BitwiseComplement(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}