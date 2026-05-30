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

using LeetCode.Algorithms.SmallestNumberWithAllSetBits;

namespace LeetCode.Tests.Algorithms.SmallestNumberWithAllSetBits;

public abstract class SmallestNumberWithAllSetBitsTestsBase<T> where T : ISmallestNumberWithAllSetBits, new()
{
    [TestMethod]
    [DataRow(5, 7)]
    [DataRow(10, 15)]
    [DataRow(3, 3)]
    public void SmallestNumber_WithPositiveNumberN_ReturnsSmallestNumberWithSetBits(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestNumber(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}