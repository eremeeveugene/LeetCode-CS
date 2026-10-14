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

using LeetCode.Algorithms.AddTwoIntegers;

namespace LeetCode.Tests.Algorithms.AddTwoIntegers;

public abstract class AddTwoIntegersTestsBase<T> where T : IAddTwoIntegers, new()
{
    [TestMethod]
    [DataRow(12, 5, 17)]
    [DataRow(-10, 4, -6)]
    [DataRow(0, 0, 0)]
    [DataRow(1, 1, 2)]
    [DataRow(100, 100, 200)]
    [DataRow(-100, -100, -200)]
    [DataRow(-100, 100, 0)]
    [DataRow(50, -50, 0)]
    [DataRow(0, 7, 7)]
    [DataRow(7, 0, 7)]
    [DataRow(-1, -1, -2)]
    [DataRow(-5, 5, 0)]
    [DataRow(99, 1, 100)]
    [DataRow(-99, -1, -100)]
    [DataRow(25, 75, 100)]
    [DataRow(33, -67, -34)]
    [DataRow(-45, -55, -100)]
    [DataRow(10, 20, 30)]
    [DataRow(1, -1, 0)]
    [DataRow(60, 40, 100)]
    public void Sum_WithTwoIntegers_ReturnsTotalSum(int num1, int num2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Sum(num1, num2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}