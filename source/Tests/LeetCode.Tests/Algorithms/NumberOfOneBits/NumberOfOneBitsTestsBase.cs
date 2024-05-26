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

using LeetCode.Algorithms.NumberOfOneBits;

namespace LeetCode.Tests.Algorithms.NumberOfOneBits;

public abstract class NumberOfOneBitsTestsBase<T> where T : INumberOfOneBits, new()
{
    [TestMethod]
    [DataRow(11, 3)]
    [DataRow(128, 1)]
    [DataRow(2147483645, 30)]
    public void HammingWeight_WithIntegerInput_ReturnsNumberOfSetBits(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HammingWeight(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}