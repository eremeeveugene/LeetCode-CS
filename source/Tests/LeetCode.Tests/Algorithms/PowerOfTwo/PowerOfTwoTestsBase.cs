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
    [DataRow(int.MinValue, false)]
    [DataRow(2, true)]
    [DataRow(4, true)]
    [DataRow(5, false)]
    [DataRow(6, false)]
    [DataRow(7, false)]
    [DataRow(-1, false)]
    [DataRow(-2, false)]
    [DataRow(-16, false)]
    [DataRow(1024, true)]
    [DataRow(1000, false)]
    [DataRow(65536, true)]
    [DataRow(65535, false)]
    [DataRow(1073741824, true)]
    [DataRow(1073741823, false)]
    [DataRow(2147483647, false)]
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