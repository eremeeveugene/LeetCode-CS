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

using LeetCode.Algorithms.SpecialArrayWithXElementsGreaterThanOrEqualX;

namespace LeetCode.Tests.Algorithms.SpecialArrayWithXElementsGreaterThanOrEqualX;

public abstract class SpecialArrayWithXElementsGreaterThanOrEqualXTestsBase<T> where T : ISpecialArrayWithXElementsGreaterThanOrEqualX, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 5 }, 2)]
    [DataRow(new[] { 0, 0 }, -1)]
    [DataRow(new[] { 0, 4, 3, 0, 4 }, 3)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 0 }, -1)]
    [DataRow(new[] { 100 }, 1)]
    [DataRow(new[] { 1, 1 }, -1)]
    [DataRow(new[] { 2, 2 }, 2)]
    [DataRow(new[] { 0, 1 }, 1)]
    [DataRow(new[] { 0, 0, 0 }, -1)]
    [DataRow(new[] { 3, 3, 3 }, 3)]
    [DataRow(new[] { 1, 2, 3 }, 2)]
    [DataRow(new[] { 0, 0, 1 }, 1)]
    [DataRow(new[] { 0, 3, 4, 5 }, 3)]
    [DataRow(new[] { 1, 1, 1, 1 }, -1)]
    [DataRow(new[] { 4, 4, 4, 4 }, 4)]
    [DataRow(new[] { 0, 1, 2, 3 }, 2)]
    [DataRow(new[] { 5 }, 1)]
    [DataRow(new[] { 2, 0 }, 1)]
    [DataRow(new[] { 10, 10, 10, 10, 10 }, 5)]
    public void SpecialArray_WithNonNegativeIntegerArray_ReturnsXIfExactlyXElementsAreGreaterThanOrEqualToX(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SpecialArray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}