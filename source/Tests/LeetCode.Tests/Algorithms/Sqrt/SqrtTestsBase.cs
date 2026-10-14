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

using LeetCode.Algorithms.Sqrt;

namespace LeetCode.Tests.Algorithms.Sqrt;

public abstract class SqrtTestsBase<T> where T : ISqrt, new()
{
    [TestMethod]
    [DataRow(0, 0)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 2)]
    [DataRow(8, 2)]
    [DataRow(10, 3)]
    [DataRow(17, 4)]
    [DataRow(2147395599, 46339)]
    [DataRow(5, 2)]
    [DataRow(9, 3)]
    [DataRow(15, 3)]
    [DataRow(16, 4)]
    [DataRow(24, 4)]
    [DataRow(25, 5)]
    [DataRow(100, 10)]
    [DataRow(99, 9)]
    [DataRow(2147483647, 46340)]
    [DataRow(2147395600, 46340)]
    [DataRow(1000000, 1000)]
    [DataRow(65535, 255)]
    public void MySqrt_WithInteger_CalculatesSquareRoot(int x, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MySqrt(x);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}