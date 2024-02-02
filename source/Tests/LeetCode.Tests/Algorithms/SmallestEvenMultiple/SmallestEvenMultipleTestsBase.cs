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

using LeetCode.Algorithms.SmallestEvenMultiple;

namespace LeetCode.Tests.Algorithms.SmallestEvenMultiple;

public abstract class SmallestEvenMultipleTestsBase<T> where T : ISmallestEvenMultiple, new()
{
    [TestMethod]
    [DataRow(5, 10)]
    [DataRow(6, 6)]
    public void SmallestEvenMultiple_WithPositiveAndEqualInputs_ReturnsExpectedResult(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestEvenMultiple(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}