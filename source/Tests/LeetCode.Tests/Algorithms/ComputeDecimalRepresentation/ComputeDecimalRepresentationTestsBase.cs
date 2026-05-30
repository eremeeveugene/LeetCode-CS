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
    public void DecimalRepresentation_WithPositiveInteger_ReturnsFewestBase10ComponentsInDescendingOrder(int n, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DecimalRepresentation(n);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}