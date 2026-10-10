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

using LeetCode.Algorithms.ComputeDecimalRepresentation;

namespace LeetCode.Tests.Algorithms.ComputeDecimalRepresentation;

public abstract class ComputeDecimalRepresentationTestsBase<T> where T : IComputeDecimalRepresentation, new()
{
    [TestMethod]
    [DataRow(537, new[] { 500, 30, 7 })]
    [DataRow(102, new[] { 100, 2 })]
    [DataRow(6, new[] { 6 })]
    [DataRow(1, new[] { 1 })]
    [DataRow(10, new[] { 10 })]
    [DataRow(100, new[] { 100 })]
    [DataRow(11, new[] { 10, 1 })]
    [DataRow(99, new[] { 90, 9 })]
    [DataRow(101, new[] { 100, 1 })]
    [DataRow(1000, new[] { 1000 })]
    [DataRow(1234, new[] { 1000, 200, 30, 4 })]
    [DataRow(9999, new[] { 9000, 900, 90, 9 })]
    [DataRow(10001, new[] { 10000, 1 })]
    [DataRow(100000, new[] { 100000 })]
    [DataRow(123456789, new[] { 100000000, 20000000, 3000000, 400000, 50000, 6000, 700, 80, 9 })]
    [DataRow(1000000000, new[] { 1000000000 })]
    [DataRow(999999999, new[] { 900000000, 90000000, 9000000, 900000, 90000, 9000, 900, 90, 9 })]
    [DataRow(505, new[] { 500, 5 })]
    [DataRow(2020, new[] { 2000, 20 })]
    [DataRow(30, new[] { 30 })]
    [DataRow(7, new[] { 7 })]
    [DataRow(65432, new[] { 60000, 5000, 400, 30, 2 })]
    public void DecimalRepresentation_WithPositiveInteger_ReturnsFewestBase10ComponentsInDescendingOrder(int n, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DecimalRepresentation(n);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}