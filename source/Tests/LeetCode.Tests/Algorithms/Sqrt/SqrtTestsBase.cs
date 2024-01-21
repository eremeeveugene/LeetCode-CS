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