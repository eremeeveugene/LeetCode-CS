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

using LeetCode.Algorithms.PowerOfTwo;

namespace LeetCode.Tests.Algorithms.PowerOfTwo;

public abstract class PowerOfTwoTestsBase<T> where T : IPowerOfTwo, new()
{
    [TestMethod]
    [DataRow(0, false)]
    [DataRow(1, true)]
    [DataRow(16, true)]
    [DataRow(3, false)]
    [DataRow(8, true)]
    [DataRow(-2147483648, false)]
    public void IsPowerOfTwo_WithNumber_ReturnsTrueIfPowerOfTwoElseFalse(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsPowerOfTwo(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}