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

using LeetCode.Algorithms.XOROperationInAnArray;

namespace LeetCode.Tests.Algorithms.XOROperationInAnArray;

public abstract class XOROperationInAnArrayTestsBase<T> where T : IXOROperationInAnArray, new()
{
    [TestMethod]
    [DataRow(5, 0, 8)]
    [DataRow(4, 3, 8)]
    [DataRow(1, 0, 0)]
    [DataRow(1, 7, 7)]
    [DataRow(1, 1000, 1000)]
    [DataRow(2, 0, 2)]
    [DataRow(2, 1, 2)]
    [DataRow(3, 0, 6)]
    [DataRow(3, 5, 11)]
    [DataRow(4, 0, 0)]
    [DataRow(5, 7, 7)]
    [DataRow(6, 10, 30)]
    [DataRow(7, 3, 1)]
    [DataRow(8, 8, 0)]
    [DataRow(10, 1, 2)]
    [DataRow(16, 0, 0)]
    [DataRow(25, 13, 61)]
    [DataRow(100, 100, 0)]
    [DataRow(500, 500, 0)]
    [DataRow(1000, 0, 0)]
    public void XorOperation_WithCountAndStartValue_ReturnsXorOfGeneratedArray(int n, int start, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.XorOperation(n, start);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}