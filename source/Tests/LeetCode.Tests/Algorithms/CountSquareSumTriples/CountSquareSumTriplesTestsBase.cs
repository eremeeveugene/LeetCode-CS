// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CountSquareSumTriples;

namespace LeetCode.Tests.Algorithms.CountSquareSumTriples;

public abstract class CountSquareSumTriplesTestsBase<T> where T : ICountSquareSumTriples, new()
{
    [TestMethod]
    [DataRow(5, 2)]
    [DataRow(10, 4)]
    public void CountTriples_WithUpperBoundLimit_ReturnsNumberOfValidSquareTriples(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountTriples(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}