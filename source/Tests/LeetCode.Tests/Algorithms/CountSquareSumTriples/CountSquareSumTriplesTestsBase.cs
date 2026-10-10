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

using LeetCode.Algorithms.CountSquareSumTriples;

namespace LeetCode.Tests.Algorithms.CountSquareSumTriples;

public abstract class CountSquareSumTriplesTestsBase<T> where T : ICountSquareSumTriples, new()
{
    [TestMethod]
    [DataRow(5, 2)]
    [DataRow(10, 4)]
    [DataRow(1, 0)]
    [DataRow(2, 0)]
    [DataRow(3, 0)]
    [DataRow(4, 0)]
    [DataRow(6, 2)]
    [DataRow(7, 2)]
    [DataRow(8, 2)]
    [DataRow(9, 2)]
    [DataRow(12, 4)]
    [DataRow(13, 6)]
    [DataRow(15, 8)]
    [DataRow(16, 8)]
    [DataRow(17, 10)]
    [DataRow(20, 12)]
    [DataRow(25, 16)]
    [DataRow(50, 40)]
    [DataRow(100, 104)]
    [DataRow(250, 330)]
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