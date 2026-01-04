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