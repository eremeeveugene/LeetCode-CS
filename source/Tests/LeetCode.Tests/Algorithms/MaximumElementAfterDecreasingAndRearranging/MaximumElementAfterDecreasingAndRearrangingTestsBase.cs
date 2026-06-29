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

using LeetCode.Algorithms.MaximumElementAfterDecreasingAndRearranging;

namespace LeetCode.Tests.Algorithms.MaximumElementAfterDecreasingAndRearranging;

public abstract class MaximumElementAfterDecreasingAndRearrangingTestsBase<T> where T : IMaximumElementAfterDecreasingAndRearranging, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 2, 1, 2, 1 }, 2)]
    [DataRow(new[] { 100, 1, 1000 }, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 5 }, 1)]
    [DataRow(new[] { 3, 1, 1 }, 2)]
    [DataRow(new[] { 2, 2, 2, 2 }, 2)]
    [DataRow(new[] { 7, 7, 7, 7, 7 }, 5)]
    [DataRow(new[] { 1, 1, 1 }, 1)]
    [DataRow(new[] { 4, 1, 5, 3, 2 }, 5)]
    [DataRow(new[] { 10, 1, 2 }, 3)]
    [DataRow(new[] { 2, 1 }, 2)]
    [DataRow(new[] { 1, 4, 4, 4 }, 4)]
    [DataRow(new[] { 3, 3, 3 }, 3)]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, 6)]
    [DataRow(new[] { 8, 8 }, 2)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 1)]
    [DataRow(new[] { 2, 3, 4, 5, 6 }, 5)]
    [DataRow(new[] { 100, 100, 100 }, 3)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 9, 1, 1, 1, 1 }, 2)]
    [DataRow(new[] { 5, 4, 3, 2, 1, 1 }, 5)]
    [DataRow(new[] { 1000, 999, 998 }, 3)]
    public void MaximumElementAfterDecrementingAndRearranging_WithInputArray_ReturnsMaximumLastElement(int[] arr, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumElementAfterDecrementingAndRearranging(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}