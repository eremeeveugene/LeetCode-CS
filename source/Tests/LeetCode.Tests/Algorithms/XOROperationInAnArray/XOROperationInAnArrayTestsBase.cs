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

using LeetCode.Algorithms.XOROperationInAnArray;

namespace LeetCode.Tests.Algorithms.XOROperationInAnArray;

public abstract class XOROperationInAnArrayTestsBase<T> where T : IXOROperationInAnArray, new()
{
    [TestMethod]
    [DataRow(5, 0, 8)]
    [DataRow(4, 3, 8)]
    public void XorOperation_WithStartAndNumberOfElements_ReturnsExpectedXorValue(int n, int start, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.XorOperation(n, start);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}